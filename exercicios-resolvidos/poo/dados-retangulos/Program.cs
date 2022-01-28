/*
* Exercicio:
* Fazer um programa para ler os valores da largura e altura de um retângulo. Em
* seguida, mostrar na tela o valor de sua área, perímetro e diagonal. 
* OBS: sem tratamento de exceções
*/
using System.Globalization;

//Declarando váriaveis
double altura, largura;

//entrada
System.Console.WriteLine("Informe os dados do Triangulo:");
System.Console.Write("Altura: ");
altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
System.Console.Write("Largura: ");
largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

//Criando e estanciando o objeto:
Retangulo r;
r = new Retangulo(largura, altura);

//saída
System.Console.WriteLine("-------------------------------------------");
System.Console.WriteLine("Área: " + r.Area().ToString("F2") + " u.a");
System.Console.WriteLine("Perímetro: " + r.Perimetro().ToString("F2") +" u.m");
System.Console.WriteLine("Diagonal: " + r.Diagonal().ToString("F2") + " u.m");