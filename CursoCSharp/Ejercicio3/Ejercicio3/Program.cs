using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
   public class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("La Suma es: {0}", new Suma(2, 1).Operar());
            Console.WriteLine("La Resta es: {0}", new Resta(2, 1).Operar());


            Console.WriteLine(new Empleado(1000, "Emmanuel Colina", 25, "Vendedor").imprimirSueldo());
        }
    }
}
