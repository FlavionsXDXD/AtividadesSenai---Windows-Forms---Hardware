using System;

namespace ControleEstoque.Models
{
    public class Movimentacao
    {
      
        public int Id { get; set; }
        public int IdProduto { get; set; } 
        public string Tipo { get; set; }     
        public int Quantidade { get; set; }
        public DateTime DataHora { get; set; }
        public string Descricao { get; set; } 

        public Movimentacao(int idProduto, string tipo, int quantidade, string descricao)
        {
            IdProduto = idProduto;
            Tipo = tipo.ToUpper().Trim(); 
            Quantidade = quantidade;
            DataHora = DateTime.Now; 
            Descricao = descricao;
        }

        public Movimentacao(int id, int idProduto, string tipo, int quantidade, DateTime dataHora, string descricao)
        {
            Id = id;
            IdProduto = idProduto;
            Tipo = tipo;
            Quantidade = quantidade;
            DataHora = dataHora;
            Descricao = descricao;
        }
    }
}
