using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaOrcamento
{
	public partial class MainForm : Form
	{
		
		private Orcamento meuOrcamento;
		private PerfilCliente perfilGamer;
		private PerfilCliente perfilAdministrativo;
		private PerfilCliente PerfilProfessorTecnologia;
		private PerfilCliente perfilDesenvolvedorSoftware;
		private PerfilCliente perfilDesenvolvedorJogos;
		
		
		
		
		public MainForm()
		{
			InitializeComponent();
			InicializarRegrasPOO();
			InicializarProcessadores();
			InicializarPlacamae();
			InicializarGabinete();
			InicializarRam();
			InicializarFonte();
			InicializarSSD();
			InicializarPlacavideo();
			
			cboperfil.DropDownStyle = ComboBoxStyle.DropDownList;
			cboprocessador.DropDownStyle = ComboBoxStyle.DropDownList;
			cboplacadevideo.DropDownStyle = ComboBoxStyle.DropDownList;
			cbomemoria.DropDownStyle = ComboBoxStyle.DropDownList;
			cbossd.DropDownStyle = ComboBoxStyle.DropDownList;
			cbofonte.DropDownStyle = ComboBoxStyle.DropDownList;
			cboplacamae.DropDownStyle = ComboBoxStyle.DropDownList;
			cbogabinete.DropDownStyle = ComboBoxStyle.DropDownList;
			
		}
		
		
		private void InicializarRegrasPOO()
		{
			perfilAdministrativo = new PerfilCliente("Administrativo", new List<string> {"minimo", "medio", "avançado", "alto desempenho"});
			perfilGamer = new PerfilCliente("Gamer", new List<string> {"avançado", "alto desempenho"});
			perfilDesenvolvedorSoftware =new PerfilCliente("Desenvolvedor de Software", new List<string>{"avançado", "alto desempenho"});
			PerfilProfessorTecnologia = new PerfilCliente ("Proffesor de Tecnologia", new List<string>{"avançado","medio"});
			perfilDesenvolvedorJogos = new PerfilCliente ("Desenvolvedor de Jogos", new List<string>{"avançado","alto desempenho"});
			
			
			cboperfil.Items.Clear();
			cboperfil.Items.Add("Administrativo");
			cboperfil.Items.Add("Professor de Tecnologia");
			cboperfil.Items.Add("Desenvolvedor de Software");
			cboperfil.Items.Add("Desenvolvedor de Jogos");
			cboperfil.SelectedIndex = 0;
			
			meuOrcamento = new Orcamento(perfilAdministrativo);
		}
		private void InicializarPlacavideo()
		{
			cboplacadevideo.Items.Clear();
			
			cboplacadevideo.Items.Add(new PecaHardware("Vídeo integrado","minimo",0.00m));
			cboplacadevideo.Items.Add(new PecaHardware("Dedicada intermediária 6GB ","medio",510.00m));
			cboplacadevideo.Items.Add(new PecaHardware("Dedicada alto desempenho 12GB","avançado",1555.00m));
			cboplacadevideo.SelectedIndex = 0;
		}
		private void InicializarSSD()
		{
			cbossd.Items.Clear();
			
			cbossd.Items.Add(new PecaHardware("240GB ","minimo",280.00m));
			cbossd.Items.Add(new PecaHardware("480GB ","medio",510.00m));
			cbossd.Items.Add(new PecaHardware("1TB","avançado",945.00m));
			cbossd.SelectedIndex = -1;
		}
		private void InicializarFonte()
		{
			cbofonte.Items.Clear();
			
			cbofonte.Items.Add(new PecaHardware("Fonte 500 W ","minimo",450.00m));
			cbofonte.Items.Add(new PecaHardware("Fonte 650 W ","medio",880.00m));
			cbofonte.Items.Add(new PecaHardware("Fonte 750 W ","avançado",1230.00m));
			cbofonte.SelectedIndex = -1;
		}
		private void InicializarRam()
		{
			cbomemoria.Items.Clear();
			
			cbomemoria.Items.Add(new PecaHardware("8GB ","minimo",450.00m));
			cbomemoria.Items.Add(new PecaHardware("16GB ","medio",880.00m));
			cbomemoria.Items.Add(new PecaHardware("32GB ","avançado",1230.00m));
			cbomemoria.SelectedIndex = -1;
		}
		private void InicializarPlacamae()
		{
			cboplacamae.Items.Clear();
			
			cboplacamae.Items.Add(new PecaHardware("Placa-mãe básica","minimo",550.00m));
			cboplacamae.Items.Add(new PecaHardware("Placa-mãe media","medio",770.00m));
			cboplacamae.Items.Add(new PecaHardware("Placa-mãe avançada","avançado",1100.00m));
			cboplacamae.SelectedIndex = -1;
		}
		private void InicializarGabinete()
		{
			cbogabinete.Items.Clear();
			
			cbogabinete.Items.Add(new PecaHardware("Gabinete básica","minimo",90.00m));
			cbogabinete.Items.Add(new PecaHardware("Gabinete media","medio",220.00m));
			cbogabinete.Items.Add(new PecaHardware("Gabinete avançado","avançado",440.00m));
			cbogabinete.SelectedIndex = -1;
		}
		private void InicializarProcessadores()
		{
			cboprocessador.Items.Clear();
			
			
			cboprocessador.Items.Add(new PecaHardware("Intel i3", "minimo", 550.00m));
			cboprocessador.Items.Add(new PecaHardware("Intel i5", "medio", 1050.00m));
			cboprocessador.Items.Add(new PecaHardware("Intel i7", "avançado", 1450.00m));
			cboprocessador.SelectedIndex = -1;
		}
		void BtnCalcularClick(object sender, EventArgs e)
		{
			meuOrcamento.PecasEscolhidas.Clear();
			decimal taxaMontagem = 0;
			decimal Desconto = 0;
			
			if(!string.IsNullOrEmpty(txttaxa.Text))
			{
				taxaMontagem = Convert.ToDecimal(txttaxa.Text);
			}
			if(!string.IsNullOrEmpty(txtdesconto.Text))
			{
				Desconto = Convert.ToDecimal(txtdesconto.Text);
			}
			if(string.IsNullOrEmpty(txtNome.Text.Trim()))
			{
				MessageBox.Show("digite seu nome do cliente antes de calcular!","aviso",MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			
			if (cboprocessador.SelectedIndex == -1 || cboplacadevideo.SelectedIndex == -1 ||
			    cbomemoria.SelectedIndex == -1     || cbossd.SelectedIndex == -1         ||
			    cbofonte.SelectedIndex == -1       || cboplacamae.SelectedIndex == -1    ||
			    cbogabinete.SelectedIndex == -1)
			{
				MessageBox.Show("Por favor, selecione todos os componentes obrigatórios do PC!", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			
			decimal valorOpcionais = 0;
			
			if (chktecladomouse.Checked)
			{
				valorOpcionais += 90.00m;
			}
			if (chkheadset.Checked)
			{
				valorOpcionais += 120.00m;
			}
			if (chkMonitor.Checked)
			{
				valorOpcionais += 250.00m;
			}
			

			string perfilSelecionado = cboperfil.SelectedItem.ToString();
			switch (perfilSelecionado)
			{
				case "Administrativo":
					meuOrcamento.PerfilAtual = perfilAdministrativo;
					break;
				case "Professor de Tecnologia":
					meuOrcamento.PerfilAtual =PerfilProfessorTecnologia;
					break;
				case "Desenvolvedor de Software":
					meuOrcamento.PerfilAtual = perfilDesenvolvedorSoftware;
					break;
				case "Desenvolvedor de Jogos":
					meuOrcamento.PerfilAtual = perfilDesenvolvedorJogos;
					break;
			}
			meuOrcamento.PecasEscolhidas.Clear();
			
			if(cbossd.SelectedIndex != -1)
				meuOrcamento.PecasEscolhidas.Add((PecaHardware)cbossd.SelectedItem);
			
			if(cbofonte.SelectedIndex != -1)
				meuOrcamento.PecasEscolhidas.Add((PecaHardware)cbofonte.SelectedItem);
			
			if(cbogabinete.SelectedIndex != -1)
				meuOrcamento.PecasEscolhidas.Add((PecaHardware)cbogabinete.SelectedItem);
			
			if(cbomemoria.SelectedIndex != -1)
				meuOrcamento.PecasEscolhidas.Add((PecaHardware)cbomemoria.SelectedItem);
			
			if(cboplacamae.SelectedIndex != -1)
				meuOrcamento.PecasEscolhidas.Add((PecaHardware)cboplacamae.SelectedItem);
			
			if(cboprocessador.SelectedIndex != -1)
				meuOrcamento.PecasEscolhidas.Add((PecaHardware)cboprocessador.SelectedItem);
			
			if(cboplacadevideo.SelectedIndex != -1)
				meuOrcamento.PecasEscolhidas.Add((PecaHardware)cboplacadevideo.SelectedItem);
			
			string situacaoResultado = "adequada";
			string pecasIncompativeis = "Nenhuma";
			if(!meuOrcamento.ValidarConfiguracao())
			{
				situacaoResultado = "Inadequada / Incompativel";
				pecasIncompativeis = "";
				foreach (PecaHardware peca in meuOrcamento.PecasEscolhidas)
				{
					if(peca != null && !meuOrcamento.PerfilAtual.ValidarPeca(peca))
					{
						pecasIncompativeis += peca.Nome + " (" + peca.Performance + ") ";
					}
				}
			}
			string nomeDoClienteDigitado = txtNome.Text;
			decimal somaComponentes = meuOrcamento.CalcularTotal();
			decimal subtotal = somaComponentes + valorOpcionais;
			decimal valorMontagem = (somaComponentes * taxaMontagem)  /100;
			decimal valorDesconto = (subtotal * Desconto) /100;
			decimal totalFinal = subtotal + valorMontagem - valorDesconto;
			
			Orçamentodepc.Mostrar minhaTela = new Orçamentodepc.Mostrar(nomeDoClienteDigitado,
			                                                            perfilSelecionado,
			                                                            situacaoResultado,
			                                                            pecasIncompativeis,
			                                                            subtotal.ToString("C2"),
			                                                            valorMontagem.ToString("C2"),
			                                                            valorDesconto.ToString("C2"),
			                                                            totalFinal.ToString("C2")
			                                                           );
			
			
			minhaTela.StartPosition = FormStartPosition.CenterParent;
			minhaTela.ShowDialog();
		}
		void BtnCarregarRecomendacaoClick(object sender, EventArgs e)
		{
			if(cboperfil.SelectedIndex == -1)
			{
				
				MessageBox.Show("Por favor, selecione um perfil!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			string perfilTexto = cboperfil.SelectedItem.ToString();
			PerfilCliente perfilEscolhido = null;
			
			switch (perfilTexto)
			{
				case "Administrativo":
					perfilEscolhido = perfilAdministrativo;
					break;
				case "Professor de Tecnologia":
					perfilEscolhido =PerfilProfessorTecnologia;
					break;
				case "Desenvolvedor de Software":
					perfilEscolhido = perfilDesenvolvedorSoftware;
					break;
				case "Desenvolvedor de Jogos":
					perfilEscolhido = perfilDesenvolvedorJogos;
					break;
			}
			
			foreach (PecaHardware peca in cbofonte.Items)
			{
				if (perfilEscolhido.ValidarPeca(peca))
				{
					cbofonte.SelectedItem = peca;
					break;
				}
				
			}
			foreach (PecaHardware peca in cbomemoria.Items)
			{
				if (perfilEscolhido.ValidarPeca(peca))
				{
					cbomemoria.SelectedItem = peca;
					break;
				}
				
			}
			foreach (PecaHardware peca in cboplacamae.Items)
			{
				if (perfilEscolhido.ValidarPeca(peca))
				{
					cboplacamae.SelectedItem = peca;
					break;
				}
				
			}
			
			foreach (PecaHardware peca in cbossd.Items)
			{
				if (perfilEscolhido.ValidarPeca(peca))
				{
					cbossd.SelectedItem = peca;
					break;
				}
				
			}
			
			foreach (PecaHardware peca in cbogabinete.Items)
			{
				if (perfilEscolhido.ValidarPeca(peca))
				{
					cbogabinete.SelectedItem = peca;
					break;
				}
				
			}
			foreach (PecaHardware peca in cboprocessador.Items)
			{
				if (perfilEscolhido.ValidarPeca(peca))
				{
					cboprocessador.SelectedItem = peca;
					break;
				}
				
			}
			foreach (PecaHardware peca in cboplacadevideo.Items)
			{
				if (perfilEscolhido.ValidarPeca(peca))
				{
					cboplacadevideo.SelectedItem = peca;
					break;
				}
				
			}
			
			MessageBox.Show("recomendaçao aplicada para: " +perfilEscolhido.NomePerfil, "Sucesso");
			
			
		}
		
		void BtnLimparClick(object sender, EventArgs e)
		{
			meuOrcamento.PecasEscolhidas.Clear();
			cbofonte.SelectedIndex = -1;
			cbogabinete.SelectedIndex = -1;
			cbomemoria.SelectedIndex = -1;
			cboplacadevideo.SelectedIndex = -1;
			cboplacamae.SelectedIndex = -1;
			cboprocessador.SelectedIndex = -1;
			cbossd.SelectedIndex = -1;
			txtNome.Text = "";
			cboperfil.SelectedIndex = -1;
			chkheadset.Checked = false;
			chkMonitor.Checked = false;
			chktecladomouse.Checked = false;
			MessageBox.Show ("Campos limpos");
		}
		void BtnSairClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
		
		
	}
}
