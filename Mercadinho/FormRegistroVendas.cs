using Mercadinho.Controller;
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
    public partial class frmRegistroVendas : Form
    {
        public frmRegistroVendas()
        {

            InitializeComponent();
        }

        private void btnRegistrarVenda_Click(object sender, EventArgs e)
        {

        }

       

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            // Validação dos campos
            if (string.IsNullOrEmpty(txtCodigoProduto.Text) || string.IsNullOrEmpty(txtQuantidade.Text))
            {
                MessageBox.Show("Preencha todos os campos obrigatórios!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Recupera dados do formulário
            string nomeProduto = txtNomeProduto.Text;
            string codigoProduto = txtCodigoProduto.Text;
            int quantidade = Convert.ToInt32(txtQuantidade.Text);
            string metodoPagamento = "";

            if (rdbPix.Checked)
                metodoPagamento = "Pix";
            else if (rdbDinheiro.Checked)
                metodoPagamento = "Dinheiro";
            else if (rdbCartao.Checked)
                metodoPagamento = "Cartão";

            // Chama o Controller para registrar a venda
            VendaController vendaController = new VendaController();
            bool sucesso = vendaController.RegistrarVenda(nomeProduto, codigoProduto, quantidade, metodoPagamento);

            // Exibe mensagem de sucesso ou erro
            if (sucesso)
            {
                MessageBox.Show("Venda registrada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
            }
            else
            {
                MessageBox.Show("Erro ao registrar a venda!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Função para limpar os campos do formulário após o registro da venda
            
        }
        private void LimparCampos()
        {
            txtCodigoProduto.Clear();
            txtCodigoProduto.Clear();
            txtQuantidade.Clear();
            rdbPix.Checked = false;
            rdbDinheiro.Checked = false;
            rdbCartao.Checked = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

