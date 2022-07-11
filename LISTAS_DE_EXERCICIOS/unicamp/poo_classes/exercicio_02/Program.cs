// See https://aka.ms/new-console-template for more information
/*
Questão 2
Escreva uma classe Data cuja instância (objeto) represente uma data. Esta classe deverá dispor dos
seguintes métodos:
construtor define a data que determinado objeto (através de parâmetro), este método verifica se a
data está correta, caso não esteja a data é configurada como 01/01/0001
compara recebe como parâmetro um outro objeto da Classe data, compare com a data corrente e
retorne:
- 0 se as datas forem iguais;
- 1 se a data corrente for maior que a do parâmetro;
- -1 se a data do parâmetro for maior que a corrente.
getDia retorna o dia da data
getMes retorna o mês da data
getMesExtenso retorna o mês da data corrente por extenso
getAno retorna o ano da data
isBissexto retorna verdadeiro se o ano da data corrente for bissexto e falso caso contrário
clone o objeto clona a si próprio, para isto, ele cria um novo objeto da classe Data com os
mesmos valores de atributos e retorna sua referência pelo método
*/

using System;
using exercicio_02;


System.Console.WriteLine("Informe a Data: ");
DateTime DataLida1 = Convert.ToDateTime(Console.ReadLine());
System.Console.WriteLine("Data Lida: " + DataLida1);
System.Console.WriteLine("Data Atual: " + DateTime.Now);

Data D1 = new Data(DataLida1);

Console.WriteLine("Dia pelo Método getDia: " + D1.getDia());
Console.WriteLine("Mês pelo Método getMes: " + D1.getMes());
Console.WriteLine("Ano pelo Método GetAno: " + D1.getAno());
Console.WriteLine("Mês por extenso pelo Método getMesExtenso: " + D1.getMesExtenso());
Console.WriteLine("O ano é bissexto?: " + D1.isBissexto());

System.Console.WriteLine("Informe uma data para comparar: ");
DateTime DataLida2 = Convert.ToDateTime(Console.ReadLine());
Data D2 = new Data(DataLida2);
System.Console.WriteLine("Data Lida 2: " + DataLida2.ToString("dd/MM/yyyy"));
Console.WriteLine("Resultado da Data Comparada: " + D2.compare(DataLida2));

