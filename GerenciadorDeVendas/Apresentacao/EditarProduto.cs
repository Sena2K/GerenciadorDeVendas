using GerenciadorDeVendas.Modelo;
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
    public partial class EditarProduto : Form
    {
        public EditarProduto()
        {
            InitializeComponent();
        }

        private int idProduto;

        public EditarProduto(int id)
        {
            InitializeComponent();

            idProduto = id;

            // Carrega os dados do produto a partir do banco de dados
            CarregarProduto();
        }

        private void CarregarProduto()
        {
            // Query para buscar os dados do produto a partir do ID
            string query = "SELECT * FROM produtos WHERE idProduto = " + idProduto;

            // Cria o objeto de conexão e o adaptador de dados
            Conexao conexao = new Conexao();
            SqlDataAdapter adapter = new SqlDataAdapter(query, conexao.conectar());

            // Cria um objeto DataTable e preenche-o com os dados do produto
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            // Exibe os dados do produto nos controles de entrada de dados
            txbNome.Text = dataTable.Rows[0]["NomeProduto"].ToString();
            numPreco.Text = dataTable.Rows[0]["PrecoUnitario"].ToString();
            txbDesc.Text = dataTable.Rows[0]["DescricaoProduto"].ToString();
            numQtd.Text = dataTable.Rows[0]["estoque"].ToString();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string query = "UPDATE produtos SET NomeProduto = @nome, PrecoUnitario = @preco, DescricaoProduto = @descricao, estoque = @estoque WHERE idProduto = " + idProduto;

            Conexao conexao = new Conexao();
            SqlCommand command = new SqlCommand(query, conexao.conectar());
            command.Parameters.AddWithValue("@nome", txbNome.Text);
            command.Parameters.AddWithValue("@descricao", txbDesc.Text);
            command.Parameters.AddWithValue("@preco", numPreco.Text);
            command.Parameters.AddWithValue("@estoque", numQtd.Text);
            command.ExecuteNonQuery();

            // Fecha o formulário de edição
            this.Close();
        }
    }
}
