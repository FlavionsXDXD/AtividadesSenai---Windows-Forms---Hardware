/*
 * Created by SharpDevelop.
 * User: aluno_iot
 * Date: 14/07/2026
 * Time: 08:20
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace SistemaOrcamento
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.ComboBox cboperfil;
		private System.Windows.Forms.Label lblcliente;
		private System.Windows.Forms.TextBox txtNome;
		private System.Windows.Forms.Label lblperfil;
		private System.Windows.Forms.ComboBox cboprocessador;
		private System.Windows.Forms.ComboBox cboplacadevideo;
		private System.Windows.Forms.ComboBox cboplacamae;
		private System.Windows.Forms.ComboBox cbofonte;
		private System.Windows.Forms.ComboBox cbomemoria;
		private System.Windows.Forms.ComboBox cbossd;
		private System.Windows.Forms.ComboBox cbogabinete;
		private System.Windows.Forms.Label lblProcessador;
		private System.Windows.Forms.Label lblfonte;
		private System.Windows.Forms.Label lblmemoria;
		private System.Windows.Forms.Label lblssd;
		private System.Windows.Forms.Label lblplacadevideo;
		private System.Windows.Forms.Label lblplacamae;
		private System.Windows.Forms.Label lblgabinete;
		private System.Windows.Forms.Label lblopcionais;
		private System.Windows.Forms.Button btnCarregarRecomendacao;
		private System.Windows.Forms.Button btnCalcular;
		private System.Windows.Forms.Button btnLimpar;
		private System.Windows.Forms.Button btnSair;
		private System.Windows.Forms.CheckBox chkMonitor;
		private System.Windows.Forms.CheckBox chktecladomouse;
		private System.Windows.Forms.CheckBox chkheadset;
		private System.Windows.Forms.TextBox txtdesconto;
		private System.Windows.Forms.TextBox txttaxa;
		private System.Windows.Forms.Label lbltaxa;
		private System.Windows.Forms.Label lbldesconto;
		
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
			this.cboperfil = new System.Windows.Forms.ComboBox();
			this.lblcliente = new System.Windows.Forms.Label();
			this.txtNome = new System.Windows.Forms.TextBox();
			this.lblperfil = new System.Windows.Forms.Label();
			this.cboprocessador = new System.Windows.Forms.ComboBox();
			this.cboplacadevideo = new System.Windows.Forms.ComboBox();
			this.cboplacamae = new System.Windows.Forms.ComboBox();
			this.cbofonte = new System.Windows.Forms.ComboBox();
			this.cbomemoria = new System.Windows.Forms.ComboBox();
			this.cbossd = new System.Windows.Forms.ComboBox();
			this.cbogabinete = new System.Windows.Forms.ComboBox();
			this.lblProcessador = new System.Windows.Forms.Label();
			this.lblfonte = new System.Windows.Forms.Label();
			this.lblmemoria = new System.Windows.Forms.Label();
			this.lblssd = new System.Windows.Forms.Label();
			this.lblplacadevideo = new System.Windows.Forms.Label();
			this.lblplacamae = new System.Windows.Forms.Label();
			this.lblgabinete = new System.Windows.Forms.Label();
			this.lblopcionais = new System.Windows.Forms.Label();
			this.btnCarregarRecomendacao = new System.Windows.Forms.Button();
			this.btnCalcular = new System.Windows.Forms.Button();
			this.btnLimpar = new System.Windows.Forms.Button();
			this.btnSair = new System.Windows.Forms.Button();
			this.chkMonitor = new System.Windows.Forms.CheckBox();
			this.chktecladomouse = new System.Windows.Forms.CheckBox();
			this.chkheadset = new System.Windows.Forms.CheckBox();
			this.txtdesconto = new System.Windows.Forms.TextBox();
			this.txttaxa = new System.Windows.Forms.TextBox();
			this.lbltaxa = new System.Windows.Forms.Label();
			this.lbldesconto = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// cboperfil
			// 
			this.cboperfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cboperfil.FormattingEnabled = true;
			this.cboperfil.Location = new System.Drawing.Point(35, 108);
			this.cboperfil.Name = "cboperfil";
			this.cboperfil.Size = new System.Drawing.Size(121, 21);
			this.cboperfil.TabIndex = 0;
			// 
			// lblcliente
			// 
			this.lblcliente.Location = new System.Drawing.Point(35, 33);
			this.lblcliente.Name = "lblcliente";
			this.lblcliente.Size = new System.Drawing.Size(100, 23);
			this.lblcliente.TabIndex = 2;
			this.lblcliente.Text = "Cliente:";
			// 
			// txtNome
			// 
			this.txtNome.Location = new System.Drawing.Point(102, 30);
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(100, 26);
			this.txtNome.TabIndex = 3;
			// 
			// lblperfil
			// 
			this.lblperfil.Location = new System.Drawing.Point(35, 82);
			this.lblperfil.Name = "lblperfil";
			this.lblperfil.Size = new System.Drawing.Size(100, 23);
			this.lblperfil.TabIndex = 4;
			this.lblperfil.Text = "Perfil:";
			// 
			// cboprocessador
			// 
			this.cboprocessador.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cboprocessador.FormattingEnabled = true;
			this.cboprocessador.Location = new System.Drawing.Point(35, 196);
			this.cboprocessador.Name = "cboprocessador";
			this.cboprocessador.Size = new System.Drawing.Size(121, 21);
			this.cboprocessador.TabIndex = 5;
			// 
			// cboplacadevideo
			// 
			this.cboplacadevideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cboplacadevideo.FormattingEnabled = true;
			this.cboplacadevideo.Location = new System.Drawing.Point(35, 357);
			this.cboplacadevideo.Name = "cboplacadevideo";
			this.cboplacadevideo.Size = new System.Drawing.Size(121, 21);
			this.cboplacadevideo.TabIndex = 6;
			// 
			// cboplacamae
			// 
			this.cboplacamae.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cboplacamae.FormattingEnabled = true;
			this.cboplacamae.Location = new System.Drawing.Point(191, 196);
			this.cboplacamae.Name = "cboplacamae";
			this.cboplacamae.Size = new System.Drawing.Size(121, 21);
			this.cboplacamae.TabIndex = 7;
			// 
			// cbofonte
			// 
			this.cbofonte.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbofonte.FormattingEnabled = true;
			this.cbofonte.Location = new System.Drawing.Point(191, 357);
			this.cbofonte.Name = "cbofonte";
			this.cbofonte.Size = new System.Drawing.Size(121, 21);
			this.cbofonte.TabIndex = 8;
			// 
			// cbomemoria
			// 
			this.cbomemoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbomemoria.FormattingEnabled = true;
			this.cbomemoria.Location = new System.Drawing.Point(35, 277);
			this.cbomemoria.Name = "cbomemoria";
			this.cbomemoria.Size = new System.Drawing.Size(121, 21);
			this.cbomemoria.TabIndex = 9;
			// 
			// cbossd
			// 
			this.cbossd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbossd.FormattingEnabled = true;
			this.cbossd.Location = new System.Drawing.Point(191, 277);
			this.cbossd.Name = "cbossd";
			this.cbossd.Size = new System.Drawing.Size(121, 21);
			this.cbossd.TabIndex = 10;
			// 
			// cbogabinete
			// 
			this.cbogabinete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbogabinete.FormattingEnabled = true;
			this.cbogabinete.Location = new System.Drawing.Point(372, 196);
			this.cbogabinete.Name = "cbogabinete";
			this.cbogabinete.Size = new System.Drawing.Size(121, 21);
			this.cbogabinete.TabIndex = 11;
			// 
			// lblProcessador
			// 
			this.lblProcessador.Location = new System.Drawing.Point(35, 170);
			this.lblProcessador.Name = "lblProcessador";
			this.lblProcessador.Size = new System.Drawing.Size(121, 23);
			this.lblProcessador.TabIndex = 12;
			this.lblProcessador.Text = "Processador";
			// 
			// lblfonte
			// 
			this.lblfonte.Location = new System.Drawing.Point(191, 331);
			this.lblfonte.Name = "lblfonte";
			this.lblfonte.Size = new System.Drawing.Size(100, 23);
			this.lblfonte.TabIndex = 13;
			this.lblfonte.Text = "Fonte";
			// 
			// lblmemoria
			// 
			this.lblmemoria.Location = new System.Drawing.Point(35, 251);
			this.lblmemoria.Name = "lblmemoria";
			this.lblmemoria.Size = new System.Drawing.Size(100, 34);
			this.lblmemoria.TabIndex = 14;
			this.lblmemoria.Text = "Memoria";
			// 
			// lblssd
			// 
			this.lblssd.Location = new System.Drawing.Point(191, 251);
			this.lblssd.Name = "lblssd";
			this.lblssd.Size = new System.Drawing.Size(143, 23);
			this.lblssd.TabIndex = 15;
			this.lblssd.Text = "armazenamento";
			// 
			// lblplacadevideo
			// 
			this.lblplacadevideo.Location = new System.Drawing.Point(35, 331);
			this.lblplacadevideo.Name = "lblplacadevideo";
			this.lblplacadevideo.Size = new System.Drawing.Size(128, 23);
			this.lblplacadevideo.TabIndex = 16;
			this.lblplacadevideo.Text = "Placa de video";
			// 
			// lblplacamae
			// 
			this.lblplacamae.Location = new System.Drawing.Point(191, 170);
			this.lblplacamae.Name = "lblplacamae";
			this.lblplacamae.Size = new System.Drawing.Size(100, 23);
			this.lblplacamae.TabIndex = 17;
			this.lblplacamae.Text = "Placa Mae";
			// 
			// lblgabinete
			// 
			this.lblgabinete.Location = new System.Drawing.Point(372, 170);
			this.lblgabinete.Name = "lblgabinete";
			this.lblgabinete.Size = new System.Drawing.Size(100, 23);
			this.lblgabinete.TabIndex = 18;
			this.lblgabinete.Text = "Gabinete";
			// 
			// lblopcionais
			// 
			this.lblopcionais.Location = new System.Drawing.Point(372, 251);
			this.lblopcionais.Name = "lblopcionais";
			this.lblopcionais.Size = new System.Drawing.Size(100, 23);
			this.lblopcionais.TabIndex = 19;
			this.lblopcionais.Text = "Opcionais";
			// 
			// btnCarregarRecomendacao
			// 
			this.btnCarregarRecomendacao.BackColor = System.Drawing.Color.Yellow;
			this.btnCarregarRecomendacao.Location = new System.Drawing.Point(182, 108);
			this.btnCarregarRecomendacao.Name = "btnCarregarRecomendacao";
			this.btnCarregarRecomendacao.Size = new System.Drawing.Size(142, 44);
			this.btnCarregarRecomendacao.TabIndex = 21;
			this.btnCarregarRecomendacao.Text = "Recomendaçao";
			this.btnCarregarRecomendacao.UseVisualStyleBackColor = false;
			this.btnCarregarRecomendacao.Click += new System.EventHandler(this.BtnCarregarRecomendacaoClick);
			// 
			// btnCalcular
			// 
			this.btnCalcular.BackColor = System.Drawing.Color.LawnGreen;
			this.btnCalcular.Location = new System.Drawing.Point(418, 378);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(84, 43);
			this.btnCalcular.TabIndex = 22;
			this.btnCalcular.Text = "Calcular";
			this.btnCalcular.UseVisualStyleBackColor = false;
			this.btnCalcular.Click += new System.EventHandler(this.BtnCalcularClick);
			// 
			// btnLimpar
			// 
			this.btnLimpar.BackColor = System.Drawing.SystemColors.Info;
			this.btnLimpar.Location = new System.Drawing.Point(526, 378);
			this.btnLimpar.Name = "btnLimpar";
			this.btnLimpar.Size = new System.Drawing.Size(75, 43);
			this.btnLimpar.TabIndex = 23;
			this.btnLimpar.Text = "Limpar";
			this.btnLimpar.UseVisualStyleBackColor = false;
			this.btnLimpar.Click += new System.EventHandler(this.BtnLimparClick);
			// 
			// btnSair
			// 
			this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.btnSair.Location = new System.Drawing.Point(506, 22);
			this.btnSair.Name = "btnSair";
			this.btnSair.Size = new System.Drawing.Size(84, 43);
			this.btnSair.TabIndex = 24;
			this.btnSair.Text = "Sair";
			this.btnSair.UseVisualStyleBackColor = false;
			this.btnSair.Click += new System.EventHandler(this.BtnSairClick);
			// 
			// chkMonitor
			// 
			this.chkMonitor.Location = new System.Drawing.Point(372, 274);
			this.chkMonitor.Name = "chkMonitor";
			this.chkMonitor.Size = new System.Drawing.Size(104, 24);
			this.chkMonitor.TabIndex = 25;
			this.chkMonitor.Text = "Monitor";
			this.chkMonitor.UseVisualStyleBackColor = true;
			// 
			// chktecladomouse
			// 
			this.chktecladomouse.Location = new System.Drawing.Point(372, 300);
			this.chktecladomouse.Name = "chktecladomouse";
			this.chktecladomouse.Size = new System.Drawing.Size(218, 24);
			this.chktecladomouse.TabIndex = 26;
			this.chktecladomouse.Text = "Kit teclado e mouse";
			this.chktecladomouse.UseVisualStyleBackColor = true;
			// 
			// chkheadset
			// 
			this.chkheadset.Location = new System.Drawing.Point(372, 330);
			this.chkheadset.Name = "chkheadset";
			this.chkheadset.Size = new System.Drawing.Size(121, 24);
			this.chkheadset.TabIndex = 27;
			this.chkheadset.Text = "Headset";
			this.chkheadset.UseVisualStyleBackColor = true;
			// 
			// txtdesconto
			// 
			this.txtdesconto.Location = new System.Drawing.Point(372, 126);
			this.txtdesconto.Name = "txtdesconto";
			this.txtdesconto.Size = new System.Drawing.Size(100, 26);
			this.txtdesconto.TabIndex = 28;
			// 
			// txttaxa
			// 
			this.txttaxa.Location = new System.Drawing.Point(372, 59);
			this.txttaxa.Name = "txttaxa";
			this.txttaxa.Size = new System.Drawing.Size(100, 26);
			this.txttaxa.TabIndex = 29;
			// 
			// lbltaxa
			// 
			this.lbltaxa.Location = new System.Drawing.Point(372, 9);
			this.lbltaxa.Name = "lbltaxa";
			this.lbltaxa.Size = new System.Drawing.Size(104, 47);
			this.lbltaxa.TabIndex = 30;
			this.lbltaxa.Text = "Taxa de montagem";
			// 
			// lbldesconto
			// 
			this.lbldesconto.Location = new System.Drawing.Point(372, 108);
			this.lbldesconto.Name = "lbldesconto";
			this.lbldesconto.Size = new System.Drawing.Size(100, 23);
			this.lbldesconto.TabIndex = 31;
			this.lbldesconto.Text = "Desconto";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDark;
			this.ClientSize = new System.Drawing.Size(613, 447);
			this.Controls.Add(this.lbldesconto);
			this.Controls.Add(this.lbltaxa);
			this.Controls.Add(this.txttaxa);
			this.Controls.Add(this.txtdesconto);
			this.Controls.Add(this.chkheadset);
			this.Controls.Add(this.chktecladomouse);
			this.Controls.Add(this.chkMonitor);
			this.Controls.Add(this.btnSair);
			this.Controls.Add(this.btnLimpar);
			this.Controls.Add(this.btnCalcular);
			this.Controls.Add(this.btnCarregarRecomendacao);
			this.Controls.Add(this.lblopcionais);
			this.Controls.Add(this.lblgabinete);
			this.Controls.Add(this.lblplacamae);
			this.Controls.Add(this.lblplacadevideo);
			this.Controls.Add(this.lblssd);
			this.Controls.Add(this.lblfonte);
			this.Controls.Add(this.lblProcessador);
			this.Controls.Add(this.cbogabinete);
			this.Controls.Add(this.cbossd);
			this.Controls.Add(this.cbomemoria);
			this.Controls.Add(this.cbofonte);
			this.Controls.Add(this.cboplacamae);
			this.Controls.Add(this.cboplacadevideo);
			this.Controls.Add(this.cboprocessador);
			this.Controls.Add(this.txtNome);
			this.Controls.Add(this.lblcliente);
			this.Controls.Add(this.cboperfil);
			this.Controls.Add(this.lblperfil);
			this.Controls.Add(this.lblmemoria);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Margin = new System.Windows.Forms.Padding(5);
			this.Name = "MainForm";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Orçamentodepc";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
