using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace lanches_damaju
{
    public partial class Cadastro_de_clientes : Form
    {
        public Cadastro_de_clientes()
        {
            InitializeComponent();
            textBox_senha.UseSystemPasswordChar = true; // Sempre inicia oculto
        }

        private void button_cadastrar_Click(object sender, EventArgs e)
        {
            string cpf = maskedTextBox_CPF.Text;

            if (ValidarCpf(cpf))
            {
                labelAlert.Text = "CPF Válido";
                labelAlert.ForeColor = Color.Green;
            }
            else
            {
                labelAlert.Text = "CPF INVÁLIDO";
                labelAlert.ForeColor = Color.Red;
                maskedTextBox_CPF.Text = "";
                maskedTextBox_CPF.Focus();
                return;
            }

            string conexaoString = "Server=localhost; Port=3306; Database=db_lanches_damaju; Uid=root; Pwd=;";

            string query = "INSERT INTO tb_cliente (Nome, senha, email, CEP, CPF,numero, telefone, imagem)"+
                           "VALUES (@Nome, @senha, @email, @CEP, @CPF, @numero,@telefone, @imagem)";

            using (MySqlConnection conexao = new MySqlConnection(conexaoString))
            {
                try
                {
                    conexao.Open();

                    using (MySqlCommand comando = new MySqlCommand(query, conexao))
                    {
                        comando.Parameters.AddWithValue("@nome", textBox_nome.Text);
                        comando.Parameters.AddWithValue("@senha", textBox_senha.Text);
                        comando.Parameters.AddWithValue("@email", textBox_email.Text);
                        comando.Parameters.AddWithValue("@CEP", maskedTextBox_cep.Text);
                        comando.Parameters.AddWithValue("@CPF", maskedTextBox_CPF.Text);
                        comando.Parameters.AddWithValue("@numero", textBox_numero.Text);
                        comando.Parameters.AddWithValue("@telefone", maskedTextBox_telefone.Text);

                        // Converter imagem para byte[] antes de salvar no banco
                        if (pictureBox_imagem.Image != null)
                        {
                            using (MemoryStream ms = new MemoryStream())
                            {
                                pictureBox_imagem.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                                byte[] imagemBytes = ms.ToArray();
                                comando.Parameters.AddWithValue("@imagem", imagemBytes);
                            }
                        }
                        else
                        {
                            comando.Parameters.AddWithValue("@imagem", DBNull.Value); // Caso o usuário não selecione uma imagem
                        }

                        comando.ExecuteNonQuery();
                        MessageBox.Show("Dados inseridos com sucesso!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }
        }

        private void button_limpar_campos_Click(object sender, EventArgs e)
        {
            // Limpa os campos do formulário
            textBox_nome.Clear();
            textBox_senha.Clear();
            textBox_email.Clear();
            maskedTextBox_cep.Clear();
            maskedTextBox_CPF.Clear();
            maskedTextBox_telefone.Clear();
            pictureBox_imagem.Image = null;
            labelAlert.Text = "";
        }

        private void button_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_carregar_imagem_Click(object sender, EventArgs e)
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

        private bool ValidarCpf(string cpf)
        {
            cpf = Regex.Replace(cpf, @"[^\d]", "");
            if (cpf.Length != 11 || new string(cpf[0], 11) == cpf) return false;

            int soma = 0, peso = 10;
            for (int i = 0; i < 9; i++) soma += int.Parse(cpf[i].ToString()) * peso--;

            int resto = soma % 11, digito1 = resto < 2 ? 0 : 11 - resto;
            if (digito1 != int.Parse(cpf[9].ToString())) return false;

            soma = 0; peso = 11;
            for (int i = 0; i < 10; i++) soma += int.Parse(cpf[i].ToString()) * peso--;

            resto = soma % 11;
            int digito2 = resto < 2 ? 0 : 11 - resto;
            return digito2 == int.Parse(cpf[10].ToString());
        }

        private void button_mostrar_senha_Click(object sender, EventArgs e)
        {
            // Alterna entre mostrar e ocultar a senha
            if (textBox_senha.UseSystemPasswordChar)
            {
                textBox_senha.UseSystemPasswordChar = false;
                button_mostrar_senha.Text = "Ocultar";
            }
            else
            {
                textBox_senha.UseSystemPasswordChar = true;
                button_mostrar_senha.Text = "Mostrar";
            }
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
                try
                {
                    // Verifica se o arquivo é uma imagem válida
                    using (Image img = Image.FromFile(openFileDialog.FileName))
                    {
                        pictureBox_imagem.Image = (Image)img.Clone(); // Clona a imagem para evitar bloqueio do arquivo
                        labelImagem.Text = "Imagem carregada: " + Path.GetFileName(openFileDialog.FileName); // Mostra o nome do arquivo
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar a imagem: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
