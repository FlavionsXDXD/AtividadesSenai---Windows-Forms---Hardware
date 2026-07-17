using System;

namespace vendas
{

	public class SistemaVendas
	{
		public string NomeProduto { get; set; }
		public double PrecoUnitario {get; set; }
		public int Quantidade {get; set; }
		public string FormaPagamento { get; set; }
		public bool Garantia {get; set; }
		public bool Frete { get; set; }
		
		public double CalcularTotal()
		{
			double subtotal = PrecoUnitario * Quantidade;
			
			if (FormaPagamento == "Dinheiro")
			{
				subtotal = subtotal * 0.90;
			}
			else if (FormaPagamento == "Pix")
			{
				subtotal = subtotal * 0.92;
			}
			else if (FormaPagamento == "Debito")
			{
				subtotal = subtotal * 0.97;
			}
			else if (FormaPagamento == "Credito")
			{
				subtotal = subtotal;
			}
			if(Garantia)
			{
				subtotal += 0.95;
			}
			
			if (Frete)
			{
				subtotal += 50.00;
			}
			
			return subtotal;
		}
	}
}
