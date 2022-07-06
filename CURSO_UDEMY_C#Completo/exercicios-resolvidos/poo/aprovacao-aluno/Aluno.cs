using System.Globalization;

public class Aluno
{
	//========= ATRIBUTOS =========
	private string Nome;
	private double N1, N2, N3;

	//========= MÉTODOS ===========

	//Construtor
	public Aluno(string nome, double n1, double n2, double n3)
	{
		Nome = nome;
		N1 = n1;
		N2 = n2;
		N3 = n3;
	}

	//Regras de negócio
	public void Aprovacao() {
		double media = Media();
		 if (media >= 60)
		{
			Console.WriteLine("Nota final: " + media.ToString("F2", CultureInfo.InvariantCulture));
			Console.WriteLine("ALUNO APROVADO!");
		} else {
			Console.WriteLine("Nota final: " + media.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("ALUNO REPROVADO!");
            Console.WriteLine("FALTARAM: " + NotaRestante().ToString("F2", CultureInfo.InvariantCulture) + " PONTOS!");
		}
	}

	//Cálculos matemáticos

	public double Media()
    {
		return (N1 + N2 + N3);
    }
	
	public double NotaRestante()
    {
		double media = Media();
		return (60 - media);
    }
}
