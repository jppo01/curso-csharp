/*
Ler os valores dos três coeficientes "a", "b" e "c" de uma equação do segundo grau (ax2+bx+c=0). 
Em seguida, mostrar os valores das raízes da equação, usando a fórmula de Baskara (veja abaixo). 
Se a equação não possuir raízes fazer um comparativo de delta menor que zero (o valor de “a” não 
pode ser zero, e o valor de “delta” não pode ser negativo), mostrar uma mensagem “Impossível calcular”. 
Lembre-se de usar o comando if/else estudados na Aula 1.

Fórmula: x=-b±∆2a   onde:  delta é igual à: ∆=b2-4ac
A = Primeiro dígito do RU do aluno
B = Segundo dígito do RU do aluno
C = Terceiro dígito do RU do aluno
*/

double a = 2; 
double b = 4; 
double c = 4;                                            

double delta = (2 * b - 4 * a * c);

if (a == 0 && b != 0 && c != 0){
    Console.WriteLine("Essa é uma equação do primeiro grau. Sendo assim, só possui uma raiz.");
    double x = -c/b;
    Console.WriteLine($"Raiz dessa equação é x = {x}");
} else if (delta < 0) {
    Console.WriteLine("Impossível calcular! Essa equação quadrática possui raizes complexas.");
} else {
    double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
    double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
    Console.WriteLine($"as raizes dessa equação são x1 = {x1} e x2 = {x2}");
}