/*
 * Created by SharpDevelop.
 * User: Flavio
 * Date: 17/07/2026
 * Time: 11:39
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace boletim
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lblAluno;
		private System.Windows.Forms.Label lblTurma;
		private System.Windows.Forms.Label lblNota;
		private System.Windows.Forms.Label lblNota2;
		private System.Windows.Forms.Label lblNota3;
		private System.Windows.Forms.Label lblNota4;
		private System.Windows.Forms.TextBox txtAluno;
		private System.Windows.Forms.TextBox txtTurma;
		private System.Windows.Forms.TextBox txtNota1;
		private System.Windows.Forms.TextBox txtNota3;
		private System.Windows.Forms.TextBox txtNota4;
		private System.Windows.Forms.NumericUpDown nudFrequencia;
		private System.Windows.Forms.Label lblFrequencia;
		private System.Windows.Forms.GroupBox gbResultados;
		private System.Windows.Forms.ListBox lstResultados;
		private System.Windows.Forms.Label lblQuantidade;
		private System.Windows.Forms.Label lblSituacao;
		private System.Windows.Forms.Label lblMedia;
		private System.Windows.Forms.Button btnCalcular;
		private System.Windows.Forms.Button btnAdicionarResultado;
		private System.Windows.Forms.Button btnRemoverSelecionado;
		private System.Windows.Forms.Button btnGerarResumo;
		private System.Windows.Forms.Button btnLimparLista;
		private System.Windows.Forms.Button btnLimparCampos;
		private System.Windows.Forms.TextBox txtResumoTurma;
		private System.Windows.Forms.TextBox txtNota2;
	
		
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
			this.lblAluno = new System.Windows.Forms.Label();
			this.lblTurma = new System.Windows.Forms.Label();
			this.lblNota = new System.Windows.Forms.Label();
			this.lblNota2 = new System.Windows.Forms.Label();
			this.lblNota3 = new System.Windows.Forms.Label();
			this.lblNota4 = new System.Windows.Forms.Label();
			this.txtAluno = new System.Windows.Forms.TextBox();
			this.txtTurma = new System.Windows.Forms.TextBox();
			this.txtNota1 = new System.Windows.Forms.TextBox();
			this.txtNota3 = new System.Windows.Forms.TextBox();
			this.txtNota4 = new System.Windows.Forms.TextBox();
			this.nudFrequencia = new System.Windows.Forms.NumericUpDown();
			this.lblFrequencia = new System.Windows.Forms.Label();
			this.gbResultados = new System.Windows.Forms.GroupBox();
			this.lstResultados = new System.Windows.Forms.ListBox();
			this.lblQuantidade = new System.Windows.Forms.Label();
			this.lblSituacao = new System.Windows.Forms.Label();
			this.lblMedia = new System.Windows.Forms.Label();
			this.btnCalcular = new System.Windows.Forms.Button();
			this.btnAdicionarResultado = new System.Windows.Forms.Button();
			this.btnRemoverSelecionado = new System.Windows.Forms.Button();
			this.btnGerarResumo = new System.Windows.Forms.Button();
			this.btnLimparLista = new System.Windows.Forms.Button();
			this.btnLimparCampos = new System.Windows.Forms.Button();
			this.txtResumoTurma = new System.Windows.Forms.TextBox();
			this.txtNota2 = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.nudFrequencia)).BeginInit();
			this.gbResultados.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblAluno
			// 
			this.lblAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAluno.Location = new System.Drawing.Point(41, 24);
			this.lblAluno.Name = "lblAluno";
			this.lblAluno.Size = new System.Drawing.Size(100, 23);
			this.lblAluno.TabIndex = 0;
			this.lblAluno.Text = "Aluno";
			// 
			// lblTurma
			// 
			this.lblTurma.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTurma.Location = new System.Drawing.Point(179, 24);
			this.lblTurma.Name = "lblTurma";
			this.lblTurma.Size = new System.Drawing.Size(100, 23);
			this.lblTurma.TabIndex = 1;
			this.lblTurma.Text = "Turma";
			// 
			// lblNota
			// 
			this.lblNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNota.Location = new System.Drawing.Point(41, 328);
			this.lblNota.Name = "lblNota";
			this.lblNota.Size = new System.Drawing.Size(100, 23);
			this.lblNota.TabIndex = 2;
			this.lblNota.Text = "Nota 1:";
			// 
			// lblNota2
			// 
			this.lblNota2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNota2.Location = new System.Drawing.Point(41, 388);
			this.lblNota2.Name = "lblNota2";
			this.lblNota2.Size = new System.Drawing.Size(100, 23);
			this.lblNota2.TabIndex = 3;
			this.lblNota2.Text = "Nota 2:";
			// 
			// lblNota3
			// 
			this.lblNota3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNota3.Location = new System.Drawing.Point(41, 448);
			this.lblNota3.Name = "lblNota3";
			this.lblNota3.Size = new System.Drawing.Size(100, 23);
			this.lblNota3.TabIndex = 4;
			this.lblNota3.Text = "Nota 3:";
			// 
			// lblNota4
			// 
			this.lblNota4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNota4.Location = new System.Drawing.Point(41, 502);
			this.lblNota4.Name = "lblNota4";
			this.lblNota4.Size = new System.Drawing.Size(100, 23);
			this.lblNota4.TabIndex = 5;
			this.lblNota4.Text = "Nota 4:";
			// 
			// txtAluno
			// 
			this.txtAluno.Location = new System.Drawing.Point(41, 64);
			this.txtAluno.Name = "txtAluno";
			this.txtAluno.Size = new System.Drawing.Size(100, 20);
			this.txtAluno.TabIndex = 6;
			this.txtAluno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtAlunoKeyPress);
			// 
			// txtTurma
			// 
			this.txtTurma.Location = new System.Drawing.Point(179, 64);
			this.txtTurma.Name = "txtTurma";
			this.txtTurma.Size = new System.Drawing.Size(100, 20);
			this.txtTurma.TabIndex = 7;
			// 
			// txtNota1
			// 
			this.txtNota1.Location = new System.Drawing.Point(147, 331);
			this.txtNota1.Name = "txtNota1";
			this.txtNota1.Size = new System.Drawing.Size(100, 20);
			this.txtNota1.TabIndex = 8;
			this.txtNota1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidarApenasNumerosEVirgula);
			// 
			// txtNota3
			// 
			this.txtNota3.Location = new System.Drawing.Point(147, 451);
			this.txtNota3.Name = "txtNota3";
			this.txtNota3.Size = new System.Drawing.Size(100, 20);
			this.txtNota3.TabIndex = 10;
			this.txtNota3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidarApenasNumerosEVirgula);
			// 
			// txtNota4
			// 
			this.txtNota4.Location = new System.Drawing.Point(147, 508);
			this.txtNota4.Name = "txtNota4";
			this.txtNota4.Size = new System.Drawing.Size(100, 20);
			this.txtNota4.TabIndex = 11;
			this.txtNota4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidarApenasNumerosEVirgula);
			// 
			// nudFrequencia
			// 
			this.nudFrequencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nudFrequencia.Location = new System.Drawing.Point(529, 50);
			this.nudFrequencia.Name = "nudFrequencia";
			this.nudFrequencia.Size = new System.Drawing.Size(120, 31);
			this.nudFrequencia.TabIndex = 12;
			// 
			// lblFrequencia
			// 
			this.lblFrequencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFrequencia.Location = new System.Drawing.Point(523, 20);
			this.lblFrequencia.Name = "lblFrequencia";
			this.lblFrequencia.Size = new System.Drawing.Size(138, 23);
			this.lblFrequencia.TabIndex = 13;
			this.lblFrequencia.Text = "Frequencia";
			// 
			// gbResultados
			// 
			this.gbResultados.Controls.Add(this.lstResultados);
			this.gbResultados.Controls.Add(this.lblQuantidade);
			this.gbResultados.Controls.Add(this.lblSituacao);
			this.gbResultados.Controls.Add(this.lblMedia);
			this.gbResultados.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbResultados.Location = new System.Drawing.Point(270, 139);
			this.gbResultados.Name = "gbResultados";
			this.gbResultados.Size = new System.Drawing.Size(483, 327);
			this.gbResultados.TabIndex = 14;
			this.gbResultados.TabStop = false;
			this.gbResultados.Text = "Resultados";
			// 
			// lstResultados
			// 
			this.lstResultados.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.lstResultados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lstResultados.FormattingEnabled = true;
			this.lstResultados.Location = new System.Drawing.Point(15, 148);
			this.lstResultados.Name = "lstResultados";
			this.lstResultados.Size = new System.Drawing.Size(455, 160);
			this.lstResultados.TabIndex = 19;
			// 
			// lblQuantidade
			// 
			this.lblQuantidade.AutoSize = true;
			this.lblQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblQuantidade.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblQuantidade.Location = new System.Drawing.Point(30, 107);
			this.lblQuantidade.Name = "lblQuantidade";
			this.lblQuantidade.Size = new System.Drawing.Size(133, 25);
			this.lblQuantidade.TabIndex = 17;
			this.lblQuantidade.Text = "Quantidade";
			// 
			// lblSituacao
			// 
			this.lblSituacao.AutoSize = true;
			this.lblSituacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSituacao.ForeColor = System.Drawing.Color.Chocolate;
			this.lblSituacao.Location = new System.Drawing.Point(30, 82);
			this.lblSituacao.Name = "lblSituacao";
			this.lblSituacao.Size = new System.Drawing.Size(104, 25);
			this.lblSituacao.TabIndex = 16;
			this.lblSituacao.Text = "Situaçao";
			// 
			// lblMedia
			// 
			this.lblMedia.AutoSize = true;
			this.lblMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMedia.ForeColor = System.Drawing.Color.OrangeRed;
			this.lblMedia.Location = new System.Drawing.Point(30, 57);
			this.lblMedia.Name = "lblMedia";
			this.lblMedia.Size = new System.Drawing.Size(90, 25);
			this.lblMedia.TabIndex = 15;
			this.lblMedia.Text = "Media: ";
			// 
			// btnCalcular
			// 
			this.btnCalcular.BackColor = System.Drawing.Color.Orange;
			this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCalcular.Location = new System.Drawing.Point(270, 491);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(98, 52);
			this.btnCalcular.TabIndex = 15;
			this.btnCalcular.Text = "Calcular";
			this.btnCalcular.UseVisualStyleBackColor = false;
			this.btnCalcular.Click += new System.EventHandler(this.BtnCalcularClick);
			// 
			// btnAdicionarResultado
			// 
			this.btnAdicionarResultado.BackColor = System.Drawing.Color.OliveDrab;
			this.btnAdicionarResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAdicionarResultado.Location = new System.Drawing.Point(395, 491);
			this.btnAdicionarResultado.Name = "btnAdicionarResultado";
			this.btnAdicionarResultado.Size = new System.Drawing.Size(98, 52);
			this.btnAdicionarResultado.TabIndex = 16;
			this.btnAdicionarResultado.Text = "Adicionar resultado";
			this.btnAdicionarResultado.UseVisualStyleBackColor = false;
			this.btnAdicionarResultado.Click += new System.EventHandler(this.BtnAdicionarResultadoClick);
			// 
			// btnRemoverSelecionado
			// 
			this.btnRemoverSelecionado.BackColor = System.Drawing.Color.Brown;
			this.btnRemoverSelecionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRemoverSelecionado.Location = new System.Drawing.Point(514, 491);
			this.btnRemoverSelecionado.Name = "btnRemoverSelecionado";
			this.btnRemoverSelecionado.Size = new System.Drawing.Size(106, 52);
			this.btnRemoverSelecionado.TabIndex = 17;
			this.btnRemoverSelecionado.Text = "Remover selecionado";
			this.btnRemoverSelecionado.UseVisualStyleBackColor = false;
			this.btnRemoverSelecionado.Click += new System.EventHandler(this.BtnRemoverSelecionadoClick);
			// 
			// btnGerarResumo
			// 
			this.btnGerarResumo.BackColor = System.Drawing.Color.DarkOliveGreen;
			this.btnGerarResumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGerarResumo.Location = new System.Drawing.Point(642, 491);
			this.btnGerarResumo.Name = "btnGerarResumo";
			this.btnGerarResumo.Size = new System.Drawing.Size(98, 52);
			this.btnGerarResumo.TabIndex = 18;
			this.btnGerarResumo.Text = "Gerar resumo";
			this.btnGerarResumo.UseVisualStyleBackColor = false;
			this.btnGerarResumo.Click += new System.EventHandler(this.BtnGerarResumoClick);
			// 
			// btnLimparLista
			// 
			this.btnLimparLista.BackColor = System.Drawing.SystemColors.Info;
			this.btnLimparLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLimparLista.Location = new System.Drawing.Point(649, 92);
			this.btnLimparLista.Name = "btnLimparLista";
			this.btnLimparLista.Size = new System.Drawing.Size(98, 52);
			this.btnLimparLista.TabIndex = 19;
			this.btnLimparLista.Text = "Limpar Lista";
			this.btnLimparLista.UseVisualStyleBackColor = false;
			this.btnLimparLista.Click += new System.EventHandler(this.BtnLimparListaClick);
			// 
			// btnLimparCampos
			// 
			this.btnLimparCampos.BackColor = System.Drawing.SystemColors.Info;
			this.btnLimparCampos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLimparCampos.Location = new System.Drawing.Point(503, 92);
			this.btnLimparCampos.Name = "btnLimparCampos";
			this.btnLimparCampos.Size = new System.Drawing.Size(98, 52);
			this.btnLimparCampos.TabIndex = 20;
			this.btnLimparCampos.Text = "Limpar Campos";
			this.btnLimparCampos.UseVisualStyleBackColor = false;
			this.btnLimparCampos.Click += new System.EventHandler(this.BtnLimparCamposClick);
			// 
			// txtResumoTurma
			// 
			this.txtResumoTurma.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.txtResumoTurma.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtResumoTurma.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.txtResumoTurma.Location = new System.Drawing.Point(12, 139);
			this.txtResumoTurma.Multiline = true;
			this.txtResumoTurma.Name = "txtResumoTurma";
			this.txtResumoTurma.Size = new System.Drawing.Size(252, 167);
			this.txtResumoTurma.TabIndex = 21;
			this.txtResumoTurma.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidarApenasNumerosEVirgula);
			// 
			// txtNota2
			// 
			this.txtNota2.Location = new System.Drawing.Point(147, 394);
			this.txtNota2.Name = "txtNota2";
			this.txtNota2.Size = new System.Drawing.Size(100, 20);
			this.txtNota2.TabIndex = 22;
			this.txtNota2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidarApenasNumerosEVirgula);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.ClientSize = new System.Drawing.Size(765, 568);
			this.Controls.Add(this.txtNota2);
			this.Controls.Add(this.txtResumoTurma);
			this.Controls.Add(this.btnLimparCampos);
			this.Controls.Add(this.btnLimparLista);
			this.Controls.Add(this.btnGerarResumo);
			this.Controls.Add(this.btnRemoverSelecionado);
			this.Controls.Add(this.btnAdicionarResultado);
			this.Controls.Add(this.btnCalcular);
			this.Controls.Add(this.gbResultados);
			this.Controls.Add(this.lblFrequencia);
			this.Controls.Add(this.nudFrequencia);
			this.Controls.Add(this.txtNota4);
			this.Controls.Add(this.txtNota3);
			this.Controls.Add(this.txtNota1);
			this.Controls.Add(this.txtTurma);
			this.Controls.Add(this.txtAluno);
			this.Controls.Add(this.lblNota4);
			this.Controls.Add(this.lblNota3);
			this.Controls.Add(this.lblNota2);
			this.Controls.Add(this.lblNota);
			this.Controls.Add(this.lblTurma);
			this.Controls.Add(this.lblAluno);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "MainForm";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "boletim";
			((System.ComponentModel.ISupportInitialize)(this.nudFrequencia)).EndInit();
			this.gbResultados.ResumeLayout(false);
			this.gbResultados.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
