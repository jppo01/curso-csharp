using System.Collections.Generic;
using System.Globalization;
using funcionarios;
int n = 0, id;
string name;
double salary = 0, increaseSalary=0;




System.Console.Write("Quantos funcionários você quer cadastrar? "); 
n = int.Parse(Console.ReadLine());

List<Employee> employees = new List<Employee>();

for (int i = 0 ; i<n; i++){
    System.Console.WriteLine("Funcionario #" + (i+1));
    System.Console.Write("Id: ");
    id = int.Parse(Console.ReadLine());
    while (employees.Exists(x =>  x.Id==id)){
        System.Console.WriteLine("ID inválido!");
        System.Console.Write("Informe novo ID: ");
        id = int.Parse(Console.ReadLine());
    }
    System.Console.Write("Nome: ");
    name = Console.ReadLine();
    System.Console.Write("Salary: ");
    salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    employees.Add(new Employee(id, name, salary));
    System.Console.WriteLine();
}

System.Console.WriteLine("Qual funcionário receberá reajuste de salário? ");
id = int.Parse(Console.ReadLine());
System.Console.WriteLine("Quantos porcentos de aumento? ");
increaseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
employees.Find(x => x.Id == id).increaseSalary(increaseSalary);


foreach (Employee obj in employees){
    System.Console.WriteLine(obj);
}