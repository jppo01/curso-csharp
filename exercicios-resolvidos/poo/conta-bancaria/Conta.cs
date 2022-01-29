using System;
using System.Globalization;

public class Conta
{
	// ========= ATRIBUTOS ========
	private string _nome;
	private double _saldo;


	//======= AUTO PROPERTIES =======
	public int NumConta { get; private set; }


	//======== CONSTRUTORES ========
	public Conta (int conta, string nome) // metodo para ser utilizado sem saldo inicial
    {
		NumConta = conta;
		_nome = nome;

		//não foi realizado atribuição de _saldo = 0 porque por padrão em C# já é atribuido o valor 0;
    }
	public Conta (int conta, string nome, double depositoInicial) : this (conta, nome ) // método utiliozado para saldo inicial 
	{
		Deposito(depositoInicial);
	}


	//====== PROPERTIES ======
	public string Nome
	{
		get { return _nome; } // retorna o valor de _nome
		set { _nome = value; } // altera o nome em _nome para o novo parametro passado 
	}

	public double Saldo
    {
		get { return _saldo; } // retorna o valor em _saldo
		set { _saldo = value;} // adiciona o valor passado como parametro ao valor que já em em _saldo
    }


	//====== OUTROS MÉTODOS DA CLASSE =======
	public void Deposito(double deposito)
    {
		Saldo += deposito; 
    }

	public void Saque (double saque)
    {
		Saldo = Saldo - saque - 5;
    }

    public override string ToString()
    {
        return ("Conta: " + NumConta +", Titular: " + Nome + ", Saldo: R$ " + Saldo.ToString("F2", CultureInfo.InvariantCulture));
    }
}

