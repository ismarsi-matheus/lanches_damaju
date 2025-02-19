using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace lanches_damaju
{
    public partial class Gerenciamento_Clientes : Form
    {
        private string connectionString = "Server=localhost; Port=3306; Database=db_lanches_damaju; Uid=root; Pwd=;";

        public Gerenciamento_Clientes()
        {
            InitializeComponent();
        }

        // CONSULTA CLIENTES NO BANCO E EXIBE NO DATA GRID VIEW
        private void button_consultar_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conexao = new MySqlConnection(connectionString))
                {
                    conexao.Open();

                    string query = "SELECT id_cliente,senha,email,CEP,CPF,numero,telefone,imagem,nome FROM tb_cliente";

                    using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                    {
                        MySqlDataReader reader = cmd.ExecuteReader();
                        DataTable dadosClientes = new DataTable();
                        dadosClientes.Load(reader);

                        // Exibir dados no DataGridView
                        dgv_clientes.DataSource = dadosClientes;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao consultar clientes: " + ex.Message);
            }
        }

        // REMOVE O CLIENTE SELECIONADO
        private void button_excluir_Click(object sender, EventArgs e)
        {
            if (dgv_clientes.SelectedRows.Count > 0)
            {
                int clienteID = Convert.ToInt32(dgv_clientes.SelectedRows[0].Cells["id_cliente"].Value);

                DialogResult result = MessageBox.Show("Tem certeza que deseja excluir este cliente?", "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        using (MySqlConnection conexao = new MySqlConnection(connectionString))
                        {
                            conexao.Open();

                            string query = "DELETE FROM tb_cliente WHERE id_cliente = @id_cliente";

                            using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                            {
                                cmd.Parameters.AddWithValue("@id_cliente", clienteID);

                                int rowsAffected = cmd.ExecuteNonQuery();
                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Cliente excluído com sucesso!");
                                    button_consultar_Click(sender, e); // Atualiza a lista após exclusão
                                }
                                else
                                {
                                    MessageBox.Show("Erro ao excluir o cliente.");
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao excluir cliente: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione um cliente para excluir.");
            }
        }

        private void button_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
