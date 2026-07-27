using System;

namespace ControleEstoque.Models
{
	public class Produto
	{
		public int Id { get; set; }
		public string Nome { get; set; }
		public int IdCategoria { get; set; } 
		public int QuantidadeAtual { get; set; } 
		public int EstoqueMinimo { get; set; } 
		public bool Ativo { get; set; }

		
		public Produto(string nome, int idCategoria, int estoqueMinimo)
		{
			Nome = nome;
			IdCategoria = idCategoria;
			QuantidadeAtual = 0;
			EstoqueMinimo = estoqueMinimo;
			Ativo = true;
		}

		
		public Produto(int id, string nome, int idCategoria, int quantidadeAtual, int estoqueMinimo, bool ativo)
		{
			Id = id;
			Nome = nome;
			IdCategoria = idCategoria;
			QuantidadeAtual = quantidadeAtual;
			EstoqueMinimo = estoqueMinimo;
			Ativo = ativo;
		}
	}
}
