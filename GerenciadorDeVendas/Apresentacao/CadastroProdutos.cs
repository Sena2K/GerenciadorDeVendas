using GerenciamentoDeVendas.DAO;
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

namespace GerenciadorDeVendas.Apresentacao
{
    public partial class CadastroProdutos : Form
    {
        public CadastroProdutos()
        {
            InitializeComponent();
        }

        private void CadastroProdutos_Load(object sender, EventArgs e)
        {

        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            string nome = txbNome.Text;
            string descricao = txbDesc.Text;
            decimal preco = numPreco.Value;
            int estoque = (int)numQtd.Value;

            // Validar as informações do produto
            if (nome == "")
            {
                MessageBox.Show("O nome do produto não pode estar em branco.", "Erro de validação");
                return;
            }

            // Inserir o novo produto no banco de dados
            Conexao conexao = new Conexao();
            {
                string query = "INSERT INTO Produtos (NomeProduto, PrecoUnitario, DescricaoProduto, Estoque) VALUES (@Nome, @Preco, @Descricao, @Estoque)";
                SqlCommand cmd = new SqlCommand(query, conexao.conectar());
                cmd.Parameters.AddWithValue("@Nome", nome);
                cmd.Parameters.AddWithValue("@Preco", preco);
                cmd.Parameters.AddWithValue("@Descricao", descricao);
                cmd.Parameters.AddWithValue("@Estoque", estoque);

                cmd.ExecuteNonQuery();
            }

            // Limpar os controles do formulário
            txbNome.Text = "";
            txbDesc.Text = "";
            numPreco.Value = 0;
            numQtd.Value = 0;

            MessageBox.Show("O produto foi cadastrado com sucesso!", "Cadastro de Produto");
        }

        private void txtCpf_TextChanged(object sender, EventArgs e)
        {
            if (rbPessoaFisica.Checked)
            {
                rbPessoaFisica.Text = "CPF";
                rbPessoaJuridica.Visible = true;
                rbPessoaFisica.Visible = false;
            }
        }
    }
}


