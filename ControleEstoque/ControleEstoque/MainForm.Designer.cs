
namespace ControleEstoque
{
	partial class MainForm
	{

		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btnMenuCategorias;
		private System.Windows.Forms.Button btnMenuProdutos;
		private System.Windows.Forms.Button btnMenuMovimentacoes;
		private System.Windows.Forms.Label lblTotalProdutos;
		private System.Windows.Forms.Label lblTotalMovimentacoes;
		private System.Windows.Forms.DataGridView dgvAlertasEstoque;
		private System.Windows.Forms.Label label1;
		

		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		

		private void InitializeComponent()
		{
			this.btnMenuCategorias = new System.Windows.Forms.Button();
			this.btnMenuProdutos = new System.Windows.Forms.Button();
			this.btnMenuMovimentacoes = new System.Windows.Forms.Button();
			this.lblTotalProdutos = new System.Windows.Forms.Label();
			this.lblTotalMovimentacoes = new System.Windows.Forms.Label();
			this.dgvAlertasEstoque = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvAlertasEstoque)).BeginInit();
			this.SuspendLayout();
			// 
			// btnMenuCategorias
			// 
			this.btnMenuCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMenuCategorias.Location = new System.Drawing.Point(38, 130);
			this.btnMenuCategorias.Name = "btnMenuCategorias";
			this.btnMenuCategorias.Size = new System.Drawing.Size(109, 54);
			this.btnMenuCategorias.TabIndex = 8;
			this.btnMenuCategorias.Text = "Categorias";
			this.btnMenuCategorias.UseVisualStyleBackColor = true;
			this.btnMenuCategorias.Click += new System.EventHandler(this.BtnAbrirCategoriasClick);
			// 
			// btnMenuProdutos
			// 
			this.btnMenuProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMenuProdutos.Location = new System.Drawing.Point(195, 130);
			this.btnMenuProdutos.Name = "btnMenuProdutos";
			this.btnMenuProdutos.Size = new System.Drawing.Size(109, 54);
			this.btnMenuProdutos.TabIndex = 9;
			this.btnMenuProdutos.Text = "Produtos";
			this.btnMenuProdutos.UseVisualStyleBackColor = true;
			this.btnMenuProdutos.Click += new System.EventHandler(this.BtnMenuProdutosClick);
			// 
			// btnMenuMovimentacoes
			// 
			this.btnMenuMovimentacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMenuMovimentacoes.Location = new System.Drawing.Point(359, 130);
			this.btnMenuMovimentacoes.Name = "btnMenuMovimentacoes";
			this.btnMenuMovimentacoes.Size = new System.Drawing.Size(109, 54);
			this.btnMenuMovimentacoes.TabIndex = 10;
			this.btnMenuMovimentacoes.Text = "Movimentacoes";
			this.btnMenuMovimentacoes.UseVisualStyleBackColor = true;
			this.btnMenuMovimentacoes.Click += new System.EventHandler(this.BtnMenuMovimentacoesClick);
			// 
			// lblTotalProdutos
			// 
			this.lblTotalProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTotalProdutos.Location = new System.Drawing.Point(55, 257);
			this.lblTotalProdutos.Name = "lblTotalProdutos";
			this.lblTotalProdutos.Size = new System.Drawing.Size(260, 23);
			this.lblTotalProdutos.TabIndex = 11;
			this.lblTotalProdutos.Text = "Total Produtos";
			// 
			// lblTotalMovimentacoes
			// 
			this.lblTotalMovimentacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTotalMovimentacoes.Location = new System.Drawing.Point(55, 318);
			this.lblTotalMovimentacoes.Name = "lblTotalMovimentacoes";
			this.lblTotalMovimentacoes.Size = new System.Drawing.Size(249, 23);
			this.lblTotalMovimentacoes.TabIndex = 12;
			this.lblTotalMovimentacoes.Text = "Total Movimentacoes";
			// 
			// dgvAlertasEstoque
			// 
			this.dgvAlertasEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvAlertasEstoque.Location = new System.Drawing.Point(12, 407);
			this.dgvAlertasEstoque.Name = "dgvAlertasEstoque";
			this.dgvAlertasEstoque.Size = new System.Drawing.Size(650, 150);
			this.dgvAlertasEstoque.TabIndex = 13;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(204, 73);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 14;
			this.label1.Text = "MENUS";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.ClientSize = new System.Drawing.Size(674, 576);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dgvAlertasEstoque);
			this.Controls.Add(this.lblTotalMovimentacoes);
			this.Controls.Add(this.lblTotalProdutos);
			this.Controls.Add(this.btnMenuMovimentacoes);
			this.Controls.Add(this.btnMenuProdutos);
			this.Controls.Add(this.btnMenuCategorias);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ControleEstoque";
			((System.ComponentModel.ISupportInitialize)(this.dgvAlertasEstoque)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
