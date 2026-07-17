using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace vendas
{

	public partial class MainForm : Form
	{
		public MainForm()
		{
			
			InitializeComponent();
			
			
		}
		void BtnCalcularClick(object sender, EventArgs e)
		{
			if(string.IsNullOrWhiteSpace(txtCliente.Text) ||
			   string.IsNullOrWhiteSpace(txtProduto.Text)||
			   string.IsNullOrWhiteSpace(txtValorunitario.Text))
			{
				MessageBox.Show("Por favor preencha o campo com valor valido","Campos Obrigatorios",MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			decimal ValorUnitario;
			if(!decimal.TryParse(txtValorunitario.Text, out ValorUnitario))
			{
				MessageBox.Show("Por favor, insira um valor numerico","Valor invalido",MessageBoxButtons.OK,MessageBoxIcon.Error);
				return;
			}
			
			int quantidade = Convert.ToInt32(nudQuantidade.Value);
			decimal subtotal = ValorUnitario * quantidade;
			
			decimal percentualDesconto = 0;
			decimal valorAcrescimo = 0;
			string detalhesAcrescimos = "";
			if (!rdbDinheiro.Checked && !rdbPix.Checked && !rdbCartaoDebito.Checked && !rdbCartaoCredito.Checked)
			{
				MessageBox.Show("Por favor, selecione uma forma de pagamento!",
				                "Forma de Pagamento Ausente",
				                MessageBoxButtons.OK,
				                MessageBoxIcon.Warning);
				return;
			}
			if (rdbPix.Checked)
			{
				percentualDesconto = 0.08m;
			}
			else if (rdbDinheiro.Checked)
			{
				percentualDesconto = 0.10m;
			}
			else if (rdbCartaoDebito.Checked)
			{
				percentualDesconto = 0.03m;
			}
			else if (rdbCartaoCredito.Checked)
			{
				percentualDesconto = 0m;
			}
			
			if (chkEntrega.Checked)
			{
				valorAcrescimo +=  15.00m;
				detalhesAcrescimos += "[Entrega] ";
			}
			if (chkGarantia.Checked)
			{
				valorAcrescimo += (subtotal * 0.05m);
				detalhesAcrescimos += "[Garantia] ";
			}
			if (valorAcrescimo == 0)
			{
				detalhesAcrescimos = "Nenhum";
			}
			decimal valorDesconto = subtotal * percentualDesconto;
			decimal totalFinal = subtotal - valorDesconto + valorAcrescimo;
			
			lblSubtotal.Text = "Subtotal: "+ subtotal.ToString("C2");
			lblDescontos.Text = "Descontos:" + valorDesconto.ToString("C2");
			lblQuantidade2.Text = "Quantidade: " + nudQuantidade.Value.ToString();
			lblAcrecimos.Text = "Acréscimos: " + valorAcrescimo.ToString("C2") + " (" + detalhesAcrescimos.Trim() + ")";
			lblproduto3.Text =  "Produto: " + txtProduto.Text;
			lblTotal.Text = "Total: "+totalFinal.ToString("C2");
		}
		void BtnNovavendaClick(object sender, EventArgs e)
		{
			txtCliente.Clear();
			txtProduto.Clear();
			txtValorunitario.Clear();
			nudQuantidade.Value = 1;
			
			chkEntrega.Checked=false;
			chkGarantia.Checked=false;
			rdbDinheiro.Checked=true;
			
			lblSubtotal.Text = "Subtotal: ";
			lblDescontos.Text = "Desconto: ";
			lblAcrecimos.Text = "Acrecimos: ";
			lblTotal.Text = "Total: ";
			txtCliente.Focus();
		}
		void BtnSairClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
	}
}
