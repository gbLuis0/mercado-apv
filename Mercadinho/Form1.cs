namespace Mercadinho
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void registrarVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistroVendas frmRegistroVendas = new frmRegistroVendas();
            frmRegistroVendas.MdiParent = this;
            frmRegistroVendas.Show();
        }

        private void consultarProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaProduto frmConsultaProduto = new frmConsultaProduto();
            frmConsultaProduto.MdiParent = this;
            frmConsultaProduto.Show(); 
        }
    }
}
