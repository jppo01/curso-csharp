/* exercício: 
 * Fazer um programa para ler os dados de duas pessoas, depois mostrar o nome da pessoa mais
 * velha
 */

Pessoa x, y;
x = new Pessoa();
y = new Pessoa();

//entrada de dados da primeira pessoa
Console.WriteLine("Dados da primeira pessoa:");
Console.WriteLine("Nome:");
x.Nome = Console.ReadLine();
Console.WriteLine("Idade:");
x.Idade = int.Parse(Console.ReadLine());

//entrada de dados da segunda pessoa
Console.WriteLine("Dados da segunda pessoa:");
Console.WriteLine("Nome:");
y.Nome = Console.ReadLine();
Console.WriteLine("Idade:");
y.Idade = int.Parse(Console.ReadLine()); 


// lógica para comparar as idades e printar o resultado
if (x.Idade > y.Idade)
{
    Console.WriteLine(x.Nome + " é o mais velho(a)");
} else
{
    Console.WriteLine(y.Nome + " é o mais velho (a)");
}