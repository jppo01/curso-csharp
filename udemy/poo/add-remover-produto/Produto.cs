using System;

public class Produto
{
	// Atributos
	public string Nome;
	public double Preco;
	public int Quantidade;


	//################### MÉTODOS ######################


	//construtor
	public Produto (string nome, double preco, int quantidae)
    {
		Nome = nome;
		Preco = preco;
		Quantidade = quantidae;
    }
	
	//Valor em dinheiro que tem em estoque
	public double ValorTotalEmEstoque()
    {
		double total = (double) Preco * Quantidade;
		return total;
    }

	// Adicionar produtos em estoque
	public int AdicionarProdutos(int quantity) => Quantidade += quantity;
  
	
	//Remover produtos do estoque
	public int RemoverProdutos(int quantity) => Quantidade -= quantity;
   
	
}
