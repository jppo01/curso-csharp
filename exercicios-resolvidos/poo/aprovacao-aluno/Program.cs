/*
* Fazer um programa para ler o nome de um aluno e as três notas que ele obteve nos três trimestres do ano
* (primeiro trimestre vale 30 e o segundo e terceiro valem 35 cada). Ao final, mostrar qual a nota final do aluno no
* ano. Dizer também se o aluno está APROVADO ou REPROVADO e, em caso negativo, quantos pontos faltam
* para o aluno obter o mínimo para ser aprovado (que é 60 pontos). Você deve criar uma classe Aluno para resolver
* este problema.
* OBS: sem tratamento de exceção! 
*/

using System.Globalization;

//Declarando Variáveis
string nome;
double n1, n2, n3;

//Entrada de dados
Console.WriteLine("Informe os dados do Aluno");
Console.Write("Nome: ");
nome = Console.ReadLine();
Console.Write("Nota N1: ");
n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Nota N2: ");
n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Nota N3: ");
n3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

//criando e estanciando objeto
Aluno A;
A = new Aluno(nome, n1, n2, n3);

//exibindo resultado
A.Aprovacao();
