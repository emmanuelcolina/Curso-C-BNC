using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    public class Empleado : Persona
    {
        BigInteger sueldo;
        string responsabilidad;

        public Empleado(BigInteger sueldo, string nombre, int edad, string responsabilidad)
        {
            this.sueldo = sueldo;
            this.responsabilidad = responsabilidad;
            this.Nombre = nombre;
            this.Edad = edad;
            
        }

        public BigInteger Sueldo { get => sueldo; set => sueldo = value; }

        public string imprimirSueldo()
        {
            return "Nombre: " + this.Nombre + " Edad: " + this.Edad + " Sueldo: " + sueldo + " Responsabilidad: " + responsabilidad;
        }
    }
}
