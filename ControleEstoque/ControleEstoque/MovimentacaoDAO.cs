using System;
using System.Collections.Generic;
using System.IO;
using ControleEstoque.Models;

namespace ControleEstoque.Data
{
	public class MovimentacaoDAO
	{
		private Conexao conexao;
		private ProdutoDAO produtoDAO;

		public MovimentacaoDAO()
		{
			conexao = new Conexao();
			produtoDAO = new ProdutoDAO();
		}

		public void Registrar(Movimentacao mov)
		{
			string caminhoMov = conexao.ArquivoMovimentacoes;
			
			Produto prod = produtoDAO.BuscarPorId(mov.IdProduto);
			if (prod == null)
			{
				throw new Exception("Produto não encontrado no sistema!");
			}

			if (mov.Tipo == "SAÍDA" && prod.QuantidadeAtual < mov.Quantidade)
			{
				throw new Exception(string.Format("Saldo insuficiente! Estoque atual: {0} unidades. Saída solicitada: {1} unidades.",
				                                  prod.QuantidadeAtual, mov.Quantidade));
			}

			if (mov.Tipo == "ENTRADA")
			{
				prod.QuantidadeAtual += mov.Quantidade;
			}
			else if (mov.Tipo == "SAÍDA")
			{
				prod.QuantidadeAtual -= mov.Quantidade;
			}

			List<Produto> todosProdutos = produtoDAO.Listar();
			for (int i = 0; i < todosProdutos.Count; i++)
			{
				if (todosProdutos[i].Id == prod.Id)
				{
					todosProdutos[i] = prod;
					break;
				}
			}
			produtoDAO.ReescreverArquivo(todosProdutos, conexao.ArquivoProdutos);


			mov.Id = GerarProximoId();
			string linhaMov = string.Format("{0};{1};{2};{3};{4:yyyy-MM-dd HH:mm:ss};{5}",
			                                mov.Id, mov.IdProduto, mov.Tipo, mov.Quantidade, mov.DataHora, mov.Descricao);
			
			File.AppendAllText(caminhoMov, linhaMov + Environment.NewLine);
		}

		public List<Movimentacao> Listar()
		{
			List<Movimentacao> lista = new List<Movimentacao>();
			string caminho = conexao.ArquivoMovimentacoes;

			string[] linhas = File.ReadAllLines(caminho);

			foreach (string linha in linhas)
			{
				string[] colunas = linha.Split(';');
				if (colunas.Length == 6)
				{
					int id = Convert.ToInt32(colunas[0]);
					int idProd = Convert.ToInt32(colunas[1]);
					string tipo = colunas[2];
					int qtd = Convert.ToInt32(colunas[3]);
					DateTime data = Convert.ToDateTime(colunas[4]);
					string desc = colunas[5];

					Movimentacao m = new Movimentacao(id, idProd, tipo, qtd, data, desc);
					lista.Add(m);
				}
			}
			return lista;
		}
		public List<Movimentacao> ListarPorPeriodo(DateTime inicio, DateTime fim)
		{
			List<Movimentacao> todas = Listar();
			List<Movimentacao> filtradas = new List<Movimentacao>();

			foreach (Movimentacao m in todas)
			{
				if (m.DataHora.Date >= inicio.Date && m.DataHora.Date <= fim.Date)
				{
					filtradas.Add(m);
				}
			}
			return filtradas;
		}

		private int GerarProximoId()
		{
			List<Movimentacao> todas = Listar();
			if (todas.Count == 0) return 1;
			return todas[todas.Count - 1].Id + 1;
		}
	}
}
