/*
 * Created by SharpDevelop.
 * User: Flavio
 * Date: 26/07/2026
 * Time: 21:49
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ControleEstoque.Forms
{
	partial class FrmProdutos
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox txtId;
		private System.Windows.Forms.TextBox txtNome;
		private System.Windows.Forms.ComboBox cboCategoria;
		private System.Windows.Forms.TextBox txtEstoqueMinimo;
		private System.Windows.Forms.TextBox txtSaldo;
		private System.Windows.Forms.CheckBox chkAtivo;
		private System.Windows.Forms.DataGridView dgvProdutos;
		private System.Windows.Forms.Button btnNovo;
		private System.Windows.Forms.Button btnSalvar;
		private System.Windows.Forms.Button btnEditar;
		private System.Windows.Forms.Button btnExcluir;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		
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
			this.txtId = new System.Windows.Forms.TextBox();
			this.txtNome = new System.Windows.Forms.TextBox();
			this.cboCategoria = new System.Windows.Forms.ComboBox();
			this.txtEstoqueMinimo = new System.Windows.Forms.TextBox();
			this.txtSaldo = new System.Windows.Forms.TextBox();
			this.chkAtivo = new System.Windows.Forms.CheckBox();
			this.dgvProdutos = new System.Windows.Forms.DataGridView();
			this.btnNovo = new System.Windows.Forms.Button();
			this.btnSalvar = new System.Windows.Forms.Button();
			this.btnEditar = new System.Windows.Forms.Button();
			this.btnExcluir = new System.Windows.Forms.Button();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
			this.SuspendLayout();
			// 
			// txtId
			// 
			this.txtId.Location = new System.Drawing.Point(59, 48);
			this.txtId.Name = "txtId";
			this.txtId.ReadOnly = true;
			this.txtId.Size = new System.Drawing.Size(100, 20);
			this.txtId.TabIndex = 0;
			// 
			// txtNome
			// 
			this.txtNome.Location = new System.Drawing.Point(59, 98);
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(100, 20);
			this.txtNome.TabIndex = 1;
			// 
			// cboCategoria
			// 
			this.cboCategoria.FormattingEnabled = true;
			this.cboCategoria.Location = new System.Drawing.Point(59, 149);
			this.cboCategoria.Name = "cboCategoria";
			this.cboCategoria.Size = new System.Drawing.Size(121, 21);
			this.cboCategoria.TabIndex = 2;
			// 
			// txtEstoqueMinimo
			// 
			this.txtEstoqueMinimo.Location = new System.Drawing.Point(257, 47);
			this.txtEstoqueMinimo.Name = "txtEstoqueMinimo";
			this.txtEstoqueMinimo.Size = new System.Drawing.Size(100, 20);
			this.txtEstoqueMinimo.TabIndex = 3;
			// 
			// txtSaldo
			// 
			this.txtSaldo.Location = new System.Drawing.Point(257, 98);
			this.txtSaldo.Name = "txtSaldo";
			this.txtSaldo.Size = new System.Drawing.Size(100, 20);
			this.txtSaldo.TabIndex = 4;
			// 
			// chkAtivo
			// 
			this.chkAtivo.Location = new System.Drawing.Point(257, 137);
			this.chkAtivo.Name = "chkAtivo";
			this.chkAtivo.Size = new System.Drawing.Size(104, 24);
			this.chkAtivo.TabIndex = 5;
			this.chkAtivo.Text = "Ativo";
			this.chkAtivo.UseVisualStyleBackColor = true;
			// 
			// dgvProdutos
			// 
			this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvProdutos.Location = new System.Drawing.Point(12, 235);
			this.dgvProdutos.Name = "dgvProdutos";
			this.dgvProdutos.Size = new System.Drawing.Size(537, 150);
			this.dgvProdutos.TabIndex = 6;
			// 
			// btnNovo
			// 
			this.btnNovo.Location = new System.Drawing.Point(31, 391);
			this.btnNovo.Name = "btnNovo";
			this.btnNovo.Size = new System.Drawing.Size(75, 23);
			this.btnNovo.TabIndex = 7;
			this.btnNovo.Text = "Novo";
			this.btnNovo.UseVisualStyleBackColor = true;
			this.btnNovo.Click += new System.EventHandler(this.BtnNovoClick);
			// 
			// btnSalvar
			// 
			this.btnSalvar.Location = new System.Drawing.Point(112, 391);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.Size = new System.Drawing.Size(75, 23);
			this.btnSalvar.TabIndex = 8;
			this.btnSalvar.Text = "Salvar";
			this.btnSalvar.UseVisualStyleBackColor = true;
			this.btnSalvar.Click += new System.EventHandler(this.BtnSalvarClick);
			// 
			// btnEditar
			// 
			this.btnEditar.Location = new System.Drawing.Point(211, 391);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Size = new System.Drawing.Size(75, 23);
			this.btnEditar.TabIndex = 9;
			this.btnEditar.Text = "Editar";
			this.btnEditar.UseVisualStyleBackColor = true;
			this.btnEditar.Click += new System.EventHandler(this.BtnEditarClick);
			// 
			// btnExcluir
			// 
			this.btnExcluir.Location = new System.Drawing.Point(292, 391);
			this.btnExcluir.Name = "btnExcluir";
			this.btnExcluir.Size = new System.Drawing.Size(75, 23);
			this.btnExcluir.TabIndex = 10;
			this.btnExcluir.Text = "Excluir";
			this.btnExcluir.UseVisualStyleBackColor = true;
			this.btnExcluir.Click += new System.EventHandler(this.BtnExcluirClick);
			// 
			// btnCancelar
			// 
			this.btnCancelar.Location = new System.Drawing.Point(421, 391);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(75, 23);
			this.btnCancelar.TabIndex = 11;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.BtnCancelarClick);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(59, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 12;
			this.label1.Text = "ID";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(59, 72);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 13;
			this.label2.Text = "Nome";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(59, 123);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 14;
			this.label3.Text = "Categorias";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(257, 72);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 15;
			this.label4.Text = "Saldo";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(257, 21);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(130, 23);
			this.label5.TabIndex = 16;
			this.label5.Text = "Estoque minimo";
			// 
			// FrmProdutos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(561, 426);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnExcluir);
			this.Controls.Add(this.btnEditar);
			this.Controls.Add(this.btnSalvar);
			this.Controls.Add(this.btnNovo);
			this.Controls.Add(this.dgvProdutos);
			this.Controls.Add(this.chkAtivo);
			this.Controls.Add(this.txtSaldo);
			this.Controls.Add(this.txtEstoqueMinimo);
			this.Controls.Add(this.cboCategoria);
			this.Controls.Add(this.txtNome);
			this.Controls.Add(this.txtId);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "FrmProdutos";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmProdutos";
			((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
