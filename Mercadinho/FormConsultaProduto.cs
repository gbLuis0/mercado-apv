using Mercadinho.Controller;
using Mercadinho.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mercadinho
{
    public partial class frmConsultaProduto : Form
    {
        public frmConsultaProduto()
        {
            InitializeComponent();
        }

        private void btnBuscarProduto_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            string nomeProduto = txtNomeProduto.Text;
            bool promocao = chkPromocao.Checked;
            string categoria = cmbCategoriaProduto.Text;

			ProdutoController produtoController = new ProdutoController();
            List<ProdutoDTO> listaProdutos = produtoController.BuscarProdutos(nomeProduto, categoria, promocao);

            if (listaProdutos.Count > 0)
            {
                dataGridProdutos.DataSource = listaProdutos;
            }
            else
            {
                MessageBox.Show("Nenhum produto encontrado!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridProdutos.DataSource = null;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

