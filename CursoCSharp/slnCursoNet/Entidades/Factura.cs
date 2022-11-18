using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Factura
    {
        private string? tipo;
        private string? numero;
        private DateOnly fecha;
        private string? cliente;
        private string? direccion;
        private string? condicionIVA;
        private string? condicionVenta;
        private string? detalle;
        private decimal total;

        public Factura() { }

        public Factura(string tipo, string numero, DateOnly fecha, string cliente, string direccion, string condicionIVA,
                        string condicionVenta, string detalle, decimal total)
        {

            this.tipo = tipo;
            this.numero = numero;
            this.fecha = fecha;
            this.cliente = cliente;
            this.direccion = direccion;
            this.condicionIVA = condicionIVA;
            this.condicionVenta = condicionVenta;
            this.detalle = detalle;
            this.total = total;
        }

        public string? Tipo { get => tipo; set => tipo = value; }
        public string? Numero { get => numero; set => numero = value; }
        public DateOnly Fecha { get => fecha; set => fecha = value; }
        public string? Cliente { get => cliente; set => cliente = value; }
        public string? Direccion { get => direccion; set => direccion = value; }
        public string? CondicionIVA { get => condicionIVA; set => condicionIVA = value; }
        public string? CondicionVenta { get => condicionVenta; set => condicionVenta = value; }
        public string? Detalle { get => detalle; set => detalle = value; }
        public decimal Total { get => total; set => total = value; }
    }
}
