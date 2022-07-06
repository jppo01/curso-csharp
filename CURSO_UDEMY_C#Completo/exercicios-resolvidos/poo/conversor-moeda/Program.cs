/*
 *  Exercício usando membros estaticos
 * OBS: sem tratamento de exceção
 */

using System.Globalization;

//Declaração de variável
double cotacao, qtde, apagar;

Console.WriteLine("Qual é a Cotação do dólar? ");
cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.WriteLine("Quantos Dolares você vai comprar? ");
qtde = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
// é possível chamar o metodo USDBRL sem instanciar um objeto devido esse metodo ser um membro estático
apagar = ConversorDeMoeda.USDBRL(cotacao, qtde);
Console.WriteLine("Valor a ser pago em Reais: " + apagar.ToString("F2"));