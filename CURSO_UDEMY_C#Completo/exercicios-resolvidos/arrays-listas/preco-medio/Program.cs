/**
* Criar um vetor para ler a altura de N pessoas, depois calcular a altura média dos dados colhidos.
*
*/
using System.Globalization;
System.Console.Write("Quantas alturas: ");
int n = int.Parse(Console.ReadLine());
double[] vect = new double[n]; 
double media=0, alturaTotal = 0;

for (int i = 0 ; i < n ; i++){
    System.Console.Write("Informe o valor " + (i + 1) + " :");
   vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
   alturaTotal += vect[i];
   media = alturaTotal/n;
}

System.Console.WriteLine("Altura Média: " + media.ToString("F2", CultureInfo.InvariantCulture));