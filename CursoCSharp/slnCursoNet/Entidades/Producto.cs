using System.Diagnostics.Contracts;

namespace Entidades
{
    public class Producto
    {
        private string? nombre;
        private string? descripcion;
        private decimal? precioCosto;
        private double? margen;
        private double? iva;
        private decimal? precioBruto;
        private decimal? precioVenta;
        private string? proveedor;
        private string? categoria;
        private string? subCategorias;

        public Producto() { }

        public Producto(string nombre, string descripcion, decimal precioCosto, double margen,
                        double iva, decimal precioBruto, decimal precioVenta, string proveedor,
                        string categoria, string subCategorias)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.precioCosto = precioCosto;
            this.margen = margen;
            this.iva = iva;
            this.precioBruto = precioBruto;
            this.precioVenta = precioVenta;
            this.proveedor = proveedor;
            this.categoria = categoria;
            this.subCategorias = subCategorias;
        }

        public string? Nombre { get => nombre; set => nombre = value; }
        public string? Descripcion { get => descripcion; set => descripcion = value; }
        public decimal? PrecioCosto { get => precioCosto; set => precioCosto = value; }
        public double? Margen { get => margen; set => margen = value; }
        public double? Iva { get => iva; set => iva = value; }
        public decimal? PrecioBruto { get => precioBruto; set => precioBruto = value; }
        public decimal? PrecioVenta { get => precioVenta; set => precioVenta = value; }
        public string? Proveedor { get => proveedor; set => proveedor = value; }
        public string? Categoria { get => categoria; set => categoria = value; }
        public string? SubCategorias { get => subCategorias; set => subCategorias = value; }
    }
}