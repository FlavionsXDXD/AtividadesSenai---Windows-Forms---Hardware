/*
 * Created by SharpDevelop.
 * User: Flavio
 * Date: 22/07/2026
 * Time: 15:42
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Cadastro
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lblID;
		private System.Windows.Forms.Label lblNome;
		private System.Windows.Forms.Label lblCPF;
		private System.Windows.Forms.Label lblEmail;
		private System.Windows.Forms.Label lblTelefone;
		private System.Windows.Forms.Label lblCidade;
		private System.Windows.Forms.TextBox txtId;
		private System.Windows.Forms.TextBox txtCPF;
		private System.Windows.Forms.TextBox txtNome;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.TextBox txtTelefone;
		private System.Windows.Forms.TextBox txtCidade;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.CheckBox chkAtivo;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button btnMostrarTodos;
		private System.Windows.Forms.TextBox txtPesquisar;
		private System.Windows.Forms.Label lblPesquisar;
		private System.Windows.Forms.DataGridView dgvClientes;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Button btnAtivarDesativar;
		private System.Windows.Forms.Button btnExcluir;
		private System.Windows.Forms.Button btnEditar;
		private System.Windows.Forms.Button btnSalvar;
		private System.Windows.Forms.Button btnNovo;
		private System.Windows.Forms.Button btnPesquisar;
		
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
			this.lblID = new System.Windows.Forms.Label();
			this.lblNome = new System.Windows.Forms.Label();
			this.lblCPF = new System.Windows.Forms.Label();
			this.lblEmail = new System.Windows.Forms.Label();
			this.lblTelefone = new System.Windows.Forms.Label();
			this.lblCidade = new System.Windows.Forms.Label();
			this.txtId = new System.Windows.Forms.TextBox();
			this.txtCPF = new System.Windows.Forms.TextBox();
			this.txtNome = new System.Windows.Forms.TextBox();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.txtTelefone = new System.Windows.Forms.TextBox();
			this.txtCidade = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.chkAtivo = new System.Windows.Forms.CheckBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btnPesquisar = new System.Windows.Forms.Button();
			this.txtPesquisar = new System.Windows.Forms.TextBox();
			this.lblPesquisar = new System.Windows.Forms.Label();
			this.btnMostrarTodos = new System.Windows.Forms.Button();
			this.dgvClientes = new System.Windows.Forms.DataGridView();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnAtivarDesativar = new System.Windows.Forms.Button();
			this.btnExcluir = new System.Windows.Forms.Button();
			this.btnEditar = new System.Windows.Forms.Button();
			this.btnSalvar = new System.Windows.Forms.Button();
			this.btnNovo = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblID
			// 
			this.lblID.BackColor = System.Drawing.Color.SlateGray;
			this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblID.Location = new System.Drawing.Point(26, 33);
			this.lblID.Name = "lblID";
			this.lblID.Size = new System.Drawing.Size(100, 23);
			this.lblID.TabIndex = 0;
			this.lblID.Text = "ID:";
			// 
			// lblNome
			// 
			this.lblNome.BackColor = System.Drawing.Color.SlateGray;
			this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNome.Location = new System.Drawing.Point(145, 33);
			this.lblNome.Name = "lblNome";
			this.lblNome.Size = new System.Drawing.Size(100, 23);
			this.lblNome.TabIndex = 1;
			this.lblNome.Text = "Nome:";
			// 
			// lblCPF
			// 
			this.lblCPF.BackColor = System.Drawing.Color.SlateGray;
			this.lblCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCPF.Location = new System.Drawing.Point(26, 82);
			this.lblCPF.Name = "lblCPF";
			this.lblCPF.Size = new System.Drawing.Size(100, 23);
			this.lblCPF.TabIndex = 2;
			this.lblCPF.Text = "CPF:";
			// 
			// lblEmail
			// 
			this.lblEmail.BackColor = System.Drawing.Color.SlateGray;
			this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblEmail.Location = new System.Drawing.Point(145, 82);
			this.lblEmail.Name = "lblEmail";
			this.lblEmail.Size = new System.Drawing.Size(100, 23);
			this.lblEmail.TabIndex = 3;
			this.lblEmail.Text = "Email:";
			// 
			// lblTelefone
			// 
			this.lblTelefone.BackColor = System.Drawing.Color.SlateGray;
			this.lblTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTelefone.Location = new System.Drawing.Point(26, 131);
			this.lblTelefone.Name = "lblTelefone";
			this.lblTelefone.Size = new System.Drawing.Size(100, 23);
			this.lblTelefone.TabIndex = 4;
			this.lblTelefone.Text = "Telefone:";
			// 
			// lblCidade
			// 
			this.lblCidade.BackColor = System.Drawing.Color.SlateGray;
			this.lblCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCidade.Location = new System.Drawing.Point(145, 131);
			this.lblCidade.Name = "lblCidade";
			this.lblCidade.Size = new System.Drawing.Size(100, 23);
			this.lblCidade.TabIndex = 5;
			this.lblCidade.Text = "Cidade:";
			// 
			// txtId
			// 
			this.txtId.Location = new System.Drawing.Point(26, 59);
			this.txtId.Name = "txtId";
			this.txtId.Size = new System.Drawing.Size(100, 20);
			this.txtId.TabIndex = 6;
			// 
			// txtCPF
			// 
			this.txtCPF.Location = new System.Drawing.Point(26, 108);
			this.txtCPF.Name = "txtCPF";
			this.txtCPF.Size = new System.Drawing.Size(100, 20);
			this.txtCPF.TabIndex = 7;
			// 
			// txtNome
			// 
			this.txtNome.Location = new System.Drawing.Point(145, 59);
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(100, 20);
			this.txtNome.TabIndex = 8;
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(145, 108);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(100, 20);
			this.txtEmail.TabIndex = 9;
			// 
			// txtTelefone
			// 
			this.txtTelefone.Location = new System.Drawing.Point(26, 157);
			this.txtTelefone.Name = "txtTelefone";
			this.txtTelefone.Size = new System.Drawing.Size(100, 20);
			this.txtTelefone.TabIndex = 10;
			// 
			// txtCidade
			// 
			this.txtCidade.Location = new System.Drawing.Point(145, 157);
			this.txtCidade.Name = "txtCidade";
			this.txtCidade.Size = new System.Drawing.Size(100, 20);
			this.txtCidade.TabIndex = 11;
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.SlateGray;
			this.groupBox1.Controls.Add(this.chkAtivo);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(244, 199);
			this.groupBox1.TabIndex = 12;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Dados";
			// 
			// chkAtivo
			// 
			this.chkAtivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkAtivo.Location = new System.Drawing.Point(14, 171);
			this.chkAtivo.Name = "chkAtivo";
			this.chkAtivo.Size = new System.Drawing.Size(104, 24);
			this.chkAtivo.TabIndex = 13;
			this.chkAtivo.Text = "Ativo";
			this.chkAtivo.UseVisualStyleBackColor = true;
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.LightSteelBlue;
			this.groupBox2.Controls.Add(this.btnPesquisar);
			this.groupBox2.Controls.Add(this.txtPesquisar);
			this.groupBox2.Controls.Add(this.lblPesquisar);
			this.groupBox2.Location = new System.Drawing.Point(364, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(238, 79);
			this.groupBox2.TabIndex = 13;
			this.groupBox2.TabStop = false;
			// 
			// btnPesquisar
			// 
			this.btnPesquisar.BackColor = System.Drawing.Color.MediumSlateBlue;
			this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPesquisar.Location = new System.Drawing.Point(142, 32);
			this.btnPesquisar.Name = "btnPesquisar";
			this.btnPesquisar.Size = new System.Drawing.Size(90, 35);
			this.btnPesquisar.TabIndex = 16;
			this.btnPesquisar.Text = "Pesquisar";
			this.btnPesquisar.UseVisualStyleBackColor = false;
			this.btnPesquisar.Click += new System.EventHandler(this.BtnPesquisarClick);
			// 
			// txtPesquisar
			// 
			this.txtPesquisar.Location = new System.Drawing.Point(18, 42);
			this.txtPesquisar.Name = "txtPesquisar";
			this.txtPesquisar.Size = new System.Drawing.Size(100, 20);
			this.txtPesquisar.TabIndex = 14;
			// 
			// lblPesquisar
			// 
			this.lblPesquisar.BackColor = System.Drawing.Color.LightSteelBlue;
			this.lblPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPesquisar.Location = new System.Drawing.Point(18, 16);
			this.lblPesquisar.Name = "lblPesquisar";
			this.lblPesquisar.Size = new System.Drawing.Size(100, 23);
			this.lblPesquisar.TabIndex = 14;
			this.lblPesquisar.Text = "Pesquisar";
			// 
			// btnMostrarTodos
			// 
			this.btnMostrarTodos.BackColor = System.Drawing.Color.LightPink;
			this.btnMostrarTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMostrarTodos.Location = new System.Drawing.Point(571, 183);
			this.btnMostrarTodos.Name = "btnMostrarTodos";
			this.btnMostrarTodos.Size = new System.Drawing.Size(90, 35);
			this.btnMostrarTodos.TabIndex = 15;
			this.btnMostrarTodos.Text = "Mostrar todos";
			this.btnMostrarTodos.UseVisualStyleBackColor = false;
			this.btnMostrarTodos.Click += new System.EventHandler(this.BtnMostrarTodosClick);
			// 
			// dgvClientes
			// 
			this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvClientes.Location = new System.Drawing.Point(12, 229);
			this.dgvClientes.Name = "dgvClientes";
			this.dgvClientes.Size = new System.Drawing.Size(662, 292);
			this.dgvClientes.TabIndex = 14;
			this.dgvClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvClientesCellClick);
			// 
			// groupBox3
			// 
			this.groupBox3.BackColor = System.Drawing.Color.SteelBlue;
			this.groupBox3.Controls.Add(this.btnCancelar);
			this.groupBox3.Controls.Add(this.btnAtivarDesativar);
			this.groupBox3.Controls.Add(this.btnExcluir);
			this.groupBox3.Controls.Add(this.btnEditar);
			this.groupBox3.Controls.Add(this.btnSalvar);
			this.groupBox3.Controls.Add(this.btnNovo);
			this.groupBox3.Location = new System.Drawing.Point(0, 527);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(685, 59);
			this.groupBox3.TabIndex = 15;
			this.groupBox3.TabStop = false;
			// 
			// btnCancelar
			// 
			this.btnCancelar.BackColor = System.Drawing.Color.Orange;
			this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancelar.Location = new System.Drawing.Point(599, 14);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(75, 34);
			this.btnCancelar.TabIndex = 18;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = false;
			this.btnCancelar.Click += new System.EventHandler(this.BtnCancelarClick);
			// 
			// btnAtivarDesativar
			// 
			this.btnAtivarDesativar.BackColor = System.Drawing.Color.Yellow;
			this.btnAtivarDesativar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAtivarDesativar.Location = new System.Drawing.Point(468, 13);
			this.btnAtivarDesativar.Name = "btnAtivarDesativar";
			this.btnAtivarDesativar.Size = new System.Drawing.Size(110, 34);
			this.btnAtivarDesativar.TabIndex = 17;
			this.btnAtivarDesativar.Text = "Ativar/Desativar";
			this.btnAtivarDesativar.UseVisualStyleBackColor = false;
			this.btnAtivarDesativar.Click += new System.EventHandler(this.BtnAtivarDesativarClick);
			// 
			// btnExcluir
			// 
			this.btnExcluir.BackColor = System.Drawing.Color.Red;
			this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExcluir.Location = new System.Drawing.Point(350, 16);
			this.btnExcluir.Name = "btnExcluir";
			this.btnExcluir.Size = new System.Drawing.Size(75, 31);
			this.btnExcluir.TabIndex = 16;
			this.btnExcluir.Text = "Excluir";
			this.btnExcluir.UseVisualStyleBackColor = false;
			this.btnExcluir.Click += new System.EventHandler(this.BtnExcluirClick);
			// 
			// btnEditar
			// 
			this.btnEditar.BackColor = System.Drawing.Color.DarkTurquoise;
			this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEditar.Location = new System.Drawing.Point(253, 16);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Size = new System.Drawing.Size(75, 31);
			this.btnEditar.TabIndex = 2;
			this.btnEditar.Text = "Editar";
			this.btnEditar.UseVisualStyleBackColor = false;
			this.btnEditar.Click += new System.EventHandler(this.BtnEditarClick);
			// 
			// btnSalvar
			// 
			this.btnSalvar.BackColor = System.Drawing.Color.DarkGreen;
			this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSalvar.Location = new System.Drawing.Point(94, 16);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.Size = new System.Drawing.Size(75, 33);
			this.btnSalvar.TabIndex = 1;
			this.btnSalvar.Text = "Salvar";
			this.btnSalvar.UseVisualStyleBackColor = false;
			this.btnSalvar.Click += new System.EventHandler(this.BtnSalvarClick);
			// 
			// btnNovo
			// 
			this.btnNovo.BackColor = System.Drawing.Color.OliveDrab;
			this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNovo.Location = new System.Drawing.Point(13, 16);
			this.btnNovo.Name = "btnNovo";
			this.btnNovo.Size = new System.Drawing.Size(75, 33);
			this.btnNovo.TabIndex = 0;
			this.btnNovo.Text = "Novo";
			this.btnNovo.UseVisualStyleBackColor = false;
			this.btnNovo.Click += new System.EventHandler(this.BtnNovoClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightSlateGray;
			this.ClientSize = new System.Drawing.Size(686, 598);
			this.Controls.Add(this.btnMostrarTodos);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.dgvClientes);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.txtCidade);
			this.Controls.Add(this.txtTelefone);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.txtNome);
			this.Controls.Add(this.txtCPF);
			this.Controls.Add(this.txtId);
			this.Controls.Add(this.lblCidade);
			this.Controls.Add(this.lblTelefone);
			this.Controls.Add(this.lblEmail);
			this.Controls.Add(this.lblCPF);
			this.Controls.Add(this.lblNome);
			this.Controls.Add(this.lblID);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "MainForm";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cadastro";
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
			this.groupBox3.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
