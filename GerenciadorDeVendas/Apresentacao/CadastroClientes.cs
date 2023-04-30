using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GerenciadorDeVendas.Modelo;
using GerenciamentoDeVendas.DAO;

namespace GerenciadorDeVendas.Apresentacao
{
    public partial class CadastroClientes : Form
    {


        public CadastroClientes()
        {
            InitializeComponent();
        }

        private void dtpDataNascimento_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nome = txtNomeCliente.Text;
            string cidade = txtCidade.Text;
            string estado = cbcSiglasEstados.Text;
            string endereco = txtRua.Text;
            string cep = txtCep.Text;
            string telefone = txtTelefone.Text;
            string email = txtEmail.Text;
            string cpf = txbCPF.Text;
            string cnpj = txbCNPJ.Text;
            DateTime dataNascimento = dtpDataNascimento.Value;
            DateTime dataAtual = DateTime.Now;

            if (dataAtual.Year - dataNascimento.Year < 18)
            {
                MessageBox.Show("O cliente deve ser maior de 18 anos.", "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            LoginDaoComandos dao = new LoginDaoComandos();
            string mensagem = dao.cadastrarCliente(nome, endereco, cidade, estado, cep, telefone, email, dataNascimento, cpf, cnpj);
            MessageBox.Show(mensagem);

        }

     
        private void cbcSiglasEstados_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rbCPF_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCPF.Checked)
            {
                txbCPF.Visible = true;
                txbCNPJ.Visible = false;
            }
        }

        private void rbCNPJ_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCNPJ.Checked)
            {
                txbCNPJ.Visible = true;
                txbCPF.Visible = false;
            }
        }

        private void txbCNPJ_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbCPF_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
