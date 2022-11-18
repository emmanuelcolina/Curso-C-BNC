using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    public class Suma : Operacion
    {   
        public Suma(int valor1, int valor2)
        {
            this.Valor1 = valor1;
            this.Valor2 = valor2;
        }
        public int Operar()
        {
            return this.Resultado = this.Valor1 + this.Valor2;
        }
    }
}
