/*
 * Created by SharpDevelop.
 * User: Flavio
 * Date: 26/07/2026
 * Time: 22:00
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ControleEstoque.Forms
{
	partial class FrmMovimentacoes
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.ComboBox cboProduto;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cboTipo;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtQuantidade;
		private System.Windows.Forms.TextBox txtDescricao;
		private System.Windows.Forms.DataGridView dgvHistorico;
		private System.Windows.Forms.Button btnRegistrar;
		private System.Windows.Forms.Button btnLimpar;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.cboProduto = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.cboTipo = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtQuantidade = new System.Windows.Forms.TextBox();
			this.txtDescricao = new System.Windows.Forms.TextBox();
			this.dgvHistorico = new System.Windows.Forms.DataGridView();
			this.btnRegistrar = new System.Windows.Forms.Button();
			this.btnLimpar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvHistorico)).BeginInit();
			this.SuspendLayout();
			// 
			// cboProduto
			// 
			this.cboProduto.FormattingEnabled = true;
			this.cboProduto.Location = new System.Drawing.Point(52, 35);
			this.cboProduto.Name = "cboProduto";
			this.cboProduto.Size = new System.Drawing.Size(121, 21);
			this.cboProduto.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(52, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Produto";
			// 
			// cboTipo
			// 
			this.cboTipo.FormattingEnabled = true;
			this.cboTipo.Location = new System.Drawing.Point(52, 107);
			this.cboTipo.Name = "cboTipo";
			this.cboTipo.Size = new System.Drawing.Size(121, 21);
			this.cboTipo.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(52, 81);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 3;
			this.label2.Text = "Tipo";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(234, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "Quantidade";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(234, 81);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 5;
			this.label4.Text = "Descricao";
			// 
			// txtQuantidade
			// 
			this.txtQuantidade.Location = new System.Drawing.Point(234, 35);
			this.txtQuantidade.Name = "txtQuantidade";
			this.txtQuantidade.Size = new System.Drawing.Size(100, 20);
			this.txtQuantidade.TabIndex = 6;
			// 
			// txtDescricao
			// 
			this.txtDescricao.Location = new System.Drawing.Point(234, 107);
			this.txtDescricao.Name = "txtDescricao";
			this.txtDescricao.Size = new System.Drawing.Size(100, 20);
			this.txtDescricao.TabIndex = 7;
			// 
			// dgvHistorico
			// 
			this.dgvHistorico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvHistorico.Location = new System.Drawing.Point(12, 185);
			this.dgvHistorico.Name = "dgvHistorico";
			this.dgvHistorico.Size = new System.Drawing.Size(485, 199);
			this.dgvHistorico.TabIndex = 8;
			// 
			// btnRegistrar
			// 
			this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRegistrar.Location = new System.Drawing.Point(29, 401);
			this.btnRegistrar.Name = "btnRegistrar";
			this.btnRegistrar.Size = new System.Drawing.Size(104, 38);
			this.btnRegistrar.TabIndex = 9;
			this.btnRegistrar.Text = "Registrar";
			this.btnRegistrar.UseVisualStyleBackColor = true;
			// 
			// btnLimpar
			// 
			this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLimpar.Location = new System.Drawing.Point(303, 406);
			this.btnLimpar.Name = "btnLimpar";
			this.btnLimpar.Size = new System.Drawing.Size(104, 38);
			this.btnLimpar.TabIndex = 10;
			this.btnLimpar.Text = "Limpar";
			this.btnLimpar.UseVisualStyleBackColor = true;
			// 
			// FrmMovimentacoes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(509, 456);
			this.Controls.Add(this.btnLimpar);
			this.Controls.Add(this.btnRegistrar);
			this.Controls.Add(this.dgvHistorico);
			this.Controls.Add(this.txtDescricao);
			this.Controls.Add(this.txtQuantidade);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.cboTipo);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cboProduto);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "FrmMovimentacoes";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmMovimentacoes";
			((System.ComponentModel.ISupportInitialize)(this.dgvHistorico)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
