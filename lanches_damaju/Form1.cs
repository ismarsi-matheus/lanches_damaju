using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

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
            //Define sua string de conexão com o banco
            string conexaoString = "Server=localhost; Port=3306; Database=db_lanches_damaju; Uid=root; Pwd=;";

            //Defina a inserção de registro no BD

            string query = "INSERT INTO tb_produto (nome,valor,descricao,imagem,categoria) VALUES (@nome, @valor, @descricao, @imagem, @categoria)";

            //Crie uma conexão com o BD

            using (MySqlConnection conexao = new MySqlConnection(conexaoString))
            {

                try
                {

                    //Abre a conexao
                    conexao.Open();


                    //Crie o comenado SQL
                    using (MySqlCommand comando = new MySqlCommand(query, conexao))
                    {
                        //Adicionar os parâmetros com os valores dos TexBox
                        comando.Parameters.AddWithValue("(@nome", textBox_nome.Text);
                        comando.Parameters.AddWithValue("@valor", maskedTextBox_valor.Text);
                        comando.Parameters.AddWithValue("@descricao", richTextBox_descricao.Text);
                        comando.Parameters.AddWithValue("@categoria", textBox_cat.Text);

                        //Executa o comando de inserção

                        comando.ExecuteNonQuery();

                        MessageBox.Show("Dados inseridos com sucesso!");
                    }

                }



                catch (Exception ex)
                {
                    //em caso de erro, exiba mensagem de erro
                    MessageBox.Show("Erro: " + ex.Message);
                }









            }
        }
    }
    }
