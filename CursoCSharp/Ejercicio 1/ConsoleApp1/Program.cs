using System.Numerics;
using System.Runtime.ConstrainedExecution;

class Program
{

    private string? a;

    public string A { get => a; set => a = value; }

    static void Main()
    {
        try
        {
            string? nombre;
            string? ciudad;
            string? dia;
            

            Console.WriteLine("Escriba su nombre:");

            nombre = Console.ReadLine();

            Console.WriteLine("Ingrese su Ciudad:");

            ciudad = Console.ReadLine();

            Console.WriteLine("Hola " + nombre +" bienvenido a " + ciudad);

            Console.WriteLine("Escriba dia de la semana:");

            dia = Console.ReadLine();

            if (dia.Equals("Domingo") ||
                dia.Equals("domingo") ||
                dia.Equals("Sabado") ||
                dia.Equals("sabado"))
                Console.WriteLine("Es fin de semana");
            else
                Console.WriteLine("No es fin de semana");
        }
        catch (FormatException fe)
        {

            Console.WriteLine("Error de formato: ", fe);
        }

    }

}
