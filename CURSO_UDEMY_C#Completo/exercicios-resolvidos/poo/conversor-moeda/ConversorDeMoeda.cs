using System;

public class ConversorDeMoeda
{	

	// ============ MÉTODOS =============

	// Comprar Dolar
	public static double USDBRL(double precoDolar, double qtdDolar)
	{
		double IFO = 0.06;
		return (precoDolar * qtdDolar) + IFO * (precoDolar * qtdDolar);


	}
}
