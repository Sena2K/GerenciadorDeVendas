using GerenciadorDeVendas.Apresentacao;
using GerenciamentoDeVendas.DAO;
using ProjetoLogin.Modelo;

namespace GerenciadorDeVendas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            controle.acessar(txtEmail.Text, txtSenha.Text);

            if (controle.mensagem.Equals(""))
            {
                if (controle.tem)
                {
                    MessageBox.Show("Logado com sucesso", "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BemVindo bv = new BemVindo(z);
                    bv.Show();
                }
                else
                {
                    MessageBox.Show("Login não encontrado, verifique login e senha", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(controle.mensagem);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void btnCadastreSe_Click(object sender, EventArgs e)
        {
            CadastreSe cad = new CadastreSe();
            cad.Show();
        }
    }

}