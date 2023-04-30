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
        public BemVindo(int idUsuario)
        {
            InitializeComponent();
            lblBemVindo.Text = "Bem-vindo, ID " + idUsuario.ToString();

        }

        private void lblBemVindo_Click(object sender, EventArgs e)
        {

        }

        private void BemVindo_Load(object sender, EventArgs e)
        {

        }
    }
}
