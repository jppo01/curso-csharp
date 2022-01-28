/*
* Fazer um programa para ler os dados de um funcionário (nome,
* salário bruto e imposto). Em seguida, mostrar os dados do
* funcionário (nome e salário líquido). Em seguida, aumentar o salário
* do funcionário com base em uma porcentagem dada (somente o
* salário bruto é afetado pela porcentagem) e mostrar novamente os
* dados do funcionário. 
* OBS: sem tratamento de exceções
*/
using System.Globalization;
//Declaração de Variáveis 
string nome;
double porcentagem, salarioBruto, imposto;

//Entrada de dados
System.Console.WriteLine("Informe os dados do funcionário: ");
System.Console.Write("Nome: ");
nome = Console.ReadLine();
System.Console.Write("Salário Bruto: ");
salarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
System.Console.Write("Imposto: ");
imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

//criando e estanciando objeto
Funcionario f;
f = new Funcionario(nome, salarioBruto, imposto);

//Saída dos dados atuais
System.Console.WriteLine(f);
System.Console.WriteLine("--------------------------------------------------------------------------");

//entrada de reajuste do salario
System.Console.WriteLine("Digite a porcentagem em que gostaria de aumentar o salário do funcionario:");
porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
f.AumentarSalario(porcentagem); //passando a porcentagem de ajuste para o metodo AumentarSalario
//exibindo dados atualizados:
System.Console.WriteLine("Dados atualizados => " + f);
