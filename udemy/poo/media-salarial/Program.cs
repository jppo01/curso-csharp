/* Exercício
 * Fazer um programa para ler nome e salário de dois funcionários. Depois, mostrar o salário
 * médio dos funcionários.
 */

using System.Globalization;

//Criando e estanciando objetos
Funcionario x, y;
x = new Funcionario();
y = new Funcionario();

//declaração de variáveis
double media;

// Entrada de dados do primeiro funcionário
Console.WriteLine("Informe os dados do primeiro funcionário");
Console.Write("Nome: ");
x.Nome = Console.ReadLine();
Console.Write("Salário: ");
x.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

// Entrada de dados do segundo funcionário
Console.WriteLine("Informe os dados do segundo funcionário");
Console.Write("Nome: ");
y.Nome = Console.ReadLine();
Console.Write("Salário: ");
y.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

//Separação
Console.WriteLine("-----------------------------------------");

// Calculo da média
media = (x.Salario + y.Salario) / 2;
Console.WriteLine("Média Salarial: " + media.ToString("F2", CultureInfo.InvariantCulture));
