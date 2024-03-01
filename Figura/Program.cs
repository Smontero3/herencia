public abstract class FiguraGeometrica
{
    public string Nombre { get; set; }

    public FiguraGeometrica(string nombre)
    {
        Nombre = nombre;
    }

    public abstract double Area();
}

public class Cuadrado : FiguraGeometrica
{
    public double Lado { get; set; }

    public Cuadrado(double lado) : base("Cuadrado")
    {
        Lado = lado;
    }

    public override double Area()
    {
        return Lado * Lado;
    }
}

public class Triangulo : FiguraGeometrica
{
    public double Base { get; set; }
    public double Altura { get; set; }

    public Triangulo(double baseTriangulo, double altura) : base("Triangulo")
    {
        Base = baseTriangulo;
        Altura = altura;
    }

    public override double Area()
    {
        return (Base * Altura) / 2;
    }
}

static void Main(string[] args)
{
    Cuadrado cuadrado = new Cuadrado(5);
    Triangulo triangulo = new Triangulo(4, 3);

    Console.WriteLine($"Área del cuadrado: {cuadrado.Area()}");
    Console.WriteLine($"Área del triángulo: {triangulo.Area()}");
}
