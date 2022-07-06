using System.Globalization;

// Declaração de variável
int conta;
string nome;
char saldoInicial;
double saldo;

// declarando objeto 
Conta c;

//entrada
Console.Write("Numero da conta: ");
conta = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Nome do titular: ");
nome = Console.ReadLine();
Console.Write("Haverá depósito inicial (s/n)?");
saldoInicial = char.Parse(Console.ReadLine());

// lógica para deposito inical e estancimamento de objeto
if (saldoInicial == 's')
{
    Console.Write("Entre o valor de depósito inicial: ");
    saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    //Estanciando objeto
    c = new Conta(conta, nome, saldo);
} else
{
    //estanciando objeto
    c = new Conta(conta, nome);
}

Console.WriteLine(c);

Console.WriteLine("-----------------------------------------------------------");

// Deposito
Console.Write("Entre um valor para depósito: ");
double deposito = double.Parse (Console.ReadLine(), CultureInfo.InvariantCulture);
c.Deposito(deposito);
Console.WriteLine("Dados atualizado: ");
Console.WriteLine(c);

Console.WriteLine("------------------------------------------------------------");

//Saque
Console.Write("Entre um valor para saque: ");
double saque = double.Parse (Console.ReadLine(), CultureInfo.InvariantCulture);
c.Saque(saque);
Console.WriteLine("Dados atulizado: ");
Console.WriteLine(c);




