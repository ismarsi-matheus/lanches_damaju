using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lanches_damaju
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button_entrar_Click(object sender, EventArgs e)
        {
            // Criar uma instância do formulário Menu
            Menu menuForm = new Menu();

            // Esconder a tela de login
            this.Hide();

            // Exibir o menu
            menuForm.ShowDialog();

            // Fechar o login após o menu ser fechado
            this.Close();
        }
    }
}

