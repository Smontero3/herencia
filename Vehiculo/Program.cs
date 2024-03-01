public class Vehiculo
{
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public int Año { get; set; }

    public Vehiculo(string marca, string modelo, int año)
    {
        Marca = marca;
        Modelo = modelo;
        Año = año;
    }

    public override string ToString()
    {
        return $"Marca: {Marca}, Modelo: {Modelo}, Año: {Año}";
    }
}

public class Automovil : Vehiculo
{
    public string TipoCombustible { get; set; }

    public Automovil(string marca, string modelo, int año, string tipoCombustible) : base(marca, modelo, año)
    {
        TipoCombustible = tipoCombustible;
    }

    public override string ToString()
    {
        return $"{base.ToString()}, Tipo de combustible: {TipoCombustible}";
    }
}

public class Motocicleta : Vehiculo
{
    public int Cilindrada { get; set; }

    public Motocicleta(string marca, string modelo, int año, int cilindrada) : base(marca, modelo, año)
    {
        Cilindrada = cilindrada;
    }

    public override string ToString()
    {
        return $"{base.ToString()}, Cilindrada: {Cilindrada}";
    }
}

static void Main(string[] args)
{
    Automovil auto = new Automovil("Toyota", "Corolla", 2023, "Gasolina");
    Motocicleta moto = new Motocicleta("Honda", "CB500X", 2022, 500);

    Console.WriteLine($"Auto: {auto}");
    Console.WriteLine($"Moto: {moto}");
}
