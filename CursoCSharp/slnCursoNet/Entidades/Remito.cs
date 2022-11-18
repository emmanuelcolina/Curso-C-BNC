using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Remito
    {
        private string? numero;
        private DateOnly date;
        private string? cliente;
        private string? direccion;
        private string? condicionIVA;
        private string? condicionVenta;
        private string? detalle;
        private DateOnly fechaEntrega;
        private decimal total;

        public Remito() { }

        public Remito(string numero, DateOnly date, string cliente, string direccion,
                      string condicionIVA, string condicionVenta, string detalle, DateOnly fechaEntrega,
                      decimal total) { 
            this.numero = numero;
            this.date = date;
            this.cliente = cliente;
            this.direccion = direccion;
            this.condicionIVA = condicionIVA;
            this.condicionVenta = condicionVenta;
            this.detalle = detalle;
            this.fechaEntrega = fechaEntrega;
            this.total = total;
        }

        public string? Numero { get => numero; set => numero = value; }
        public DateOnly Date { get => date; set => date = value; }
        public string? Cliente { get => cliente; set => cliente = value; }
        public string? Direccion { get => direccion; set => direccion = value; }
        public string? CondicionIVA { get => condicionIVA; set => condicionIVA = value; }
        public string? CondicionVenta { get => condicionVenta; set => condicionVenta = value; }
        public string? Detalle { get => detalle; set => detalle = value; }
        public decimal Total { get => total; set => total = value; }
        public DateOnly FechaEntrega { get => fechaEntrega; set => fechaEntrega = value; }
    }
}
