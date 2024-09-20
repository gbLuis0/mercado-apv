namespace Mercadinho
{
    partial class frmConsultaProduto
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaProduto));
			label1 = new Label();
			label2 = new Label();
			txtNomeProduto = new TextBox();
			cmbCategoriaProduto = new ComboBox();
			chkPromocao = new CheckBox();
			dataGridProdutos = new DataGridView();
			label3 = new Label();
			toolStrip1 = new ToolStrip();
			toolStripButton1 = new ToolStripButton();
			((System.ComponentModel.ISupportInitialize)dataGridProdutos).BeginInit();
			toolStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// label1
			// 
			label1.Anchor = AnchorStyles.None;
			label1.AutoSize = true;
			label1.Font = new Font("Arial", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.Location = new Point(147, 69);
			label1.Name = "label1";
			label1.Size = new Size(154, 19);
			label1.TabIndex = 0;
			label1.Text = "Nome do Produto:";
			// 
			// label2
			// 
			label2.Anchor = AnchorStyles.None;
			label2.AutoSize = true;
			label2.Location = new Point(195, 73);
			label2.Name = "label2";
			label2.Size = new Size(0, 15);
			label2.TabIndex = 1;
			// 
			// txtNomeProduto
			// 
			txtNomeProduto.Anchor = AnchorStyles.None;
			txtNomeProduto.Location = new Point(357, 65);
			txtNomeProduto.Name = "txtNomeProduto";
			txtNomeProduto.Size = new Size(142, 23);
			txtNomeProduto.TabIndex = 2;
			// 
			// cmbCategoriaProduto
			// 
			cmbCategoriaProduto.Anchor = AnchorStyles.None;
			cmbCategoriaProduto.FormattingEnabled = true;
			cmbCategoriaProduto.Location = new Point(357, 102);
			cmbCategoriaProduto.Name = "cmbCategoriaProduto";
			cmbCategoriaProduto.Size = new Size(142, 23);
			cmbCategoriaProduto.TabIndex = 3;
			// 
			// chkPromocao
			// 
			chkPromocao.Anchor = AnchorStyles.None;
			chkPromocao.AutoSize = true;
			chkPromocao.Font = new Font("Arial", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			chkPromocao.Location = new Point(147, 150);
			chkPromocao.Name = "chkPromocao";
			chkPromocao.Size = new Size(300, 23);
			chkPromocao.TabIndex = 4;
			chkPromocao.Text = "Exibir apenas produtos em promoção";
			chkPromocao.UseVisualStyleBackColor = true;
			// 
			// dataGridProdutos
			// 
			dataGridProdutos.Anchor = AnchorStyles.None;
			dataGridProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridProdutos.Location = new Point(77, 208);
			dataGridProdutos.Name = "dataGridProdutos";
			dataGridProdutos.ReadOnly = true;
			dataGridProdutos.Size = new Size(509, 265);
			dataGridProdutos.TabIndex = 6;
			// 
			// label3
			// 
			label3.Anchor = AnchorStyles.None;
			label3.AutoSize = true;
			label3.Font = new Font("Arial", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label3.Location = new Point(147, 106);
			label3.Name = "label3";
			label3.Size = new Size(185, 19);
			label3.TabIndex = 7;
			label3.Text = "Categoria do Produto:";
			label3.Click += label3_Click;
			// 
			// toolStrip1
			// 
			toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1 });
			toolStrip1.Location = new Point(0, 0);
			toolStrip1.Name = "toolStrip1";
			toolStrip1.Size = new Size(657, 55);
			toolStrip1.TabIndex = 8;
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
			toolStripButton1.Click += toolStripButton1_Click_1;
			// 
			// frmConsultaProduto
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(657, 509);
			Controls.Add(toolStrip1);
			Controls.Add(label3);
			Controls.Add(dataGridProdutos);
			Controls.Add(chkPromocao);
			Controls.Add(cmbCategoriaProduto);
			Controls.Add(txtNomeProduto);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "frmConsultaProduto";
			Text = "Consulta de Produto";
			((System.ComponentModel.ISupportInitialize)dataGridProdutos).EndInit();
			toolStrip1.ResumeLayout(false);
			toolStrip1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
        private Label label2;
        private TextBox txtNomeProduto;
        private ComboBox cmbCategoriaProduto;
        private CheckBox chkPromocao;
        private DataGridView dataGridProdutos;
        private Label label3;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
    }
}