public abstract class Animal
{
    public string Nombre { get; set; }

    public Animal(string nombre)
    {
        Nombre = nombre;
    }

    public abstract string Hablar();
}

public class Perro : Animal
{
    public Perro(string nombre) : base(nombre) { }

    public override string Hablar()
    {
        return "Guau!";
    }
}

public class Gato : Animal
{
    public Gato(string nombre) : base(nombre) { }

    public override string Hablar()
    {
        return "Miau!";
    }
}

static void Main(string[] args)
{
    Perro perro = new Perro("Toby");
    Gato gato = new Gato("Michi");

    Console.WriteLine($"{perro.Nombre} dice: {perro.Hablar()}");
    Console.WriteLine($"{gato.Nombre} dice: {gato.Hablar()}");
}
