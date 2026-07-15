using System;
using System.Windows.Forms;

namespace Orçamentodepc
{
	public partial class Mostrar : Form
	{
		
		public Mostrar(string nomeCliente,
		               string perfilCliente,
		               string situacaoMaquina,
		               string errosEncontrados,
		               string valorSubtoral,
		               string valorMontagem,
		               string valorDesconto,
		               string valorTotal)
		{
			InitializeComponent();
			
			
			lblcliente2.Text = "Cliente: "+nomeCliente;
			lblperfil2.Text = "Perfil: " +perfilCliente;
			lblsituaçaoconfiguraçao.Text = "Situaçao: " + situacaoMaquina;
			lblmensagem.Text = "Peças incompativeis: " + errosEncontrados;
			lblsubtotal.Text = "Subtotal: "+ valorSubtoral;
			lblvalormontagem.Text = "Valor da Montagem: " +valorMontagem;
			lblvalordesconto.Text = "Desconto:" +valorDesconto;
			lbltotal.Text = "Valor Total:" +valorTotal;
		}
		void BntSairfinalClick(object sender, EventArgs e)
		{
	Application.Exit();
		}
	}
}
