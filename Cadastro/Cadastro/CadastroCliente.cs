using System;

namespace Cadastro
{

	public class CadastroCliente
	{
		public int Id {get; set;}
		public string Nome {get; set;}
		public string Cpf {get; set;}
		public string Email {get; set;}
		public string Telefone {get; set;}
		public string Cidade {get; set;}
		public bool Ativo {get; set;}
		
		public CadastroCliente(string nome, string cpf, string email, string telefone, string cidade)
		{
			Nome = nome;
			Cpf= cpf;
			Email=email;
			Telefone=telefone;
			Cidade=cidade;
			Ativo=true;
		}
		public CadastroCliente(int id, string nome, string cpf, string email, string telefone, string cidade, bool ativo)
		{
			Id=id;
			Nome = nome;
			Cpf=cpf;
			Email=email;
			Telefone=telefone;
			Cidade=cidade;
			Ativo=ativo;
			
		}
		
	}
}
