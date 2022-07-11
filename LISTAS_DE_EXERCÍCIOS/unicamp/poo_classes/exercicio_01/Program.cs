/*
Questão 1
Escreva uma classe cujos objetos representam alunos matriculados em uma disciplina. Cada objeto
dessa classe deve guardar os seguintes dados do aluno: matrícula, nome, 2 notas de prova e 1 nota de
trabalho. Escreva os seguintes métodos para esta classe:
media: calcula a média final do aluno (cada prova tem peso 2,5 e o trabalho tem peso 2)
final: calcula quanto o aluno precisa para a prova final (retorna zero se ele não for para a final)
Considerando que a média da universidade é 60.

OBS: Exercício resolvido sem tratamento de exerções.
*/

using exercicio_01;
using System.Globalization;
using System;

string nome;
int matricula;

Console.WriteLine("--------------------------------");
Console.WriteLine("PROGRAMA INICIADO - INFORME OS DADOS DO ALUNO");
Console.Write("Nome do Aluno: ");
nome = Console.ReadLine();
Console.Write("Número de Matricula do Aluno: ");
matricula = int.Parse(Console.ReadLine());
 
Student Aluno = new Student(nome, matricula);

Console.WriteLine("--------------------------------");
Console.WriteLine("ALUNO CADASTRADO COM SUCESSO!");
Console.WriteLine("Nome do Aluno: " + Aluno.Nome);
Console.WriteLine("Número de Matricula: " + Aluno.Matricula);

Console.WriteLine("--------------------------------");
Console.WriteLine("ADICIONAR NOTAS - INFORME AS NOTAS");
Console.Write("Nota Prova P1: ");  
Aluno.NotaProva1 = (double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
Console.Write("Nota Prova P1: ");  
Aluno.NotaProva2 = (double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
Console.Write("Nota do Trabalho: ");  
Aluno.NotaTrabalho = (double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

Console.WriteLine("--------------------------------");
Console.WriteLine("SITUAÇÃO DO ALUNO");
Console.WriteLine("Média Parcial: " + Aluno.Media().ToString("F2"));
Aluno.NotaMinimaParaP3();

Console.WriteLine("--------------------------------");
Console.WriteLine("Programa Finalizado!");