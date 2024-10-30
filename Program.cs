// Circulo
using EjercicioPolimorfismo;

Console.WriteLine("*************** Área y Perímetro de un circulo ***************");

Console.Write("Ingrese el radio del circulo en cm: ");
double rC=Convert.ToDouble(Console.ReadLine());

Figura circulo = new Circulo(rC);

Console.WriteLine($"Área: {circulo.Area()} cm");
Console.WriteLine($"Perímetro: {circulo.Perimetro()} cm");

Console.WriteLine();


Console.WriteLine("************* Área y Perímetro de un rectángulo **************");
Console.Write("Ingrese la base del rectángulo en cm: ");
double bR = Convert.ToDouble(Console.ReadLine());
Console.Write("Ingrese la altura del rectángulo en cm: ");
double aR = Convert.ToDouble(Console.ReadLine());

Figura rectangulo = new Rectangulo(bR, aR);

Console.WriteLine($"Área: {rectangulo.Area()} cm");
Console.WriteLine($"Perímetro: {rectangulo.Perimetro()} cm");

Console.WriteLine();


Console.WriteLine("********* Área y Perímetro de un triangulos isosceles ********");
Console.Write("Ingrese la base del triangulos isosceles en cm: ");
double bT = Convert.ToDouble(Console.ReadLine());
Console.Write("Ingrese la altura del triangulos isosceles en cm: ");
double aT = Convert.ToDouble(Console.ReadLine());
Console.Write("Ingrese la medida de los lados iguales en cm: ");
double liT = Convert.ToDouble(Console.ReadLine());

Figura trianguloIsoscele = new TrianguloIsoscele(bT, aT, liT);

Console.WriteLine($"Área: {trianguloIsoscele.Area()} cm");
Console.WriteLine($"Perímetro: {trianguloIsoscele.Perimetro()} cm");

Console.WriteLine();


