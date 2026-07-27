/*
 * Created by SharpDevelop.
 * User: Flavio
 * Date: 26/07/2026
 * Time: 21:35
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ControleEstoque.Forms
{
	partial class FrmCategorias
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtId;
		private System.Windows.Forms.TextBox txtNome;
		private System.Windows.Forms.Button btnNovo;
		private System.Windows.Forms.Button btnSalvar;
		private System.Windows.Forms.Button btnExcluir;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.DataGridView dgvCategorias;
		
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
			this.label = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtId = new System.Windows.Forms.TextBox();
			this.txtNome = new System.Windows.Forms.TextBox();
			this.btnNovo = new System.Windows.Forms.Button();
			this.btnSalvar = new System.Windows.Forms.Button();
			this.btnExcluir = new System.Windows.Forms.Button();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.dgvCategorias = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).BeginInit();
			this.SuspendLayout();
			// 
			// label
			// 
			this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.label.Location = new System.Drawing.Point(84, 27);
			this.label.Name = "label";
			this.label.Size = new System.Drawing.Size(100, 23);
			this.label.TabIndex = 0;
			this.label.Text = "ID";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.label1.Location = new System.Drawing.Point(84, 77);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Nome";
			// 
			// txtId
			// 
			this.txtId.Location = new System.Drawing.Point(84, 54);
			this.txtId.Name = "txtId";
			this.txtId.ReadOnly = true;
			this.txtId.Size = new System.Drawing.Size(100, 20);
			this.txtId.TabIndex = 2;
			// 
			// txtNome
			// 
			this.txtNome.Location = new System.Drawing.Point(84, 103);
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(100, 20);
			this.txtNome.TabIndex = 3;
			// 
			// btnNovo
			// 
			this.btnNovo.BackColor = System.Drawing.Color.NavajoWhite;
			this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNovo.Location = new System.Drawing.Point(48, 445);
			this.btnNovo.Name = "btnNovo";
			this.btnNovo.Size = new System.Drawing.Size(75, 31);
			this.btnNovo.TabIndex = 4;
			this.btnNovo.Text = "Novo";
			this.btnNovo.UseVisualStyleBackColor = false;
			// 
			// btnSalvar
			// 
			this.btnSalvar.BackColor = System.Drawing.Color.NavajoWhite;
			this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSalvar.Location = new System.Drawing.Point(165, 445);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.Size = new System.Drawing.Size(75, 31);
			this.btnSalvar.TabIndex = 5;
			this.btnSalvar.Text = "Salvar";
			this.btnSalvar.UseVisualStyleBackColor = false;
			// 
			// btnExcluir
			// 
			this.btnExcluir.BackColor = System.Drawing.Color.NavajoWhite;
			this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExcluir.Location = new System.Drawing.Point(284, 445);
			this.btnExcluir.Name = "btnExcluir";
			this.btnExcluir.Size = new System.Drawing.Size(75, 31);
			this.btnExcluir.TabIndex = 6;
			this.btnExcluir.Text = "Excluir";
			this.btnExcluir.UseVisualStyleBackColor = false;
			// 
			// btnCancelar
			// 
			this.btnCancelar.BackColor = System.Drawing.Color.NavajoWhite;
			this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancelar.Location = new System.Drawing.Point(414, 445);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(86, 31);
			this.btnCancelar.TabIndex = 7;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = false;
			// 
			// dgvCategorias
			// 
			this.dgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCategorias.Location = new System.Drawing.Point(12, 150);
			this.dgvCategorias.Name = "dgvCategorias";
			this.dgvCategorias.Size = new System.Drawing.Size(626, 289);
			this.dgvCategorias.TabIndex = 8;
			// 
			// FrmCategorias
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.ClientSize = new System.Drawing.Size(669, 495);
			this.Controls.Add(this.dgvCategorias);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnExcluir);
			this.Controls.Add(this.btnSalvar);
			this.Controls.Add(this.btnNovo);
			this.Controls.Add(this.txtNome);
			this.Controls.Add(this.txtId);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "FrmCategorias";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmCategorias";
			((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
