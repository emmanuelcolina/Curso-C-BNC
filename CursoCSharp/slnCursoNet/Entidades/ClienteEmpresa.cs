using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ClienteEmpresa
    {
        private string? nombre;
        private string? cuit;
        private string? contacto;
        private string? email;
        private string? telefono;
        private string? direccion;

        public ClienteEmpresa() { }

        public ClienteEmpresa(string nombre, string cuit, string contacto, string email,
                         string telefono, string direccion)
        {
            this.nombre = nombre;
            this.cuit = cuit;
            this.contacto = contacto;
            this.email = email;
            this.telefono = telefono;
            this.direccion = direccion;
        }

        public string? Nombre { get => nombre; set => nombre = value; }
        public string? Cuit { get => cuit; set => cuit = value; }
        public string? Contacto { get => contacto; set => contacto = value; }
        public string? Email { get => email; set => email = value; }
        public string? Telefono { get => telefono; set => telefono = value; }
        public string? Direccion { get => direccion; set => direccion = value; }
    }
}
