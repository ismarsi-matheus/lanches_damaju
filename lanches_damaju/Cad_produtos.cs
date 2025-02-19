using System;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Drawing;

namespace lanches_damaju
{
    public partial class produtos : Form
    {
        public produtos()
        {
            InitializeComponent();
        }

        private void button_cadastrar_Click(object sender, EventArgs e)
        {
            // Define sua string de conexão com o banco
            string conexaoString = "Server=localhost; Port=3306; Database=db_lanches_damaju; Uid=root; Pwd=;";

            // Defina a inserção de registro no BD
            string query = "INSERT INTO tb_produto (nome, valor, descricao, imagem, categoria) VALUES (@nome, @valor, @descricao, @imagem, @categoria)";

            // Criar a conexão com o banco de dados
            using (MySqlConnection conexao = new MySqlConnection(conexaoString))
            {
                try
                {
                    // Abrir a conexão
                    conexao.Open();

                    // Criar o comando SQL
                    using (MySqlCommand comando = new MySqlCommand(query, conexao))
                    {
                        // Adicionar os parâmetros com os valores dos TextBox
                        comando.Parameters.AddWithValue("@nome", textBox_nome.Text);
                        comando.Parameters.AddWithValue("@valor", maskedTextBox_valor.Text);
                        comando.Parameters.AddWithValue("@descricao", richTextBox_descricao.Text);
                        comando.Parameters.AddWithValue("@categoria", textBox_cat.Text);

                        // Converter a imagem para array de bytes
                        if (pictureBox_imagem.Image != null)
                        {
                            using (MemoryStream ms = new MemoryStream())
                            {
                                pictureBox_imagem.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                                comando.Parameters.AddWithValue("@imagem", ms.ToArray());
                            }
                        }
                        else
                        {
                            comando.Parameters.AddWithValue("@imagem", DBNull.Value);
                        }

                        // Executa o comando de inserção
                        comando.ExecuteNonQuery();

                        MessageBox.Show("Dados inseridos com sucesso!");
                    }
                }
                catch (Exception ex)
                {
                    // Em caso de erro, exibir mensagem
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }
        }

        private void button_limpar_Click(object sender, EventArgs e)
        {
            // Limpar os campos de entrada
            textBox_nome.Clear();
            maskedTextBox_valor.Clear();
            richTextBox_descricao.Clear();
            textBox_cat.Clear();
            pictureBox_imagem.Image = null;
        }

        private void button_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void produtos_Load(object sender, EventArgs e)
        {

        }

        private void button_escolher_imagem_Click(object sender, EventArgs e)
        {
            // Criando um OpenFileDialog para escolher a imagem
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Selecionar uma imagem",
                Filter = "Imagens (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox_imagem.Image = Image.FromFile(openFileDialog.FileName);
            }
        }
    }
}
