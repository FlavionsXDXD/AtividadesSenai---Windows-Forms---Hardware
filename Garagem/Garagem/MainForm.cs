using System;
using System.Collections.Generic;
using System.Drawing;
using System.ComponentModel;
using System.Windows.Forms;
using System.Linq;

namespace Garagem
{

	public partial class MainForm : Form
	{
		private BindingList<Estacionado> listaEstacionados = new BindingList<Estacionado>();
		
		private double faturamentoTotal = 0.0;
		
		public MainForm()
		{
			
			InitializeComponent();
			
			dgvVeiculos.DataSource = listaEstacionados;
			
			dgvVeiculos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			
			AtualizarIndicadores();
			
			cboTipoVeiculo.Items.Clear();
			cboTipoVeiculo.Items.Add("Carro");
			cboTipoVeiculo.Items.Add("Moto");
			cboTipoVeiculo.Items.Add("Carga");
			
			cboTipoVeiculo.SelectedIndex = -1;
			
			AtualizarIndicadores();
		}
		private void AtualizarIndicadores()
		{
			int estacionados = listaEstacionados.Count(p => p.Status == "Estacionado");
			
			int finalizados = listaEstacionados.Count(p => p.Status == "Finalizado");
			
			lblEstacionados.Text = "Estacionados: "+estacionados;
			lblFinalizados.Text = "Finalizados: "+finalizados;
			lblTotalRecebido.Text= "Total Recebido: R$"+faturamentoTotal.ToString("F2");
		}
		void BtnRegistrarEntradaClick(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtPlaca.Text) ||(cboTipoVeiculo.SelectedIndex == -1) || string.IsNullOrWhiteSpace(txtModelo.Text))
			{
				MessageBox.Show("Preencha a Placa e o Modelo do veiculo para registrar a entrada",
				                "Atençao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			string placaDigitada = txtPlaca.Text.ToUpper().Trim();
			
			bool jaEstacionado = listaEstacionados.Any(p => p.Placa == placaDigitada && p.Status == "Estacionado");
			
			if(jaEstacionado)
			{
				MessageBox.Show("Veiculo ja esta dentro do estacionamento com entrada aberta",
				                "Bloqueada", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			
			string modelo = txtModelo.Text;
			string tipo = cboTipoVeiculo.Text;
			
			if(string.IsNullOrWhiteSpace(tipo))
			{
				tipo = "Carro";
			}
			DateTime horarioEntrada = dtpEntrada.Value;
			
			Estacionado novaEstacionado = new Estacionado(placaDigitada, modelo, tipo, horarioEntrada);
			
			listaEstacionados.Add(novaEstacionado);
			dgvVeiculos.DataSource = null;
			dgvVeiculos.DataSource = listaEstacionados;
			
			AtualizarIndicadores();
			LimparCamposEntrada();
			MessageBox.Show("Entrada do veiculo registrada","Sucesso",MessageBoxButtons.OK, MessageBoxIcon.Information);
			
		}
		private void LimparCamposEntrada()
		{
			txtPlaca.Clear();
			txtModelo.Clear();
			cboTipoVeiculo.SelectedIndex = -1;
			dtpEntrada.Value = DateTime.Now;
			txtPlaca.Focus();
			
		}
		void BtnLimparClick(object sender, EventArgs e)
		{
			DialogResult resposta = MessageBox.Show("deseja apagar todos registros?",
			                                       "Confirmar Reset",
			                                      MessageBoxButtons.YesNo,
			                                      MessageBoxIcon.Warning);
			if(resposta == DialogResult.No)
			{
				return;
			}
			listaEstacionados.Clear();
			
			faturamentoTotal = 0.0;
			
			LimparCamposEntrada();
			txtPesquisarPlaca.Clear();
			
			AtualizarIndicadores();
			
			MessageBox.Show("O sistema foi resetado","Limpar Sistema",MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
		void BtnRegistrarSaidaClick(object sender, EventArgs e)
		{
			if(dgvVeiculos.CurrentRow == null)
			{
				MessageBox.Show("Selecione um veiculo para registrar saida","Atençao",MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			Estacionado veiculoSelecionado = (Estacionado)dgvVeiculos.CurrentRow.DataBoundItem;
			
			if(veiculoSelecionado.Status == "Finalizado")
			{
				MessageBox.Show("veiculo ja teve saida registrada","Aviso",MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			DateTime horarioSaida = dtpSaida.Value;
			if(horarioSaida < veiculoSelecionado.HorarioEntrada)
			{
				MessageBox.Show("Horario de saida nao pode ser anterior ao horario de entrada","Error de Data/Hora"
				                ,MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			veiculoSelecionado.RegistrarSaida(horarioSaida);
			
			faturamentoTotal += veiculoSelecionado.ValorPago;
			
			listaEstacionados.ResetBindings();
			
			AtualizarIndicadores();
			
			int horasCobradas = veiculoSelecionado.CalcularHorasCobradas(horarioSaida);
			MessageBox.Show(string.Format("Saida Registrada\nznPlaca: {0}\nTempo Cobrado: {1} hora(s)\nValor Total: R$ {2:F2}"
			                              ,veiculoSelecionado.Placa, horasCobradas, veiculoSelecionado.ValorPago),
			                              "Recibo de Saida", MessageBoxButtons.OK, MessageBoxIcon.Information);
			
		}
		void BtnPesquisarClick(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtPesquisarPlaca.Text))
			{
				MessageBox.Show("Digite uma placa para pesquisar","Atençao",
				                MessageBoxButtons.OK,MessageBoxIcon.Warning);
				return;
			}
			string placaBusca = txtPesquisarPlaca.Text.ToUpper().Trim();
			
			var resultadoFiltro = listaEstacionados.Where(p => p.Placa.Contains(placaBusca)).ToList();
			
			if(resultadoFiltro.Count == 0)
			{
				MessageBox.Show("Nenhum veiculo encontrado com essa placa","Sem resultado",
				                MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			dgvVeiculos.DataSource = null;
			dgvVeiculos.DataSource = resultadoFiltro;
		}
		void BtnMostrarTodosClick(object sender, EventArgs e)
		{
			txtPesquisarPlaca.Clear();
			
			dgvVeiculos.DataSource = null;
			dgvVeiculos.DataSource = listaEstacionados;
		}
		void BtnRemoverClick(object sender, EventArgs e)
		{
			if(dgvVeiculos.CurrentRow == null)
			{
				MessageBox.Show("selecione um registro na tabela para remover",
				                "Atençao",MessageBoxButtons.OK,MessageBoxIcon.Warning);
				return;
			}
			Estacionado veiculoParaRemover = (Estacionado)dgvVeiculos.CurrentRow.DataBoundItem;
			
			DialogResult resposta = MessageBox.Show(string.Format("deseja remover o registro do veiculo de placa {0}?",
			                                                     veiculoParaRemover.Placa),"Confirmar exclusao",
			                                                     MessageBoxButtons.YesNo,MessageBoxIcon.Question);
			if(resposta == DialogResult.No)
			{
				return;
			}
			if(veiculoParaRemover.Status == "Finalizado")
			{
				faturamentoTotal -= veiculoParaRemover.ValorPago;
			}
			listaEstacionados.Remove(veiculoParaRemover);
			
			AtualizarIndicadores();
			
			MessageBox.Show("Registro removido com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
		void BtnEncerrarClick(object sender, EventArgs e)
		{
			DialogResult sair = MessageBox.Show("Deseja Sair?","Sair",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			
			if(sair == DialogResult.Yes)
			{
				Application.Exit();
			}
		}
		
		
	}
}
