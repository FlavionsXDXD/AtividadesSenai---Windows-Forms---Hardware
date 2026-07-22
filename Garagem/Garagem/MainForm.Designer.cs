/*
 * Created by SharpDevelop.
 * User: Flavio
 * Date: 21/07/2026
 * Time: 10:00
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Garagem
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lblPlaca;
		private System.Windows.Forms.Label lblModelo;
		private System.Windows.Forms.TextBox txtPlaca;
		private System.Windows.Forms.TextBox txtModelo;
		private System.Windows.Forms.DateTimePicker dtpEntrada;
		private System.Windows.Forms.Label lblEntrada;
		private System.Windows.Forms.Label lblSaida;
		private System.Windows.Forms.DateTimePicker dtpSaida;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtPesquisarPlaca;
		private System.Windows.Forms.Label lblPesquisarPlaca;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button btnRegistrarEntrada;
		private System.Windows.Forms.Button btnRegistrarSaida;
		private System.Windows.Forms.Button btnRemover;
		private System.Windows.Forms.Button btnLimpar;
		private System.Windows.Forms.Button btnEncerrar;
		private System.Windows.Forms.Button btnPesquisar;
		private System.Windows.Forms.Button btnMostrarTodos;
		private System.Windows.Forms.DataGridView dgvVeiculos;
		private System.Windows.Forms.Label lblTotalRecebido;
		private System.Windows.Forms.Label lblFinalizados;
		private System.Windows.Forms.Label lblEstacionados;
		private System.Windows.Forms.Label lblTipoVeiculo;
		private System.Windows.Forms.ComboBox cboTipoVeiculo;
		
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
			this.lblPlaca = new System.Windows.Forms.Label();
			this.lblModelo = new System.Windows.Forms.Label();
			this.txtPlaca = new System.Windows.Forms.TextBox();
			this.txtModelo = new System.Windows.Forms.TextBox();
			this.dtpEntrada = new System.Windows.Forms.DateTimePicker();
			this.lblEntrada = new System.Windows.Forms.Label();
			this.lblSaida = new System.Windows.Forms.Label();
			this.dtpSaida = new System.Windows.Forms.DateTimePicker();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.lblTotalRecebido = new System.Windows.Forms.Label();
			this.lblFinalizados = new System.Windows.Forms.Label();
			this.lblEstacionados = new System.Windows.Forms.Label();
			this.txtPesquisarPlaca = new System.Windows.Forms.TextBox();
			this.lblPesquisarPlaca = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.lblTipoVeiculo = new System.Windows.Forms.Label();
			this.cboTipoVeiculo = new System.Windows.Forms.ComboBox();
			this.btnRegistrarEntrada = new System.Windows.Forms.Button();
			this.btnRegistrarSaida = new System.Windows.Forms.Button();
			this.btnRemover = new System.Windows.Forms.Button();
			this.btnLimpar = new System.Windows.Forms.Button();
			this.btnEncerrar = new System.Windows.Forms.Button();
			this.btnPesquisar = new System.Windows.Forms.Button();
			this.btnMostrarTodos = new System.Windows.Forms.Button();
			this.dgvVeiculos = new System.Windows.Forms.DataGridView();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvVeiculos)).BeginInit();
			this.SuspendLayout();
			// 
			// lblPlaca
			// 
			this.lblPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPlaca.Location = new System.Drawing.Point(21, 19);
			this.lblPlaca.Name = "lblPlaca";
			this.lblPlaca.Size = new System.Drawing.Size(100, 23);
			this.lblPlaca.TabIndex = 0;
			this.lblPlaca.Text = "Placa";
			// 
			// lblModelo
			// 
			this.lblModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblModelo.Location = new System.Drawing.Point(177, 37);
			this.lblModelo.Name = "lblModelo";
			this.lblModelo.Size = new System.Drawing.Size(100, 23);
			this.lblModelo.TabIndex = 1;
			this.lblModelo.Text = "Modelo";
			// 
			// txtPlaca
			// 
			this.txtPlaca.Location = new System.Drawing.Point(21, 46);
			this.txtPlaca.Name = "txtPlaca";
			this.txtPlaca.Size = new System.Drawing.Size(100, 20);
			this.txtPlaca.TabIndex = 2;
			// 
			// txtModelo
			// 
			this.txtModelo.Location = new System.Drawing.Point(177, 64);
			this.txtModelo.Name = "txtModelo";
			this.txtModelo.Size = new System.Drawing.Size(100, 20);
			this.txtModelo.TabIndex = 3;
			// 
			// dtpEntrada
			// 
			this.dtpEntrada.Location = new System.Drawing.Point(360, 40);
			this.dtpEntrada.Name = "dtpEntrada";
			this.dtpEntrada.Size = new System.Drawing.Size(218, 20);
			this.dtpEntrada.TabIndex = 4;
			// 
			// lblEntrada
			// 
			this.lblEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblEntrada.Location = new System.Drawing.Point(413, 14);
			this.lblEntrada.Name = "lblEntrada";
			this.lblEntrada.Size = new System.Drawing.Size(100, 23);
			this.lblEntrada.TabIndex = 5;
			this.lblEntrada.Text = "Entrada";
			this.lblEntrada.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblSaida
			// 
			this.lblSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSaida.Location = new System.Drawing.Point(413, 95);
			this.lblSaida.Name = "lblSaida";
			this.lblSaida.Size = new System.Drawing.Size(100, 23);
			this.lblSaida.TabIndex = 6;
			this.lblSaida.Text = "Saida";
			this.lblSaida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dtpSaida
			// 
			this.dtpSaida.Location = new System.Drawing.Point(360, 121);
			this.dtpSaida.Name = "dtpSaida";
			this.dtpSaida.Size = new System.Drawing.Size(218, 20);
			this.dtpSaida.TabIndex = 7;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.lblTotalRecebido);
			this.groupBox1.Controls.Add(this.lblFinalizados);
			this.groupBox1.Controls.Add(this.lblEstacionados);
			this.groupBox1.Controls.Add(this.txtPesquisarPlaca);
			this.groupBox1.Controls.Add(this.lblPesquisarPlaca);
			this.groupBox1.Location = new System.Drawing.Point(12, 225);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(222, 182);
			this.groupBox1.TabIndex = 8;
			this.groupBox1.TabStop = false;
			// 
			// lblTotalRecebido
			// 
			this.lblTotalRecebido.AutoSize = true;
			this.lblTotalRecebido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTotalRecebido.Location = new System.Drawing.Point(6, 140);
			this.lblTotalRecebido.Name = "lblTotalRecebido";
			this.lblTotalRecebido.Size = new System.Drawing.Size(116, 16);
			this.lblTotalRecebido.TabIndex = 21;
			this.lblTotalRecebido.Text = "Total Recebido";
			// 
			// lblFinalizados
			// 
			this.lblFinalizados.AutoSize = true;
			this.lblFinalizados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFinalizados.Location = new System.Drawing.Point(8, 121);
			this.lblFinalizados.Name = "lblFinalizados";
			this.lblFinalizados.Size = new System.Drawing.Size(88, 16);
			this.lblFinalizados.TabIndex = 20;
			this.lblFinalizados.Text = "Finalizados";
			// 
			// lblEstacionados
			// 
			this.lblEstacionados.AutoSize = true;
			this.lblEstacionados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblEstacionados.Location = new System.Drawing.Point(8, 101);
			this.lblEstacionados.Name = "lblEstacionados";
			this.lblEstacionados.Size = new System.Drawing.Size(103, 16);
			this.lblEstacionados.TabIndex = 19;
			this.lblEstacionados.Text = "Estacionados";
			// 
			// txtPesquisarPlaca
			// 
			this.txtPesquisarPlaca.Location = new System.Drawing.Point(21, 42);
			this.txtPesquisarPlaca.Name = "txtPesquisarPlaca";
			this.txtPesquisarPlaca.Size = new System.Drawing.Size(100, 20);
			this.txtPesquisarPlaca.TabIndex = 18;
			// 
			// lblPesquisarPlaca
			// 
			this.lblPesquisarPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPesquisarPlaca.Location = new System.Drawing.Point(21, 16);
			this.lblPesquisarPlaca.Name = "lblPesquisarPlaca";
			this.lblPesquisarPlaca.Size = new System.Drawing.Size(100, 23);
			this.lblPesquisarPlaca.TabIndex = 18;
			this.lblPesquisarPlaca.Text = "Placa";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.lblTipoVeiculo);
			this.groupBox2.Controls.Add(this.cboTipoVeiculo);
			this.groupBox2.Controls.Add(this.btnRegistrarEntrada);
			this.groupBox2.Controls.Add(this.lblPlaca);
			this.groupBox2.Controls.Add(this.txtPlaca);
			this.groupBox2.Location = new System.Drawing.Point(12, 18);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(572, 168);
			this.groupBox2.TabIndex = 9;
			this.groupBox2.TabStop = false;
			// 
			// lblTipoVeiculo
			// 
			this.lblTipoVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTipoVeiculo.Location = new System.Drawing.Point(165, 80);
			this.lblTipoVeiculo.Name = "lblTipoVeiculo";
			this.lblTipoVeiculo.Size = new System.Drawing.Size(100, 23);
			this.lblTipoVeiculo.TabIndex = 18;
			this.lblTipoVeiculo.Text = "Tipo ";
			// 
			// cboTipoVeiculo
			// 
			this.cboTipoVeiculo.FormattingEnabled = true;
			this.cboTipoVeiculo.Location = new System.Drawing.Point(165, 106);
			this.cboTipoVeiculo.Name = "cboTipoVeiculo";
			this.cboTipoVeiculo.Size = new System.Drawing.Size(121, 21);
			this.cboTipoVeiculo.TabIndex = 22;
			// 
			// btnRegistrarEntrada
			// 
			this.btnRegistrarEntrada.BackColor = System.Drawing.Color.MediumSeaGreen;
			this.btnRegistrarEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRegistrarEntrada.Location = new System.Drawing.Point(31, 95);
			this.btnRegistrarEntrada.Name = "btnRegistrarEntrada";
			this.btnRegistrarEntrada.Size = new System.Drawing.Size(75, 41);
			this.btnRegistrarEntrada.TabIndex = 10;
			this.btnRegistrarEntrada.Text = "Registrar Entrada";
			this.btnRegistrarEntrada.UseVisualStyleBackColor = false;
			this.btnRegistrarEntrada.Click += new System.EventHandler(this.BtnRegistrarEntradaClick);
			// 
			// btnRegistrarSaida
			// 
			this.btnRegistrarSaida.BackColor = System.Drawing.Color.SteelBlue;
			this.btnRegistrarSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRegistrarSaida.Location = new System.Drawing.Point(360, 413);
			this.btnRegistrarSaida.Name = "btnRegistrarSaida";
			this.btnRegistrarSaida.Size = new System.Drawing.Size(75, 41);
			this.btnRegistrarSaida.TabIndex = 11;
			this.btnRegistrarSaida.Text = "Registrar Saida";
			this.btnRegistrarSaida.UseVisualStyleBackColor = false;
			this.btnRegistrarSaida.Click += new System.EventHandler(this.BtnRegistrarSaidaClick);
			// 
			// btnRemover
			// 
			this.btnRemover.BackColor = System.Drawing.Color.IndianRed;
			this.btnRemover.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRemover.Location = new System.Drawing.Point(223, 413);
			this.btnRemover.Name = "btnRemover";
			this.btnRemover.Size = new System.Drawing.Size(75, 41);
			this.btnRemover.TabIndex = 12;
			this.btnRemover.Text = "Remover";
			this.btnRemover.UseVisualStyleBackColor = false;
			this.btnRemover.Click += new System.EventHandler(this.BtnRemoverClick);
			// 
			// btnLimpar
			// 
			this.btnLimpar.BackColor = System.Drawing.Color.Khaki;
			this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLimpar.Location = new System.Drawing.Point(360, 191);
			this.btnLimpar.Name = "btnLimpar";
			this.btnLimpar.Size = new System.Drawing.Size(75, 33);
			this.btnLimpar.TabIndex = 13;
			this.btnLimpar.Text = "Limpar";
			this.btnLimpar.UseVisualStyleBackColor = false;
			this.btnLimpar.Click += new System.EventHandler(this.BtnLimparClick);
			// 
			// btnEncerrar
			// 
			this.btnEncerrar.BackColor = System.Drawing.Color.Firebrick;
			this.btnEncerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEncerrar.Location = new System.Drawing.Point(509, 413);
			this.btnEncerrar.Name = "btnEncerrar";
			this.btnEncerrar.Size = new System.Drawing.Size(75, 41);
			this.btnEncerrar.TabIndex = 14;
			this.btnEncerrar.Text = "Encerrar";
			this.btnEncerrar.UseVisualStyleBackColor = false;
			this.btnEncerrar.Click += new System.EventHandler(this.BtnEncerrarClick);
			// 
			// btnPesquisar
			// 
			this.btnPesquisar.BackColor = System.Drawing.Color.LightPink;
			this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPesquisar.Location = new System.Drawing.Point(33, 192);
			this.btnPesquisar.Name = "btnPesquisar";
			this.btnPesquisar.Size = new System.Drawing.Size(75, 32);
			this.btnPesquisar.TabIndex = 15;
			this.btnPesquisar.Text = "Pesquisar";
			this.btnPesquisar.UseVisualStyleBackColor = false;
			this.btnPesquisar.Click += new System.EventHandler(this.BtnPesquisarClick);
			// 
			// btnMostrarTodos
			// 
			this.btnMostrarTodos.BackColor = System.Drawing.Color.DarkGray;
			this.btnMostrarTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMostrarTodos.Location = new System.Drawing.Point(134, 191);
			this.btnMostrarTodos.Name = "btnMostrarTodos";
			this.btnMostrarTodos.Size = new System.Drawing.Size(68, 35);
			this.btnMostrarTodos.TabIndex = 16;
			this.btnMostrarTodos.Text = "Mostrar Todos";
			this.btnMostrarTodos.UseVisualStyleBackColor = false;
			this.btnMostrarTodos.Click += new System.EventHandler(this.BtnMostrarTodosClick);
			// 
			// dgvVeiculos
			// 
			this.dgvVeiculos.AllowUserToAddRows = false;
			this.dgvVeiculos.AllowUserToDeleteRows = false;
			this.dgvVeiculos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.dgvVeiculos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvVeiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvVeiculos.Location = new System.Drawing.Point(240, 225);
			this.dgvVeiculos.MultiSelect = false;
			this.dgvVeiculos.Name = "dgvVeiculos";
			this.dgvVeiculos.ReadOnly = true;
			this.dgvVeiculos.RowHeadersVisible = false;
			this.dgvVeiculos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvVeiculos.Size = new System.Drawing.Size(360, 182);
			this.dgvVeiculos.TabIndex = 17;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.ClientSize = new System.Drawing.Size(612, 458);
			this.Controls.Add(this.dgvVeiculos);
			this.Controls.Add(this.btnRemover);
			this.Controls.Add(this.btnMostrarTodos);
			this.Controls.Add(this.btnRegistrarSaida);
			this.Controls.Add(this.btnPesquisar);
			this.Controls.Add(this.btnEncerrar);
			this.Controls.Add(this.btnLimpar);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.dtpSaida);
			this.Controls.Add(this.lblSaida);
			this.Controls.Add(this.lblEntrada);
			this.Controls.Add(this.dtpEntrada);
			this.Controls.Add(this.txtModelo);
			this.Controls.Add(this.lblModelo);
			this.Controls.Add(this.groupBox2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "MainForm";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Garagem";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvVeiculos)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
