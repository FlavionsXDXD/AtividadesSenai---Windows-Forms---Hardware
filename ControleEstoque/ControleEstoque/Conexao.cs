using System;
using System.IO;

namespace ControleEstoque.Data
{
	public class Conexao
	{
		
		public string ArquivoCategorias { get; private set; }
		public string ArquivoProdutos { get; private set; }
		public string ArquivoMovimentacoes { get; private set; }

		public Conexao()
		{
			ArquivoCategorias = "db_categorias.txt";
			ArquivoProdutos = "db_produtos.txt";
			ArquivoMovimentacoes = "db_movimentacoes.txt";
			
			InicializarBancoSimulado();
		}

		private void InicializarBancoSimulado()
		{
			if (!File.Exists(ArquivoCategorias)) File.Create(ArquivoCategorias).Close();
			if (!File.Exists(ArquivoProdutos)) File.Create(ArquivoProdutos).Close();
			if (!File.Exists(ArquivoMovimentacoes)) File.Create(ArquivoMovimentacoes).Close();
		}
	}
}
