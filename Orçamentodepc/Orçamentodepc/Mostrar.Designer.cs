/*
 * Created by SharpDevelop.
 * User: aluno_iot
 * Date: 14/07/2026
 * Time: 09:13
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Orçamentodepc
{
	partial class Mostrar
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lblsubtotal;
		private System.Windows.Forms.Label lblsituaçaoconfiguraçao;
		private System.Windows.Forms.Label lbltotal;
		private System.Windows.Forms.Label lblvalormontagem;
		private System.Windows.Forms.Label lblvalordesconto;
		private System.Windows.Forms.Button bntSairfinal;
		private System.Windows.Forms.Label lblperfil2;
		public System.Windows.Forms.Label lblcliente2;
		private System.Windows.Forms.Label lblmensagem;
		
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
			this.lblsubtotal = new System.Windows.Forms.Label();
			this.lblsituaçaoconfiguraçao = new System.Windows.Forms.Label();
			this.lbltotal = new System.Windows.Forms.Label();
			this.lblvalormontagem = new System.Windows.Forms.Label();
			this.lblvalordesconto = new System.Windows.Forms.Label();
			this.bntSairfinal = new System.Windows.Forms.Button();
			this.lblperfil2 = new System.Windows.Forms.Label();
			this.lblcliente2 = new System.Windows.Forms.Label();
			this.lblmensagem = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblsubtotal
			// 
			this.lblsubtotal.AutoSize = true;
			this.lblsubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblsubtotal.Location = new System.Drawing.Point(22, 59);
			this.lblsubtotal.Name = "lblsubtotal";
			this.lblsubtotal.Size = new System.Drawing.Size(77, 20);
			this.lblsubtotal.TabIndex = 0;
			this.lblsubtotal.Text = "Subtotal";
			// 
			// lblsituaçaoconfiguraçao
			// 
			this.lblsituaçaoconfiguraçao.AutoSize = true;
			this.lblsituaçaoconfiguraçao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblsituaçaoconfiguraçao.Location = new System.Drawing.Point(22, 190);
			this.lblsituaçaoconfiguraçao.Name = "lblsituaçaoconfiguraçao";
			this.lblsituaçaoconfiguraçao.Size = new System.Drawing.Size(189, 20);
			this.lblsituaçaoconfiguraçao.TabIndex = 1;
			this.lblsituaçaoconfiguraçao.Text = "Situaçao configuraçao";
			// 
			// lbltotal
			// 
			this.lbltotal.AutoSize = true;
			this.lbltotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbltotal.ForeColor = System.Drawing.Color.GreenYellow;
			this.lbltotal.Location = new System.Drawing.Point(22, 160);
			this.lbltotal.Name = "lbltotal";
			this.lbltotal.Size = new System.Drawing.Size(49, 20);
			this.lbltotal.TabIndex = 2;
			this.lbltotal.Text = "Total";
			// 
			// lblvalormontagem
			// 
			this.lblvalormontagem.AutoSize = true;
			this.lblvalormontagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblvalormontagem.Location = new System.Drawing.Point(22, 91);
			this.lblvalormontagem.Name = "lblvalormontagem";
			this.lblvalormontagem.Size = new System.Drawing.Size(135, 20);
			this.lblvalormontagem.TabIndex = 3;
			this.lblvalormontagem.Text = "ValorMontagem";
			// 
			// lblvalordesconto
			// 
			this.lblvalordesconto.AutoSize = true;
			this.lblvalordesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblvalordesconto.Location = new System.Drawing.Point(22, 124);
			this.lblvalordesconto.Name = "lblvalordesconto";
			this.lblvalordesconto.Size = new System.Drawing.Size(128, 20);
			this.lblvalordesconto.TabIndex = 4;
			this.lblvalordesconto.Text = "ValorDesconto";
			// 
			// bntSairfinal
			// 
			this.bntSairfinal.BackColor = System.Drawing.Color.Red;
			this.bntSairfinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bntSairfinal.Location = new System.Drawing.Point(355, 258);
			this.bntSairfinal.Name = "bntSairfinal";
			this.bntSairfinal.Size = new System.Drawing.Size(79, 50);
			this.bntSairfinal.TabIndex = 7;
			this.bntSairfinal.Text = "Sair";
			this.bntSairfinal.UseVisualStyleBackColor = false;
			this.bntSairfinal.Click += new System.EventHandler(this.BntSairfinalClick);
			// 
			// lblperfil2
			// 
			this.lblperfil2.AutoSize = true;
			this.lblperfil2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblperfil2.Location = new System.Drawing.Point(22, 36);
			this.lblperfil2.Name = "lblperfil2";
			this.lblperfil2.Size = new System.Drawing.Size(0, 16);
			this.lblperfil2.TabIndex = 8;
			// 
			// lblcliente2
			// 
			this.lblcliente2.AutoSize = true;
			this.lblcliente2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblcliente2.Location = new System.Drawing.Point(22, 13);
			this.lblcliente2.Name = "lblcliente2";
			this.lblcliente2.Size = new System.Drawing.Size(0, 16);
			this.lblcliente2.TabIndex = 9;
			// 
			// lblmensagem
			// 
			this.lblmensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblmensagem.ForeColor = System.Drawing.Color.Gold;
			this.lblmensagem.Location = new System.Drawing.Point(12, 210);
			this.lblmensagem.Name = "lblmensagem";
			this.lblmensagem.Size = new System.Drawing.Size(337, 110);
			this.lblmensagem.TabIndex = 12;
			this.lblmensagem.Text = "Mensagem";
			// 
			// Mostrar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonShadow;
			this.ClientSize = new System.Drawing.Size(459, 329);
			this.Controls.Add(this.lblmensagem);
			this.Controls.Add(this.lblcliente2);
			this.Controls.Add(this.lblperfil2);
			this.Controls.Add(this.bntSairfinal);
			this.Controls.Add(this.lblvalordesconto);
			this.Controls.Add(this.lblvalormontagem);
			this.Controls.Add(this.lbltotal);
			this.Controls.Add(this.lblsituaçaoconfiguraçao);
			this.Controls.Add(this.lblsubtotal);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "Mostrar";
			this.ShowIcon = false;
			this.Text = "Mostrar";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
