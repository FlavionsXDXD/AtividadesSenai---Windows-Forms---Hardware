using System;

namespace Garagem
{

	public class Estacionado
	{
		public string Placa { get; set; }
		public string Modelo { get; set; }
		public string TipoVeiculo { get; set; }
		public DateTime HorarioEntrada { get; set; }
		public DateTime? HorarioSaida { get; set; }
		public double ValorPago { get; set; }
		public string Status { get; set; }
		
		public Estacionado(string placa, string modelo, string tipo, DateTime entrada)
		{
			Placa= placa.ToUpper().Trim();
			Modelo = modelo;
			TipoVeiculo = tipo;
			HorarioEntrada = entrada;
			HorarioSaida = null;
			ValorPago = 0.0;
			Status = "Estacionado";
		}
		
		public int CalcularHorasCobradas(DateTime saida)
		{
			TimeSpan diferenca = saida - HorarioEntrada;
			
			double totalHoras = diferenca.TotalHours;
			
			int horasCobradas = (int)Math.Ceiling(totalHoras);
			
			if (horasCobradas <=0)
			{
				horasCobradas = 1;
			}
			
			return horasCobradas;
		}
		
		public double CalcularValor(DateTime saida)
		{
			int horas = CalcularHorasCobradas(saida);
			double valorHora = 0.0;
			
			if(TipoVeiculo == "Moto")
			{
				valorHora = 4.00;
			}
			else if(TipoVeiculo == "Carro")
			{
				valorHora = 7.00;
			}
			else if(TipoVeiculo == "Carga")
			{
				valorHora = 10.00;
			}
			
			return horas * valorHora;
		}
		
		public void RegistrarSaida(DateTime saida)
		{
			HorarioSaida = saida;
			ValorPago = CalcularValor(saida);
			Status = "Finalizado";
		}
		
	}
}
