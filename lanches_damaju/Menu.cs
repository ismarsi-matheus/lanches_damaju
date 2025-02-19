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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void cad_pro_Click(object sender, EventArgs e)
        {
            produtos formCadastroProdutos = new produtos();
            formCadastroProdutos.Show();
        }

        private void cad_clientes_Click(object sender, EventArgs e)
        {
            Cadastro_de_clientes formCadastroClientes = new Cadastro_de_clientes();
            formCadastroClientes.Show();
        }

        private void consultar_prod_Click(object sender, EventArgs e)
        {
            consulta_prod formConsultaProdutos = new consulta_prod();
            formConsultaProdutos.Show();
        }

        private void consultar_clientes_Click(object sender, EventArgs e)
        {
            Gerenciamento_Clientes formGerenciamentoClientes = new Gerenciamento_Clientes();
            formGerenciamentoClientes.Show();
        }

        private void button_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

