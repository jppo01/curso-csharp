using System.Globalization;

namespace preco_medio_produtos {
        class program{ 
            static void Main ( string[] args){
            
            // declarando variável numero de produtos a serem add
            int n;
            double soma = 0;
            System.Console.WriteLine("Entre c/ quantos produtos serão adicionados");
            n = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // Criando vetor do tipo Product
            Product[] vet = new Product[n];

            for (int i = 0; i<n; i++)
            {
                vet[i] = new Product();
               System.Console.Write("Informe Nome do Produto:");
               vet[i].Name = Console.ReadLine();
               System.Console.Write("Informe o preço do produto:");
               vet[i].Price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

  
               soma += vet[i].Price;
            }

        double med = soma / n;

        System.Console.WriteLine("Media: " + med.ToString("F2", CultureInfo.InvariantCulture));
          

        }
    }
}



