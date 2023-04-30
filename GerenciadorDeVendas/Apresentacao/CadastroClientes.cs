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

        public bool ValidarCPF(string cpf)
        {
            cpf = cpf.Replace(".", "").Replace("-", "");
            if (cpf.Length != 11 || cpf.All(c => c == cpf[0]))
            {
                return false;
            }

            int[] multiplicadores = new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma = 0;
            for (int i = 0; i < 9; i++)
            {
                soma += int.Parse(cpf[i].ToString()) * multiplicadores[i];
            }

            int resto = soma % 11;
            int digitoVerificador1 = resto < 2 ? 0 : 11 - resto;

            soma = 0;
            multiplicadores = new int[] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            for (int i = 0; i < 10; i++)
            {
                soma += int.Parse(cpf[i].ToString()) * multiplicadores[i];
            }

            resto = soma % 11;
            int digitoVerificador2 = resto < 2 ? 0 : 11 - resto;

            return cpf.EndsWith(digitoVerificador1.ToString() + digitoVerificador2.ToString());
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

            if (!ValidarCPF(cpf))
            {
                MessageBox.Show("CPF inválido.", "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

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
