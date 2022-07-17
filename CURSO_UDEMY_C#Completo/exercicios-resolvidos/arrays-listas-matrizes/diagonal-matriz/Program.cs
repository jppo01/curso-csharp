using System.Globalization;

int N = 0, negativeNumbers = 0;
System.Console.WriteLine("Valor de N: ");
N = int.Parse(Console.ReadLine());

double[,] mat = new double[N,N];

//Ler valores da matriz
for (int i = 0; i<N; i++){
    for(int j=0; j<N; j++){
        System.Console.WriteLine("Elemento " + (i+1) + "x" + (j+1) + ":");
        mat[i,j] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    }
}

//Printar diagonal da matriz e quantos números negativos
System.Console.WriteLine("Diagonal Principal: ");
for (int k = 0; k<N; k++){
    for(int y=0; y<N; y++){
        if (mat[k,y] < 0){
            negativeNumbers += 1; 
        }
    }
        System.Console.Write(mat[k,k] + " ");
        System.Console.WriteLine();
}
System.Console.WriteLine("Quantidade de Números Negativos na Matriz = " + negativeNumbers);
