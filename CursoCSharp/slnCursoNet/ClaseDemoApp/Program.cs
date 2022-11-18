using Entidades;

class program
{
    static void Main()
    {
        var producto = new Producto("Colgate", "Crema Dental", 12, 12.1,1.2, 13, 14, "P&G","Higiene", "Higiene");
        Console.WriteLine("Producto");
        Console.WriteLine("Nombre del Producto: " + producto.Nombre);
        Console.WriteLine("Descripcion del Producto: " + producto.Descripcion);
        Console.WriteLine("Precio del Producto: " + producto.PrecioCosto);
        Console.WriteLine("Margen del Producto: " + producto.Margen);
        Console.WriteLine("IVA del Producto: " + producto.Iva + "%");
        Console.WriteLine("Precio Bruto del Producto: " + producto.PrecioBruto);
        Console.WriteLine("Precio Venta del Producto: " + producto.PrecioVenta);
        Console.WriteLine("Proveedor del Producto: " + producto.Proveedor);
        Console.WriteLine("Categoria del Producto: " + producto.Categoria);
        Console.WriteLine("Sub Categoria del Producto: " + producto.SubCategorias);

        Console.WriteLine("****************************************************************");

        var proveedor = new Proveedor("P&G", "J55212212", "0212-7356854", "colgate@pg.com.ve", "0500-colgate", "Las Mercedes -  Caracas");
        Console.WriteLine("Proveedor");
        Console.WriteLine("Nombre del Proveedor: " + proveedor.Nombre );
        Console.WriteLine("CUIT del Proveedor: " + proveedor.Cuit);
        Console.WriteLine("Contacto del Proveedor: " + proveedor.Contacto);
        Console.WriteLine("Email del Proveedor: " + proveedor.Email);
        Console.WriteLine("Telefono del Proveedor: " + proveedor.Telefono);
        Console.WriteLine("Direccion del Proveedor: " + proveedor.Direccion);

        Console.WriteLine("****************************************************************");

        var clienteIndividuo = new ClienteIndividuo("Marcelo", "Zarraga", "v1654122", "mzarraga@pg.com.ve", "0424-9856547", "Las Mercedes -  Caracas");
        Console.WriteLine("Cliente Individuo");
        Console.WriteLine("Nombre del cliente: " + clienteIndividuo.Nombre);
        Console.WriteLine("Apellido del cliente: " + clienteIndividuo.Apellido);
        Console.WriteLine("CUIT del cliente: " + clienteIndividuo.Cuit);
        Console.WriteLine("Email del cliente: " + clienteIndividuo.Email);
        Console.WriteLine("Telefono del cliente: " + clienteIndividuo.Telefono);
        Console.WriteLine("Direccion del cliente: " + clienteIndividuo.Direccion);

        Console.WriteLine("****************************************************************");

        var clienteEmpresa = new ClienteEmpresa("Fiorella C.A", "J55214412", "0212-7356854", "fiorella@fio.com.ve", "0500-fiorella", "Las Mercedes -  Caracas");
        Console.WriteLine("Cliente - Empresa");
        Console.WriteLine("Nombre del cliente-empresa: " + clienteEmpresa.Nombre);
        Console.WriteLine("CUIT del cliente-empresa: " + clienteEmpresa.Cuit);
        Console.WriteLine("Contacto del cliente-empresa: " + clienteEmpresa.Contacto);
        Console.WriteLine("Email del cliente-empresa: " + clienteEmpresa.Email);
        Console.WriteLine("Telefono del cliente-empresa: " + clienteEmpresa.Telefono);
        Console.WriteLine("Direccion del cliente-empresa: " + clienteEmpresa.Direccion);
        Console.ReadLine();

        Console.WriteLine("****************************************************************");

        var vendedor = new Vendedor("Pedro", "Marin", "v1654100", "pmarin@hotmail.com.ve", "0424-9856500", "Las Mercedes -  Caracas");
        Console.WriteLine("Vendedor");
        Console.WriteLine("Nombre del vendedor: " + vendedor.Nombre);
        Console.WriteLine("Apellido del vendedor: " + vendedor.Apellido);
        Console.WriteLine("DNI del vendedor: " + vendedor.Dni);
        Console.WriteLine("Email del vendedor: " + vendedor.Email);
        Console.WriteLine("Telefono del vendedor: " + vendedor.Telefono);
        Console.WriteLine("Direccion del vendedor: " + vendedor.Direccion);

        Console.WriteLine("****************************************************************");

        var factura = new Factura("Juridica","4412", new DateOnly(2022, 1, 1), "Fiorella","Mercedes - Caracas","Porcentaje","Estandar","Factura Estandar",13);
        Console.WriteLine("Factura");
        Console.WriteLine("Tipo: " + factura.Tipo);
        Console.WriteLine("Numero: " + factura.Numero);
        Console.WriteLine("Fecha: " + factura.Fecha);
        Console.WriteLine("Cliente: " + factura.Cliente);
        Console.WriteLine("Direccion: " + factura.Direccion);
        Console.WriteLine("Condicion Iva: " + factura.CondicionIVA);
        Console.WriteLine("Condicion Venta: " + factura.CondicionVenta);
        Console.WriteLine("Detalle: " + factura.Detalle);
        Console.WriteLine("Total: " + factura.Total);

        Console.WriteLine("****************************************************************");

        var remito = new Remito("4412", new DateOnly(2022, 1, 1), "Fiorella", "Mercedes - Caracas", "Porcentaje", "Estandar", "Factura Estandar", new DateOnly(2022, 1, 1), 13);
        Console.WriteLine("Remito");
        Console.WriteLine("Numero: " + remito.Numero);
        Console.WriteLine("Fecha: " + remito.Date);
        Console.WriteLine("Cliente: " + remito.Cliente);
        Console.WriteLine("Direccion: " + remito.Direccion);
        Console.WriteLine("Condicion Iva: " + remito.CondicionIVA);
        Console.WriteLine("Condicion Venta: " + remito.CondicionVenta);
        Console.WriteLine("Detalle: " + remito.Detalle);
        Console.WriteLine("Fecha Entrega: " + remito.FechaEntrega);
        Console.WriteLine("Total: " + remito.Total);

    }
}
