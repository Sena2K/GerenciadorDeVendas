using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorDeVendas.Apresentacao
{
    public partial class BemVindo : Form
    {
        private int idUsuario;

        public BemVindo(int idUsuario)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
            lblBemVindo.Text = "Bem-vindo, ID " + idUsuario.ToString();

        }

        private void lblBemVindo_Click(object sender, EventArgs e)
        {

        }

        private void BemVindo_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastroProdutos_Click(object sender, EventArgs e)
        {
            CadastroProdutos cp = new CadastroProdutos();
            cp.Show();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            ListagemProdutos lp = new ListagemProdutos();
            lp.Show();
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            relatorioDeVendas relatorio = new relatorioDeVendas();
            relatorio.Show();
        }

        private void btnCadastroCliente_Click(object sender, EventArgs e)
        {
            CadastroClientes cp = new CadastroClientes();
            cp.Show();
        }
    }
}
