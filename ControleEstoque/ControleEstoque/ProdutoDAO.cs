using System;
using System.Collections.Generic;
using System.IO;
using ControleEstoque.Models;

namespace ControleEstoque.Data
{
    public class ProdutoDAO
    {
        private Conexao conexao;

        public ProdutoDAO()
        {
            conexao = new Conexao();
        }
        public List<Produto> Listar()
        {
            List<Produto> lista = new List<Produto>();
            string caminho = conexao.ArquivoProdutos;

            string[] linhas = File.ReadAllLines(caminho);

            foreach (string linha in linhas)
            {
                string[] colunas = linha.Split(';');
                if (colunas.Length == 6)
                {
                    int id = Convert.ToInt32(colunas[0]);
                    string nome = colunas[1];
                    int idCategoria = Convert.ToInt32(colunas[2]);
                    int qtdAtual = Convert.ToInt32(colunas[3]);
                    int estMinimo = Convert.ToInt32(colunas[4]);
                    bool ativo = Convert.ToBoolean(colunas[5]);

                    Produto prod = new Produto(id, nome, idCategoria, qtdAtual, estMinimo, ativo);
                    lista.Add(prod);
                }
            }
            return lista;
        }

        public void Inserir(Produto produto)
        {
            string caminho = conexao.ArquivoProdutos;
            produto.Id = GerarProximoId();

            string novaLinha = string.Format("{0};{1};{2};{3};{4};{5}",
                                             produto.Id, produto.Nome, produto.IdCategoria,
                                             produto.QuantidadeAtual, produto.EstoqueMinimo, produto.Ativo);

            File.AppendAllText(caminho, novaLinha + Environment.NewLine);
        }
        public void Atualizar(Produto produtoAtualizado)
        {
            string caminho = conexao.ArquivoProdutos;
            List<Produto> todos = Listar();

            for (int i = 0; i < todos.Count; i++)
            {
                if (todos[i].Id == produtoAtualizado.Id)
                {
                    produtoAtualizado.QuantidadeAtual = todos[i].QuantidadeAtual;
                    todos[i] = produtoAtualizado;
                    break;
                }
            }
            ReescreverArquivo(todos, caminho);
        }
        public void AlterarSituacao(int id, bool novoStatus)
        {
            string caminho = conexao.ArquivoProdutos;
            List<Produto> todos = Listar();

            foreach (Produto p in todos)
            {
                if (p.Id == id)
                {
                    p.Ativo = novoStatus;
                    break;
                }
            }
            ReescreverArquivo(todos, caminho);
        }
        public void Excluir(int id)
        {
            string caminho = conexao.ArquivoProdutos;
            List<Produto> todos = Listar();

            for (int i = 0; i < todos.Count; i++)
            {
                if (todos[i].Id == id)
                {
                    todos.RemoveAt(i);
                    break;
                }
            }
            ReescreverArquivo(todos, caminho);
        }
        public Produto BuscarPorId(int id)
        {
            List<Produto> todos = Listar();
            foreach (Produto p in todos)
            {
                if (p.Id == id) return p;
            }
            return null; 
        }

        public List<Produto> ListarEstoqueBaixo()
        {
            List<Produto> todos = Listar();
            List<Produto> alertas = new List<Produto>();

            foreach (Produto p in todos)
            {
                if (p.QuantidadeAtual <= p.EstoqueMinimo && p.Ativo)
                {
                    alertas.Add(p);
                }
            }
            return alertas;
        }
        private int GerarProximoId()
        {
            List<Produto> todos = Listar();
            if (todos.Count == 0) return 1;
            return todos[todos.Count - 1].Id + 1;
        }

        public void ReescreverArquivo(List<Produto> lista, string caminho)
        {
            File.WriteAllText(caminho, string.Empty);
            foreach (Produto p in lista)
            {
                string linha = string.Format("{0};{1};{2};{3};{4};{5}",
                                             p.Id, p.Nome, p.IdCategoria, p.QuantidadeAtual, p.EstoqueMinimo, p.Ativo);
                File.AppendAllText(caminho, linha + Environment.NewLine);
            }
        }
    }
}
