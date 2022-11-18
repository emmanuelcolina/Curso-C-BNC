using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchivoExcel.Entidades
{
    public class Medico
    {
        private int id;
        private string nombre;
        private string apellido;
        private string matricula;

        public Medico(int id, string nombre, string apellido) { 
            
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public static List<Medico> Medicos()
        {
            return new List<Medico>
            {
                new Medico(1, "German", "Contreras")
            };
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Matricula { get => matricula; set => matricula = value; }
    }
}
