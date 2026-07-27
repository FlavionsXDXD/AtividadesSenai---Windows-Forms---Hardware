using System;
using System.Collections.Generic;
using System.IO;
using ControleEstoque.Models;

namespace ControleEstoque.Data
{
    public class CategoriaDAO
    {
        private Conexao conexao;

        public CategoriaDAO()
        {
            conexao = new Conexao();
        }

        public List<Categoria> Listar()
        {
            List<Categoria> lista = new List<Categoria>();
            string caminho = conexao.ArquivoCategorias;

            string[] linhas = File.ReadAllLines(caminho);

            foreach (string linha in linhas)
            {
                string[] colunas = linha.Split(';');
                if (colunas.Length == 2)
                {
                    int id = Convert.ToInt32(colunas[0]);
                    string nome = colunas[1];

                    Categoria cat = new Categoria(id, nome);
                    lista.Add(cat);
                }
            }
            return lista;
        }

        public void Inserir(Categoria categoria)
        {
            string caminho = conexao.ArquivoCategorias;

            categoria.Id = GerarProximoId();

            string novaLinha = string.Format("{0};{1}", categoria.Id, categoria.Nome);
            File.AppendAllText(caminho, novaLinha + Environment.NewLine);
        }

        public void Atualizar(Categoria categoriaAtualizada)
        {
            string caminho = conexao.ArquivoCategorias;
            List<Categoria> todas = Listar();

            for (int i = 0; i < todas.Count; i++)
            {
                if (todas[i].Id == categoriaAtualizada.Id)
                {
                    todas[i] = categoriaAtualizada;
                    break;
                }
            }

            ReescreverArquivo(todas, caminho);
        }

        public void Excluir(int id)
        {
            string caminho = conexao.ArquivoCategorias;
            List<Categoria> todas = Listar();

            for (int i = 0; i < todas.Count; i++)
            {
                if (todas[i].Id == id)
                {
                    todas.RemoveAt(i);
                    break;
                }
            }

            ReescreverArquivo(todas, caminho);
        }

        private int GerarProximoId()
        {
            List<Categoria> todas = Listar();
            if (todas.Count == 0) return 1;
            return todas[todas.Count - 1].Id + 1;
        }

        private void ReescreverArquivo(List<Categoria> lista, string caminho)
        {
            File.WriteAllText(caminho, string.Empty);
            foreach (Categoria cat in lista)
            {
                string linha = string.Format("{0};{1}", cat.Id, cat.Nome);
                File.AppendAllText(caminho, linha + Environment.NewLine);
            }
        }
    }
}
