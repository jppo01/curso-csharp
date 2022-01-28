/* Exercício
 * OBS: Não foi implementada nenhuma tratação de excessão
 */

using System.Globalization;
// Declaração de variáveis auxiliares
string nome;
double preco;
int quantidade;

Console.WriteLine("Informações do Produto");
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
Console.WriteLine("valor atualizado => " + p);

Console.WriteLine("-----------------------------------------------------------------------");
Console.Write("Quantidade a ser adicionada: ");
p.AdicionarProdutos(int.Parse(Console.ReadLine()));
Console.WriteLine("valor atualizado => " + p);
Console.WriteLine("-----------------------------------------------------------------------");
Console.Write("Quantidade a ser removida: ");
p.RemoverProdutos(int.Parse(Console.ReadLine()));
Console.WriteLine("valor atualizado => " + p);