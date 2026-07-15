using System;
using System.Collections.Generic;

namespace SistemaOrcamento
{
    
    public class PecaHardware
    {
        
        public string Nome { get; private set; }
        public string Performance { get; private set; } 
        public decimal Preco { get; private set; }

        public PecaHardware(string nome, string performance, decimal preco)
        {
            this.Nome = nome;
            this.Performance = performance;
            this.Preco = preco;
        }

        
        public override string ToString()
        {
            return string.Format("{0} ({1}) - R$ {2:N2}", Nome, Performance, Preco);
        }
    }

    
    public class PerfilCliente
    {
        public string NomePerfil { get; private set; }
        private List<string> performancesAceitas;

        public PerfilCliente(string nomePerfil, List<string> performancesAceitas)
        {
            this.NomePerfil = nomePerfil;
            this.performancesAceitas = performancesAceitas;
        }

        
        public bool ValidarPeca(PecaHardware peca)
        {
            if (peca == null) return false;
            return performancesAceitas.Contains(peca.Performance);
        }
    }

 
    public class Orcamento
    {
        public PerfilCliente PerfilAtual { get; set; }
        public List<PecaHardware> PecasEscolhidas { get; private set; }

        public Orcamento(PerfilCliente perfilInicial)
        {
            this.PerfilAtual = perfilInicial;
            this.PecasEscolhidas = new List<PecaHardware>();
        }

        public decimal CalcularTotal()
        {
            decimal total = 0;
            foreach (PecaHardware peca in PecasEscolhidas)
            {
                if (peca != null) total += peca.Preco;
            }
            return total;
        }

        
        public bool ValidarConfiguracao()
        {
            if (PerfilAtual == null) return false;

            foreach (PecaHardware peca in PecasEscolhidas)
            {
                
                if (peca != null && !PerfilAtual.ValidarPeca(peca))
                {
                    return false; 
                }
            }
            return true;
        }
    }
}
