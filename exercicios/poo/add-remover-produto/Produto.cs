using System;

public class Produto
{
	// Atributos
	private string Nome;
	private double Preco;
	private int Quantidade;


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
	public void AdicionarProdutos(int quantity)
	{
	 Quantidade += quantity;
	}

	//Remover produtos do estoque
	public void RemoverProdutos(int quantity)
	{
	 Quantidade -= quantity;
	}

	// tostring
	public override string ToString(){
		return  ("Nome: " + Nome + "  Preço: " + Preco.ToString("F2") + "  Quantidade: " + Quantidade + "  Valor em estoque: "+ ValorTotalEmEstoque().ToString("F2"));
	}
}
