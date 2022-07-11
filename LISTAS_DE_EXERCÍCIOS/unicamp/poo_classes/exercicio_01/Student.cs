using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace exercicio_01
{
    public class Student
    {
        public int Matricula { get; private set; }
        public string Nome { get; private set; }
        public double NotaProva1 { get; set; }
        public double NotaProva2 { get; set; }
        public double NotaTrabalho { get; set; }

        // construtor
        public Student()
        {

        }
        public Student(string nome, int matricula)
        {
            Matricula = matricula;
            Nome = nome;
        }

        public double Media()
        {
            return (NotaProva1 * 0.25) + (NotaProva2 * 0.25) + (NotaTrabalho * 0.2);
        }

        public void NotaMinimaParaP3()
        {
            double Prova3;
            Prova3 = ( 6.00 - ((NotaProva1 * 0.25) + (NotaProva2 * 0.25) + (NotaTrabalho * 0.2)));

            if (Prova3 <= 0)
            {
                Console.WriteLine("Aluno já está Aprovado!");
            }
            if (Prova3 > 3)
            {
                Console.WriteLine("Aluno Reprovado!");
            }
            else
            {   
                Console.Write("Na P3 o aluno precisará de ");
                //Math.Round com MidpointRouding.ToPositiveInfinity sempre arredonda pra cima
                Console.WriteLine(Math.Round((Prova3/0.3), 2, MidpointRounding.ToPositiveInfinity));
            }
        }
    }
}