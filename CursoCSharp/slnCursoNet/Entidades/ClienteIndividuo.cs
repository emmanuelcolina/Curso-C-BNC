using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ClienteIndividuo
    {
        private string? nombre;
        private string? apellido;
        private string? cuit;
        private string? email;
        private string? telefono;
        private string? direccion;

        public ClienteIndividuo() { }

        public ClienteIndividuo(string nombre, string apellido, string cuit, string email,
                         string telefono, string direccion)
        {

            this.nombre = nombre;
            this.cuit = cuit;
            this.apellido = apellido;
            this.email = email;
            this.telefono = telefono;
            this.direccion = direccion;
        }

        public string? Nombre { get => nombre; set => nombre = value; }
        public string? Cuit { get => cuit; set => cuit = value; }
        public string? Apellido { get => apellido; set => apellido = value; }
        public string? Email { get => email; set => email = value; }
        public string? Telefono { get => telefono; set => telefono = value; }
        public string? Direccion { get => direccion; set => direccion = value; }
    }
}
