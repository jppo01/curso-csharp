using System;
public class Produto 
{
    // Atributos
    private string Nome;
	private double Preco;
	private int Quantidade;

    //Construtor
    public Produto (string nome, double preco, int quantidade)
    {
		Nome = nome;
		Preco = preco;
		Quantidade = quantidade;
    }

    // Métodos
    public double ValorTotalEmEstoque()
    {
        double total = (double) Preco * Quantidade;
		return total;
    }
    public void AdicionarProduto(int quantidade)
    {
        if(quantidade <= 0){
            while(quantidade <= 0)
            {
                Console.WriteLine("O valor não pode ser menor ou igual a zero. Favor informar novo valor:");
                Console.WriteLine("Favor informar novo valor: ");
                quantidade = int.Parse(Console.ReadLine());
            }
            Quantidade += quantidade;
        } else {
            Quantidade += quantidade;
        }
    }
    public void RemoverProdutos(int quantidade)
    {
        if(Quantidade > quantidade)
        {
            Quantidade = Quantidade - quantidade;
        } else {
            Console.WriteLine($"Não foi possível retirar {quantidade} do estoque pois esse valor é maior que o estoque atual.");
        }
    }

	// tostring
	public override string ToString(){
		return  ("Nome: " + Nome + "  Preço: " + Preco.ToString("F2") + "  Quantidade: " + Quantidade + "  Valor em estoque: $ "+ ValorTotalEmEstoque().ToString("F2"));
	}
}