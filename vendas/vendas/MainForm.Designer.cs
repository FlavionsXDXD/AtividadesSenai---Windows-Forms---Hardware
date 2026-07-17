/*
 * Created by SharpDevelop.
 * User: aluno_iot
 * Date: 16/07/2026
 * Time: 09:01
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace vendas
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox txtCliente;
		private System.Windows.Forms.Label lblCliente;
		private System.Windows.Forms.Label lblProduto;
		private System.Windows.Forms.Label lblValorunitario;
		private System.Windows.Forms.TextBox txtProduto;
		private System.Windows.Forms.TextBox txtValorunitario;
		private System.Windows.Forms.NumericUpDown nudQuantidade;
		private System.Windows.Forms.Label lblQuantidade;
		private System.Windows.Forms.RadioButton rdbDinheiro;
		private System.Windows.Forms.RadioButton rdbPix;
		private System.Windows.Forms.RadioButton rdbCartaoDebito;
		private System.Windows.Forms.RadioButton rdbCartaoCredito;
		private System.Windows.Forms.CheckBox chkEntrega;
		private System.Windows.Forms.CheckBox chkGarantia;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.GroupBox gbPagamentosBox;
		private System.Windows.Forms.Label lblTotal;
		private System.Windows.Forms.Label lblDescontos;
		private System.Windows.Forms.Label lblAcrecimos;
		private System.Windows.Forms.Label lblSubtotal;
		private System.Windows.Forms.Button btnSair;
		private System.Windows.Forms.Button btnNovavenda;
		private System.Windows.Forms.Button btnCalcular;
		private System.Windows.Forms.Label lblproduto3;
		private System.Windows.Forms.Label lblQuantidade2;
		
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
			this.txtCliente = new System.Windows.Forms.TextBox();
			this.lblCliente = new System.Windows.Forms.Label();
			this.lblProduto = new System.Windows.Forms.Label();
			this.lblValorunitario = new System.Windows.Forms.Label();
			this.txtProduto = new System.Windows.Forms.TextBox();
			this.txtValorunitario = new System.Windows.Forms.TextBox();
			this.nudQuantidade = new System.Windows.Forms.NumericUpDown();
			this.lblQuantidade = new System.Windows.Forms.Label();
			this.rdbDinheiro = new System.Windows.Forms.RadioButton();
			this.rdbPix = new System.Windows.Forms.RadioButton();
			this.rdbCartaoDebito = new System.Windows.Forms.RadioButton();
			this.rdbCartaoCredito = new System.Windows.Forms.RadioButton();
			this.chkEntrega = new System.Windows.Forms.CheckBox();
			this.chkGarantia = new System.Windows.Forms.CheckBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lblQuantidade2 = new System.Windows.Forms.Label();
			this.lblproduto3 = new System.Windows.Forms.Label();
			this.lblTotal = new System.Windows.Forms.Label();
			this.lblDescontos = new System.Windows.Forms.Label();
			this.lblAcrecimos = new System.Windows.Forms.Label();
			this.lblSubtotal = new System.Windows.Forms.Label();
			this.gbPagamentosBox = new System.Windows.Forms.GroupBox();
			this.btnSair = new System.Windows.Forms.Button();
			this.btnNovavenda = new System.Windows.Forms.Button();
			this.btnCalcular = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).BeginInit();
			this.panel1.SuspendLayout();
			this.gbPagamentosBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtCliente
			// 
			this.txtCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCliente.Location = new System.Drawing.Point(41, 57);
			this.txtCliente.Name = "txtCliente";
			this.txtCliente.Size = new System.Drawing.Size(100, 22);
			this.txtCliente.TabIndex = 0;
			// 
			// lblCliente
			// 
			this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCliente.Location = new System.Drawing.Point(29, 31);
			this.lblCliente.Name = "lblCliente";
			this.lblCliente.Size = new System.Drawing.Size(100, 23);
			this.lblCliente.TabIndex = 1;
			this.lblCliente.Text = "Cliente";
			// 
			// lblProduto
			// 
			this.lblProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblProduto.Location = new System.Drawing.Point(29, 82);
			this.lblProduto.Name = "lblProduto";
			this.lblProduto.Size = new System.Drawing.Size(100, 23);
			this.lblProduto.TabIndex = 2;
			this.lblProduto.Text = "Produto";
			// 
			// lblValorunitario
			// 
			this.lblValorunitario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblValorunitario.Location = new System.Drawing.Point(29, 133);
			this.lblValorunitario.Name = "lblValorunitario";
			this.lblValorunitario.Size = new System.Drawing.Size(121, 23);
			this.lblValorunitario.TabIndex = 3;
			this.lblValorunitario.Text = "Valor unitario";
			// 
			// txtProduto
			// 
			this.txtProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtProduto.Location = new System.Drawing.Point(41, 108);
			this.txtProduto.Name = "txtProduto";
			this.txtProduto.Size = new System.Drawing.Size(100, 22);
			this.txtProduto.TabIndex = 4;
			// 
			// txtValorunitario
			// 
			this.txtValorunitario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtValorunitario.Location = new System.Drawing.Point(41, 159);
			this.txtValorunitario.Name = "txtValorunitario";
			this.txtValorunitario.Size = new System.Drawing.Size(100, 22);
			this.txtValorunitario.TabIndex = 5;
			// 
			// nudQuantidade
			// 
			this.nudQuantidade.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.nudQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nudQuantidade.Location = new System.Drawing.Point(402, 60);
			this.nudQuantidade.Name = "nudQuantidade";
			this.nudQuantidade.Size = new System.Drawing.Size(58, 29);
			this.nudQuantidade.TabIndex = 6;
			// 
			// lblQuantidade
			// 
			this.lblQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblQuantidade.Location = new System.Drawing.Point(361, 34);
			this.lblQuantidade.Name = "lblQuantidade";
			this.lblQuantidade.Size = new System.Drawing.Size(109, 23);
			this.lblQuantidade.TabIndex = 7;
			this.lblQuantidade.Text = "Quantidade";
			// 
			// rdbDinheiro
			// 
			this.rdbDinheiro.BackColor = System.Drawing.Color.Transparent;
			this.rdbDinheiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdbDinheiro.ForeColor = System.Drawing.Color.Green;
			this.rdbDinheiro.Location = new System.Drawing.Point(11, 25);
			this.rdbDinheiro.Name = "rdbDinheiro";
			this.rdbDinheiro.Size = new System.Drawing.Size(124, 28);
			this.rdbDinheiro.TabIndex = 8;
			this.rdbDinheiro.TabStop = true;
			this.rdbDinheiro.Text = "Dinheiro ";
			this.rdbDinheiro.UseVisualStyleBackColor = false;
			// 
			// rdbPix
			// 
			this.rdbPix.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdbPix.ForeColor = System.Drawing.Color.Blue;
			this.rdbPix.Location = new System.Drawing.Point(11, 45);
			this.rdbPix.Name = "rdbPix";
			this.rdbPix.Size = new System.Drawing.Size(83, 34);
			this.rdbPix.TabIndex = 9;
			this.rdbPix.TabStop = true;
			this.rdbPix.Text = "Pix ";
			this.rdbPix.UseVisualStyleBackColor = true;
			// 
			// rdbCartaoDebito
			// 
			this.rdbCartaoDebito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdbCartaoDebito.ForeColor = System.Drawing.Color.Yellow;
			this.rdbCartaoDebito.Location = new System.Drawing.Point(11, 70);
			this.rdbCartaoDebito.Name = "rdbCartaoDebito";
			this.rdbCartaoDebito.Size = new System.Drawing.Size(101, 34);
			this.rdbCartaoDebito.TabIndex = 10;
			this.rdbCartaoDebito.TabStop = true;
			this.rdbCartaoDebito.Text = "Debito ";
			this.rdbCartaoDebito.UseVisualStyleBackColor = true;
			// 
			// rdbCartaoCredito
			// 
			this.rdbCartaoCredito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdbCartaoCredito.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.rdbCartaoCredito.Location = new System.Drawing.Point(11, 95);
			this.rdbCartaoCredito.Name = "rdbCartaoCredito";
			this.rdbCartaoCredito.Size = new System.Drawing.Size(101, 34);
			this.rdbCartaoCredito.TabIndex = 11;
			this.rdbCartaoCredito.TabStop = true;
			this.rdbCartaoCredito.Text = "Credito ";
			this.rdbCartaoCredito.UseVisualStyleBackColor = true;
			// 
			// chkEntrega
			// 
			this.chkEntrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkEntrega.Location = new System.Drawing.Point(346, 288);
			this.chkEntrega.Name = "chkEntrega";
			this.chkEntrega.Size = new System.Drawing.Size(148, 24);
			this.chkEntrega.TabIndex = 12;
			this.chkEntrega.Text = "Entrega ";
			this.chkEntrega.UseVisualStyleBackColor = true;
			// 
			// chkGarantia
			// 
			this.chkGarantia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkGarantia.Location = new System.Drawing.Point(346, 318);
			this.chkGarantia.Name = "chkGarantia";
			this.chkGarantia.Size = new System.Drawing.Size(114, 24);
			this.chkGarantia.TabIndex = 13;
			this.chkGarantia.Text = "Garantia ";
			this.chkGarantia.UseVisualStyleBackColor = true;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.panel1.Controls.Add(this.lblQuantidade2);
			this.panel1.Controls.Add(this.lblproduto3);
			this.panel1.Controls.Add(this.lblTotal);
			this.panel1.Controls.Add(this.lblDescontos);
			this.panel1.Controls.Add(this.lblAcrecimos);
			this.panel1.Controls.Add(this.lblSubtotal);
			this.panel1.Location = new System.Drawing.Point(29, 419);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(504, 164);
			this.panel1.TabIndex = 14;
			// 
			// lblQuantidade2
			// 
			this.lblQuantidade2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblQuantidade2.Location = new System.Drawing.Point(192, 96);
			this.lblQuantidade2.Name = "lblQuantidade2";
			this.lblQuantidade2.Size = new System.Drawing.Size(137, 34);
			this.lblQuantidade2.TabIndex = 5;
			this.lblQuantidade2.Text = "Quantidade";
			// 
			// lblproduto3
			// 
			this.lblproduto3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblproduto3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.lblproduto3.Location = new System.Drawing.Point(192, 62);
			this.lblproduto3.Name = "lblproduto3";
			this.lblproduto3.Size = new System.Drawing.Size(187, 34);
			this.lblproduto3.TabIndex = 4;
			this.lblproduto3.Text = "Produto:";
			// 
			// lblTotal
			// 
			this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTotal.ForeColor = System.Drawing.Color.Green;
			this.lblTotal.Location = new System.Drawing.Point(347, 118);
			this.lblTotal.Name = "lblTotal";
			this.lblTotal.Size = new System.Drawing.Size(154, 44);
			this.lblTotal.TabIndex = 3;
			this.lblTotal.Text = "Total:";
			// 
			// lblDescontos
			// 
			this.lblDescontos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDescontos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.lblDescontos.Location = new System.Drawing.Point(192, 12);
			this.lblDescontos.Name = "lblDescontos";
			this.lblDescontos.Size = new System.Drawing.Size(187, 34);
			this.lblDescontos.TabIndex = 2;
			this.lblDescontos.Text = "Descontos:";
			// 
			// lblAcrecimos
			// 
			this.lblAcrecimos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAcrecimos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.lblAcrecimos.Location = new System.Drawing.Point(10, 73);
			this.lblAcrecimos.Name = "lblAcrecimos";
			this.lblAcrecimos.Size = new System.Drawing.Size(121, 89);
			this.lblAcrecimos.TabIndex = 1;
			this.lblAcrecimos.Text = "Acrecimos:";
			// 
			// lblSubtotal
			// 
			this.lblSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSubtotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.lblSubtotal.Location = new System.Drawing.Point(10, 12);
			this.lblSubtotal.Name = "lblSubtotal";
			this.lblSubtotal.Size = new System.Drawing.Size(159, 61);
			this.lblSubtotal.TabIndex = 0;
			this.lblSubtotal.Text = "Subtotal:";
			// 
			// gbPagamentosBox
			// 
			this.gbPagamentosBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.gbPagamentosBox.Controls.Add(this.rdbDinheiro);
			this.gbPagamentosBox.Controls.Add(this.rdbPix);
			this.gbPagamentosBox.Controls.Add(this.rdbCartaoDebito);
			this.gbPagamentosBox.Controls.Add(this.rdbCartaoCredito);
			this.gbPagamentosBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbPagamentosBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.gbPagamentosBox.Location = new System.Drawing.Point(325, 108);
			this.gbPagamentosBox.Name = "gbPagamentosBox";
			this.gbPagamentosBox.Size = new System.Drawing.Size(117, 138);
			this.gbPagamentosBox.TabIndex = 15;
			this.gbPagamentosBox.TabStop = false;
			this.gbPagamentosBox.Text = "PAGAMENTOS";
			// 
			// btnSair
			// 
			this.btnSair.BackColor = System.Drawing.Color.Firebrick;
			this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSair.Location = new System.Drawing.Point(449, 359);
			this.btnSair.Name = "btnSair";
			this.btnSair.Size = new System.Drawing.Size(75, 43);
			this.btnSair.TabIndex = 16;
			this.btnSair.Text = "Sair";
			this.btnSair.UseVisualStyleBackColor = false;
			this.btnSair.Click += new System.EventHandler(this.BtnSairClick);
			// 
			// btnNovavenda
			// 
			this.btnNovavenda.BackColor = System.Drawing.SystemColors.Info;
			this.btnNovavenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNovavenda.Location = new System.Drawing.Point(325, 359);
			this.btnNovavenda.Name = "btnNovavenda";
			this.btnNovavenda.Size = new System.Drawing.Size(75, 43);
			this.btnNovavenda.TabIndex = 17;
			this.btnNovavenda.Text = "Nova Venda";
			this.btnNovavenda.UseVisualStyleBackColor = false;
			this.btnNovavenda.Click += new System.EventHandler(this.BtnNovavendaClick);
			// 
			// btnCalcular
			// 
			this.btnCalcular.BackColor = System.Drawing.Color.YellowGreen;
			this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCalcular.Location = new System.Drawing.Point(193, 359);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(75, 43);
			this.btnCalcular.TabIndex = 18;
			this.btnCalcular.Text = "Calcular";
			this.btnCalcular.UseVisualStyleBackColor = false;
			this.btnCalcular.Click += new System.EventHandler(this.BtnCalcularClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(567, 595);
			this.Controls.Add(this.btnCalcular);
			this.Controls.Add(this.btnNovavenda);
			this.Controls.Add(this.btnSair);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.chkGarantia);
			this.Controls.Add(this.chkEntrega);
			this.Controls.Add(this.lblQuantidade);
			this.Controls.Add(this.nudQuantidade);
			this.Controls.Add(this.txtValorunitario);
			this.Controls.Add(this.txtProduto);
			this.Controls.Add(this.lblValorunitario);
			this.Controls.Add(this.lblProduto);
			this.Controls.Add(this.lblCliente);
			this.Controls.Add(this.txtCliente);
			this.Controls.Add(this.gbPagamentosBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "MainForm";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "vendas";
			((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).EndInit();
			this.panel1.ResumeLayout(false);
			this.gbPagamentosBox.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
