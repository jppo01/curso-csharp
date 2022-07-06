/**
A dona de um pensionato possui dez quartos para alugar para estudantes,
sendo esses quartos identificados pelos números 0 a 9.
Quando um estudante deseja alugar um quarto, deve-se registrar o nome
e email deste estudante.
Fazer um programa que inicie com todos os dez quartos vazios, e depois
leia uma quantidade N representando o número de estudantes que vão
alugar quartos (N pode ser de 1 a 10). Em seguida, registre o aluguel dos
N estudantes. Para cada registro de aluguel, informar o nome e email do
estudante, bem como qual dos quartos ele escolheu (de 0 a 9). Suponha
que seja escolhido um quarto vago. Ao final, seu programa deve imprimir
um relatório de todas ocupações do pensionato, por ordem de quarto,
conforme exemplo.
*/

namespace reserva_quartos {
    class program{
        static void Main(string[] args){
            // Variáveis
            int n;
            System.Console.WriteLine("Quantos quartos serão reservados?");
            n = int.Parse(Console.ReadLine());

            // iniciando um vetor com n posições
            ReservaQuartos[] Vet = new ReservaQuartos[10];

            // usando um "for" para percorrer o vetor e guardar os valores lidos
            for (int i=0; i < n; i++)
            {
                System.Console.WriteLine("Reserva #"+ (i+1));
                System.Console.Write("Nome: ");
                string nome = Console.ReadLine();
                System.Console.Write("E-mail: ");
                string email = Console.ReadLine();
                System.Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                
                // deixando o vetor em ordem com os quartos
                Vet[quarto] = new ReservaQuartos();
                Vet[quarto].Nome = nome;
                Vet[quarto].Email = email;
                Vet[quarto].Quarto = quarto;


            }

            System.Console.WriteLine("-------------------------");
            System.Console.WriteLine("Quartos ocupados:");

            //for para exibir o registro de cada reserva
            for (int i=0; i < 10; i++)
            {
                if (Vet[i] != null) {
                System.Console.WriteLine(Vet[i]);
                }
            }
        }
    }
}