using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchivoExcel.Entidades
{
    public class Paciente
    {
        private int id;
        private string nombre;
        private string apellido;
        private string nohistoriaclinica;

        public Paciente(int id, string nombre, string apellido, string nohistoriaclinica)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.nohistoriaclinica = nohistoriaclinica;
        }

        public static List<Paciente> Pacientes()
        {
            return new List<Paciente>
            {
                new Paciente(1, "Emmanuel", "Colina", "0325"),
                new Paciente(2, "Rodolfo", "Gonzalez", "0326"),
                new Paciente(3, "Ana", "Colina", "0327"),
                new Paciente(4, "Lucas", "Molina", "0328")

            };
        }


        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Nohistoriaclinica { get => nohistoriaclinica; set => nohistoriaclinica = value; }
    }
}
