/* Exercício
 * OBS: Não foi implementada nenhuma tratação de excessão
 */

using System.Globalization;
// Declaração de variáveis auxiliares
string nome;
double preco;
int quantidade;

Console.WriteLine("Informações do Produto");
Console.WriteLine("Nome: ");
nome = Console.ReadLine();

Console.WriteLine("Preço: ");
preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Quantidade: ");
quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Produto p;
p = new Produto (nome, preco, quantidade);
Console.WriteLine("valor atualizado => Nome: {0} Preço: {1} Quantidade: {2} Valor em Estoque: {3}", p.Nome, p.Preco, p.Quantidade, p.ValorTotalEmEstoque());

Console.WriteLine("-----------------------------------------------------------------------");
Console.WriteLine("Quantidade a ser adicionada:");
p.AdicionarProdutos(int.Parse(Console.ReadLine()));
Console.WriteLine("valor atualizado => Nome: {0} Preço: {1} Quantidade: {2} Valor em Estoque: {3}", p.Nome, p.Preco, p.Quantidade, p.ValorTotalEmEstoque());
Console.WriteLine("-----------------------------------------------------------------------");
Console.WriteLine("Quantidade a ser removida");
p.RemoverProdutos(int.Parse(Console.ReadLine()));
Console.WriteLine("valor atualizado => Nome: {0} Preço: {1} Quantidade: {2} Valor em Estoque: {3}", p.Nome, p.Preco, p.Quantidade, p.ValorTotalEmEstoque());