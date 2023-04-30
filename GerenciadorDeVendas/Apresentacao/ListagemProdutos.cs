using GerenciamentoDeVendas.DAO;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GerenciadorDeVendas.Apresentacao
{
    public partial class ListagemProdutos : Form
    {
        public ListagemProdutos()
        {
            InitializeComponent();
        }

        private void ListagemProdutos_Load(object sender, EventArgs e)
        {
     
            Conexao conexao = new Conexao();
            {
                try
                {
                   
                    string query = "SELECT * FROM Produtos";

                  
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexao.conectar());
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                   
                    dgvProdutos.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao buscar os produtos no banco de dados: " + ex.Message, "Erro");
                }
            }
        }

        private void dgvProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
           
            if (dgvProdutos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um produto para editar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            int idProduto = Convert.ToInt32(dgvProdutos.SelectedRows[0].Cells["IdProduto"].Value);

            
            EditarProduto formEditarProduto = new EditarProduto(idProduto);
            formEditarProduto.ShowDialog();
        }
    }
}
