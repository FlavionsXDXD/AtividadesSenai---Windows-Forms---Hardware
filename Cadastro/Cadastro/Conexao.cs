using System;
using System.IO;
namespace Cadastro
{

	public class Conexao
	{
		private string arquivoBanco = "banco_cliente.txt";
		
		public string StringConexao {get; private set;}
		
		public Conexao()
		{
			StringConexao = "Server=Localhost;Database=empresa_db;Uid=root;Pwd;";
		}
		public bool AbrirConexaoSimulada()
		{
			try
			{
				if(!File.Exists(arquivoBanco))
				{
					File.Create(arquivoBanco).Close();
				}
				return true;
			}
			catch
			{
				return false;
			}
		}
		public string ObterCaminhoArquivo()
		{
			return arquivoBanco;
		}
	}
}
