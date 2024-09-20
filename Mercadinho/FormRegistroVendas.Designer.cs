namespace Mercadinho
{
    partial class frmRegistroVendas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistroVendas));
            label1 = new Label();
            txtCodigoProduto = new TextBox();
            label2 = new Label();
            txtQuantidade = new TextBox();
            grpMetodoPagamento = new GroupBox();
            rdbCartao = new RadioButton();
            rdbPix = new RadioButton();
            rdbDinheiro = new RadioButton();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            label3 = new Label();
            txtNomeProduto = new TextBox();
            grpMetodoPagamento.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(195, 91);
            label1.Name = "label1";
            label1.Size = new Size(165, 19);
            label1.TabIndex = 0;
            label1.Text = "Código do Produto:";
            // 
            // txtCodigoProduto
            // 
            txtCodigoProduto.Location = new Point(366, 91);
            txtCodigoProduto.Name = "txtCodigoProduto";
            txtCodigoProduto.Size = new Size(107, 23);
            txtCodigoProduto.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(195, 130);
            label2.Name = "label2";
            label2.Size = new Size(172, 19);
            label2.TabIndex = 2;
            label2.Text = "Quantidade Vendida:";
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(373, 130);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(100, 23);
            txtQuantidade.TabIndex = 3;
            // 
            // grpMetodoPagamento
            // 
            grpMetodoPagamento.Controls.Add(rdbCartao);
            grpMetodoPagamento.Controls.Add(rdbPix);
            grpMetodoPagamento.Controls.Add(rdbDinheiro);
            grpMetodoPagamento.Font = new Font("Arial", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpMetodoPagamento.Location = new Point(239, 174);
            grpMetodoPagamento.Name = "grpMetodoPagamento";
            grpMetodoPagamento.Size = new Size(200, 115);
            grpMetodoPagamento.TabIndex = 5;
            grpMetodoPagamento.TabStop = false;
            grpMetodoPagamento.Text = "Método de Pagamento";
            // 
            // rdbCartao
            // 
            rdbCartao.AutoSize = true;
            rdbCartao.Location = new Point(16, 84);
            rdbCartao.Name = "rdbCartao";
            rdbCartao.Size = new Size(151, 23);
            rdbCartao.TabIndex = 8;
            rdbCartao.TabStop = true;
            rdbCartao.Text = "Cartão de Débito";
            rdbCartao.UseVisualStyleBackColor = true;
            // 
            // rdbPix
            // 
            rdbPix.AutoSize = true;
            rdbPix.Location = new Point(16, 26);
            rdbPix.Name = "rdbPix";
            rdbPix.Size = new Size(49, 23);
            rdbPix.TabIndex = 6;
            rdbPix.TabStop = true;
            rdbPix.Text = "Pix";
            rdbPix.UseVisualStyleBackColor = true;
            // 
            // rdbDinheiro
            // 
            rdbDinheiro.AutoSize = true;
            rdbDinheiro.Location = new Point(16, 55);
            rdbDinheiro.Name = "rdbDinheiro";
            rdbDinheiro.Size = new Size(89, 23);
            rdbDinheiro.TabIndex = 7;
            rdbDinheiro.TabStop = true;
            rdbDinheiro.Text = "Dinheiro";
            rdbDinheiro.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(749, 55);
            toolStrip1.TabIndex = 6;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageScaling = ToolStripItemImageScaling.None;
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(52, 52);
            toolStripButton1.Text = "toolStripButton1";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(195, 55);
            label3.Name = "label3";
            label3.Size = new Size(154, 19);
            label3.TabIndex = 7;
            label3.Text = "Nome do Produto:";
            label3.Click += label3_Click;
            // 
            // txtNomeProduto
            // 
            txtNomeProduto.Location = new Point(373, 55);
            txtNomeProduto.Name = "txtNomeProduto";
            txtNomeProduto.Size = new Size(100, 23);
            txtNomeProduto.TabIndex = 8;
            // 
            // frmRegistroVendas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(749, 519);
            Controls.Add(txtNomeProduto);
            Controls.Add(label3);
            Controls.Add(toolStrip1);
            Controls.Add(grpMetodoPagamento);
            Controls.Add(txtQuantidade);
            Controls.Add(label2);
            Controls.Add(txtCodigoProduto);
            Controls.Add(label1);
            Name = "frmRegistroVendas";
            Text = "Registro de Vendas";
            grpMetodoPagamento.ResumeLayout(false);
            grpMetodoPagamento.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCodigoProduto;
        private Label label2;
        private TextBox txtQuantidade;
        private GroupBox grpMetodoPagamento;
        private RadioButton rdbCartao;
        private RadioButton rdbPix;
        private RadioButton rdbDinheiro;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private Label label3;
        private TextBox txtNomeProduto;
    }
}