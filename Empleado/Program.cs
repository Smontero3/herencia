public class Empleado
{
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string Cargo { get; set; }

    public Empleado(string nombre, string apellido, string cargo)
    {
        Nombre = nombre;
        Apellido = apellido;
        Cargo = cargo;
    }

    public override string ToString()
    {
        return $"{Nombre} {Apellido}, {Cargo}";
    }
}

public class Gerente : Empleado
{
    public string Departamento { get; set; }

    public Gerente(string nombre, string apellido, string cargo, string departamento) : base(nombre, apellido, cargo)
    {
        Departamento = departamento;
    }

    public override string ToString()
    {
        return $"{base.ToString()}, Departamento: {Departamento}";
    }
}

public class Vendedor : Empleado
{
    public double Comision { get; set; }

    public Vendedor(string nombre, string apellido, string cargo, double comision) : base(nombre, apellido, cargo)
    {
        Comision = comision;
    }

    public override string ToString()
    {
        return $"{base.ToString()}, Comisión: {Comision}";
    }
}

static void Main(string[] args)
{
    Gerente gerente = new Gerente("Ana", "Lopez", "Gerente General", "Ventas");
    Vendedor vendedor = new Vendedor("Juan", "Perez", "Vendedor", 0.15);

    Console.WriteLine($"Gerente: {gerente}");
    Console.WriteLine($"Vendedor: {vendedor}");
}
