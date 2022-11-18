using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchivoExcel.Entidades
{
    public class Especialidad
    {
        private int id;
        private string nombre;

        public Especialidad(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }

        public static List<Especialidad> Especialidades()
        {
            return new List<Especialidad>
            {
                new Especialidad(1, "Traumatologia")
            };
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
    }
}
