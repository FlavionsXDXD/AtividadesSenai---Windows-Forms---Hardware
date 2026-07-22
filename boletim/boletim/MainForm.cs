using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace boletim
{

	public partial class MainForm : Form
	{
		
		private List<Estudante> listaEstudantes = new List<Estudante>();

		
		private Estudante estudanteCalculado = null;

		
		private int aprovados = 0;
		private int recuperacao = 0;
		private int reprovados = 0;
		private int reprovadosNota = 0;
		private int reprovadosFrequencia = 0;

		public MainForm()
		{
			
			InitializeComponent();
			
			
		}
		private void LimparCampos()
		{
			txtAluno.Clear();
			txtTurma.Clear();
			txtNota1.Clear();
			txtNota2.Clear();
			txtNota3.Clear();
			txtNota4.Clear();
			nudFrequencia.Value = 0;
			
			lblMedia.Text = "Média: -";
			lblSituacao.Text = "Situação: -";
			
			txtAluno.Focus();
		}
		void BtnAdicionarResultadoClick(object sender, EventArgs e)
		{
			
			
			if (estudanteCalculado == null)
			{
				MessageBox.Show("Por favor, clique em Calcular antes de adicionar!");
				return;
			}

			
			listaEstudantes.Add(estudanteCalculado);
			lstResultados.Items.Add(estudanteCalculado);

			
			string situacao = estudanteCalculado.ObterSituacao();
			if (situacao == "Aprovado")
			{
				aprovados++;
			}
			
			else if (situacao == "Recuperação")
			{
				recuperacao++;
			}
			
			else if (situacao == "Reprovado por Nota")
			{
				reprovadosNota++;
			}
			else if (situacao == "Reprovado por Faltas")
			{
				reprovadosFrequencia++;
			}

			
			lblQuantidade.Text = "Total de Estudantes: " + listaEstudantes.Count;

			
			LimparCampos();

			
			estudanteCalculado = null;
			
			
		}
		void BtnCalcularClick(object sender, EventArgs e)
		{
			
			
			if (string.IsNullOrWhiteSpace(txtAluno.Text) || string.IsNullOrWhiteSpace(txtTurma.Text))
			{
				
				MessageBox.Show("Por favor, preencha o Nome e a Turma do estudante antes de calcular!",
				                "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				
				return;
			}
			
			if (string.IsNullOrWhiteSpace(txtNota1.Text) ||
			    string.IsNullOrWhiteSpace(txtNota2.Text) ||
			    string.IsNullOrWhiteSpace(txtNota3.Text) ||
			    string.IsNullOrWhiteSpace(txtNota4.Text))
			{
				MessageBox.Show("Por favor, preencha todas as 4 notas do estudante antes de calcular!",
				                "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return; 
			}
			string nome = txtAluno.Text;
			string turma =txtTurma.Text;
			
			
			double n1 = Convert.ToDouble(txtNota1.Text);
			double n2 =Convert.ToDouble(txtNota2.Text);
			double n3 = Convert.ToDouble(txtNota3.Text);
			double n4 = Convert.ToDouble(txtNota4.Text);
			double freq = (double)nudFrequencia.Value;
			
			estudanteCalculado = new Estudante(nome, turma, n1, n2, n3, n4, freq);
			
			lblMedia.Text = "Média: " + estudanteCalculado.CalcularMedia().ToString("F1");
			lblSituacao.Text = "Situação: " + estudanteCalculado.ObterSituacao();
		}
		void BtnLimparCamposClick(object sender, EventArgs e)
		{
			LimparCampos();
		}
		void BtnRemoverSelecionadoClick(object sender, EventArgs e)
		{
			if(lstResultados.SelectedIndex == -1)
			{
				MessageBox.Show("Selecione um estudante na lista para remover");
				return;
			}
			int indiceSelecionado = lstResultados.SelectedIndex;
			Estudante alunoParaRemover = (Estudante)lstResultados.Items[indiceSelecionado];
			
			
			string situacao = alunoParaRemover.ObterSituacao();
			if (situacao == "Aprovado")
			{
				aprovados--;
			}
			
			else if (situacao == "Recuperaçao")
			{
				recuperacao--;
			}
			else if (situacao == "Reprovado por Nota")
			{
				reprovadosNota--;
			}
			else if (situacao == "Reprovado por Faltas")
			{
				reprovadosFrequencia--;
			}
			
			listaEstudantes.RemoveAt(indiceSelecionado);
			lstResultados.Items.RemoveAt(indiceSelecionado);
			
			lblQuantidade.Text = "Total de Estudantes: "+listaEstudantes.Count;
			
			BtnGerarResumoClick(sender, e);
			
			
			
			
			
			
			
		}
		void BtnGerarResumoClick(object sender, EventArgs e)
		{
			string resumo = "=== Resumo ==="+ Environment.NewLine;
			resumo += "Total de alunos: " + listaEstudantes.Count + Environment.NewLine;
			resumo += "----------------------------------"+ Environment.NewLine;
			resumo +="Aprovados: "+aprovados+Environment.NewLine;
			resumo +="Em Recuperaçao: "+recuperacao+Environment.NewLine;
			resumo += "Reprovados por nota: " + reprovadosNota + Environment.NewLine;
			resumo += "Reprovados por frequência: " + reprovadosFrequencia;
			
			txtResumoTurma.Text =resumo;
		}
		void BtnLimparListaClick(object sender, EventArgs e)
		{
			listaEstudantes.Clear();
			lstResultados.Items.Clear();
			
			aprovados = 0;
			recuperacao = 0;
			reprovadosNota = 0;
			reprovadosFrequencia = 0;
			
			lblQuantidade.Text = "Total de estudantes: 0";
			txtResumoTurma.Clear();
			
			LimparCampos();
			
			MessageBox.Show("Lista foi Apagada");
		}
		void TxtAlunoKeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
			{
				
				e.Handled = true;
			}
		}
		
		private void ValidarApenasNumerosEVirgula(object sender, KeyPressEventArgs e)
		{
			
			if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',')
			{
				e.Handled = true;
			}

			
			TextBox txt = (TextBox)sender;
			if (e.KeyChar == ',' && txt.Text.Contains(","))
			{
				e.Handled = true;
			}
		}
		


	}
}
