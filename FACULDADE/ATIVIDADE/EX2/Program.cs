using System.Globalization;

string nome;
double preco;
int quantidade;

Console.WriteLine("Entre com os dados do produto:");

Console.Write("Nome: ");
nome = Console.ReadLine();
Console.Write("Preço: ");
preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Quantidade: ");
quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


//criando e estanciando objeto p
Produto p;
p = new Produto (nome, preco, quantidade);

//printando estado atual
Console.WriteLine("Produto Cadastrado => " + p);

Console.WriteLine("-----------------------------------------------------------------------");
Console.Write("Quantidade a ser adicionada: ");
p.AdicionarProduto(int.Parse(Console.ReadLine()));
Console.WriteLine("valor atualizado => " + p);

Console.WriteLine("-----------------------------------------------------------------------");
Console.Write("Quantidade a ser removida: ");
p.RemoverProdutos(int.Parse(Console.ReadLine()));
Console.WriteLine("valor atualizado => " + p);