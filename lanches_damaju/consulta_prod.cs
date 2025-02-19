using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Drawing; // Adicione este namespace

namespace lanches_damaju
{
    public partial class consulta_prod : Form
    {
        private string connectionString = "Server=localhost; Port=3306; Database=db_lanches_damaju; Uid=root; Pwd=;";

        public consulta_prod()
        {
            InitializeComponent();
        }

        private void consulta_prod_Load(object sender, EventArgs e)
        {
            CarregarProdutos();
        }

        private void button_produto_Click(object sender, EventArgs e)
        {
            CarregarProdutos();
        }

        private void CarregarProdutos()
        {
            try
            {
                using (MySqlConnection conexao = new MySqlConnection(connectionString))
                {
                    conexao.Open();

                    string query = "SELECT id_produto, nome, valor, descricao,categoria FROM tb_produto";

                    using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                    {
                        MySqlDataReader reader = cmd.ExecuteReader();
                        DataTable dadoProd = new DataTable();
                        dadoProd.Load(reader);

                        // Exibir dados no DataGridView
                        dgv_prod.DataSource = dadoProd;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao consultar produto: " + ex.Message);
            }
        }

        private void button_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_excluir_Click(object sender, EventArgs e)
        {
            if (dgv_prod.SelectedRows.Count > 0)
            {
                // Verifique se a célula "id_produto" tem um valor válido
                var selectedCell = dgv_prod.SelectedRows[0].Cells["id_produto"].Value;
                if (selectedCell != DBNull.Value)
                {
                    int produtoID = Convert.ToInt32(selectedCell);

                    DialogResult result = MessageBox.Show("Tem certeza que deseja excluir este produto?", "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            using (MySqlConnection conexao = new MySqlConnection(connectionString))
                            {
                                conexao.Open();

                                string query = "DELETE FROM tb_produto WHERE id_produto = @id_produto";

                                using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                                {
                                    cmd.Parameters.AddWithValue("@id_produto", produtoID);

                                    int rowsAffected = cmd.ExecuteNonQuery();
                                    if (rowsAffected > 0)
                                    {
                                        MessageBox.Show("Produto excluído com sucesso!");
                                        // Atualiza a lista após exclusão
                                        CarregarProdutos(); // Recarga os produtos
                                    }
                                    else
                                    {
                                        MessageBox.Show("Erro ao excluir o produto.");
                                    }
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erro ao excluir produto: " + ex.Message);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Produto não selecionado corretamente.");
                }
            }
            else
            {
                MessageBox.Show("Selecione um produto para excluir.");
            }
        }
    }
}
