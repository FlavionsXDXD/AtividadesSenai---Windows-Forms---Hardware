using System;

namespace boletim
{

	public class Estudante
	{
		public string Nome { get; set; }
		public string Turma { get; set; }
		public double Nota1 { get; set; }
		public double Nota2 { get; set; }
		public double Nota3 { get; set; }
		public double Nota4 { get; set; }
		public double Frequencia { get; set; }
		
		
		public Estudante(string nome, string turma, double n1, double n2, double n3, double n4, double freq)
		{
			Nome = nome;
			Turma = turma;
			Nota1 = n1;
			Nota2 = n2;
			Nota3 = n3;
			Nota4 = n4;
			Frequencia = freq;
		}
		
		public double CalcularMedia()
		{
			return (Nota1+Nota2+Nota3+Nota4) / 4;
		}
		
		public string ObterSituacao()
		{
			double media = CalcularMedia();
			
			if (Frequencia< 75)
			{
				return "Reprovado por Faltas";
			}
			
			else if (media >= 7.0)
			{
				return "Aprovado";
			}
			else if (media >= 5.0 && media < 7.0)
			{
				return "Recuperaçao";
			}
			else
			{
				return "Reprovado por Nota";
			}
		}
		public override string ToString()
		{
			return string.Format("{0} ({1}) - Media: {2:F1} - Freq: {3}% - situaçao {4}",
			Nome,Turma,CalcularMedia(), Frequencia, ObterSituacao());                    
		} 
		
	}
}
