public abstract class Persona
{
    public abstract string Identificarse();
}

public class Estudiante : Persona
{
    public string Matricula { get; set; }

    public Estudiante(string matricula)
    {
        Matricula = matricula;
    }

    public override string Identificarse()
    {
        return $"Soy un estudiante con matrícula {Matricula}";
    }
}

static void Main(string[] args)
{
    Estudiante estudiante = new Estudiante("123456");
    Console.WriteLine(estudiante.Identificarse());
}
