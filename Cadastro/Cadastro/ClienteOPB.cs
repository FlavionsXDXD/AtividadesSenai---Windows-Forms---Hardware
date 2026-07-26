using System;
using System.Collections.Generic;
using System.IO;

namespace Cadastro
{

	public class ClienteOPB
	{
		private Conexao conexao;
		public ClienteOPB()
		{
			conexao = new Conexao();
			conexao.AbrirConexaoSimulada();
		}
		public List<CadastroCliente> ListarTodos()
		{
			List<CadastroCliente> lista = new List<CadastroCliente>();
			string caminho = conexao.ObterCaminhoArquivo();
			
			string[] linhas = File.ReadAllLines(caminho);
			
			foreach(string linha in linhas)
			{
				string[] colunas = linha.Split(';');
				
				if (colunas.Length == 7)
				{
					int id = Convert.ToInt32(colunas[0]);
					string nome=colunas[1];
					string cpf=colunas[2];
					string email=colunas[3];
					string telefone=colunas[4];
					string cidade=colunas[5];
					bool ativo= Convert.ToBoolean(colunas[6]);
					CadastroCliente c = new CadastroCliente(id, nome, cpf, email, telefone, cidade, ativo);
					lista.Add(c);
				}
			}
			return lista;
		}
		private int GerarProcimoId()
		{
			List<CadastroCliente> todos = ListarTodos();
			if(todos.Count == 0) return 1;
			return todos[todos.Count - 1].Id + 1;
		}
		public void Inserir(CadastroCliente cliente)
		{
			string caminho = conexao.ObterCaminhoArquivo();
			cliente.Id = GerarProcimoId();
			string novaLinha = string.Format("{0};{1};{2};{3};{4};{5};{6}",
			                                 cliente.Id,
			                                 cliente.Nome,
			                                 cliente.Cpf,
			                                 cliente.Email,
			                                 cliente.Telefone,
			                                 cliente.Cidade,
			                                 cliente.Ativo);
			File.AppendAllText(caminho, novaLinha + Environment.NewLine);
		}
		public void Editar(CadastroCliente clienteAtualizado)
		{
			string caminho = conexao.ObterCaminhoArquivo();
			
			List<CadastroCliente> todosClientes = ListarTodos();
			
			for(int i = 0; i <todosClientes.Count; i++)
			{
				if(todosClientes[i].Id == clienteAtualizado.Id)
				{
					todosClientes[i] = clienteAtualizado;
					break;
				}
			}
			SalvarListaNoArquivos(todosClientes, caminho);
		}
		
		public void AlterarStatus(int id, bool novoStatus)
		{
			string caminho = conexao.ObterCaminhoArquivo();
			List<CadastroCliente> todosClientes = ListarTodos();
			
			foreach (CadastroCliente c in todosClientes)
			{
				if (c.Id == id)
				{
					c.Ativo = novoStatus;
					break;
				}
			}
			SalvarListaNoArquivos(todosClientes, caminho);
		}
		public void Excluir(int id)
		{
			string caminho = conexao.ObterCaminhoArquivo();
			List<CadastroCliente>todosClientes = ListarTodos();
			for (int i = 0; i <todosClientes.Count; i++)
			{
				if (todosClientes[i].Id == id)
				{
					todosClientes.RemoveAt(i);
					break;
				}
			}
			SalvarListaNoArquivos(todosClientes, caminho);
		}
		private void SalvarListaNoArquivos(List<CadastroCliente> lista, string caminho)
		{
			File.WriteAllText(caminho, string.Empty);
			
			foreach (CadastroCliente c in lista)
			{
				string linha = string.Format("{0};{1};{2};{3};{4};{5};{6}",
				                             c.Id, c.Nome, c.Cpf, c.Email, c.Telefone, c.Cidade, c.Ativo);
				File.AppendAllText(caminho, linha + Environment.NewLine);
			}
		}
		
	}
}
