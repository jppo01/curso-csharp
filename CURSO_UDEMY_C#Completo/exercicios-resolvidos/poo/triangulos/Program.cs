using System.Globalization;

Triangulos x, y;
x = new Triangulos();
y = new Triangulos();

double areaX = 0, areaY = 0;

// triangulo x
Console.WriteLine("informe o valor do lado A");
x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
System.Console.WriteLine("informe o valor do lado B");
x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
System.Console.WriteLine("informe o valor do lado C");
x.C = double.Parse (Console.ReadLine(), CultureInfo.InvariantCulture);

//separaçao
System.Console.WriteLine("------------------------");

// triangulo y
System.Console.WriteLine("informe o valor do lado A");
y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
System.Console.WriteLine("informe o valor do lado B");
y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
System.Console.WriteLine("informe o valor do lado C");
y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


// recebendo áreas
areaX = x.Area();
areaY = y.Area();

// mostrando o valor das áreas de cada triangulo
System.Console.WriteLine("Área de X: " + areaX.ToString("F2", CultureInfo.InvariantCulture));
System.Console.WriteLine("Área de Y: " + areaY.ToString("F2", CultureInfo.InvariantCulture));

// logica pra saber qual área é maior
if (areaX>areaY)
{
    System.Console.WriteLine("área de X é maior!");
} else if (areaY>areaX)
{
    System.Console.WriteLine("áreas de Y é maior");
} else if (areaY == areaX)
{
    System.Console.WriteLine("as áreas são iguais");
}
