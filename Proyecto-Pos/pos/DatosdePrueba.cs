using System;
using System.Collections.Generic;
public class DatosdePrueba
{
    public List<Producto> ListadeProductos{ get; set; }
    public List<Cliente> ListadeClientes { get; set; }
    public List<Vendedor> ListadeVendedores { get; set; }
    public List<Orden> ListaOrdenes { get; set; }


    public DatosdePrueba()
    {
        ListadeProductos = new List<Producto>();
        cargarProductos();

        ListadeClientes = new List<Cliente>();
        cargarClientes();

        ListadeVendedores = new List<Vendedor>();
        cargarVendedores();


        ListaOrdenes = new List<Orden>();
        
    }

    private void cargarProductos()
    {
        
        Producto p1 = new Producto(1,  "TV-Plasma 50             ", 20000);
        ListadeProductos.Add(p1);

        Producto p2 = new Producto(2,  "Aire Acondicionado split ", 31500);
        ListadeProductos.Add(p2);

        Producto p3 = new Producto(3,  "Lavadora LG              ", 15600);
        ListadeProductos.Add(p3);

        Producto p4 = new Producto(4,  "Estufa Electrica         ", 9000);
        ListadeProductos.Add(p4);

        Producto p5 = new Producto(5,  "Secadora LG              ", 19995);
        ListadeProductos.Add(p5);
        
        Producto p6 = new Producto(6,  "Impresora Epson          ", 5000);
        ListadeProductos.Add(p6);

        Producto p7 = new Producto(7,  "Lapto HP                 ", 14950);
        ListadeProductos.Add(p7);

        Producto p8 = new Producto(8,  "Apple iPhone 11          ", 28595);
        ListadeProductos.Add(p8);

        Producto p9 = new Producto(9,  "Cargador Inalambrico     ", 2595);
        ListadeProductos.Add(p9);

    }

    private void cargarClientes()
    {
        Cliente c1 = new Cliente(1, "Maria Alcala", "3359-6020", "San Pedro Sula");
        ListadeClientes.Add(c1);

        Cliente c2 = new Cliente(2, "Veronica Bas", "9959-0028", "Santa Barbara");
        ListadeClientes.Add(c2);

        Cliente c3 = new Cliente(3, "Isabela Rios", "9859-0021", "Yoro");
        ListadeClientes.Add(c3);

        Cliente c4 = new Cliente(4, "Maycol Rocas", "3460-0228", "Puerto Cortes");
        ListadeClientes.Add(c4);

        Cliente c5 = new Cliente(5, "Ronny Rivera", "9059-0023", "San Pedro Sula");
        ListadeClientes.Add(c5);

        Cliente c6 = new Cliente(6, "Lucia Bossch", "9059-0023", "Tocoa");
        ListadeClientes.Add(c6);

        Cliente c7 = new Cliente(7, "Daniel Abreu", "9059-0023", "Puerto Cortes");
        ListadeClientes.Add(c7);

        Cliente c8 = new Cliente(8, "Marisela Gil", "9059-0023", "Tela Atlantida");
        ListadeClientes.Add(c8);

        Cliente c9 = new Cliente(9, "Marcela Diaz", "9854-0124", "Ocotepeque");
        ListadeClientes.Add(c9);
    }

    private void cargarVendedores()
    {
        Vendedor v1 = new Vendedor(1, "Marco Bueso", "3358-0101", "V001");
        ListadeVendedores.Add(v1);

        Vendedor v2 = new Vendedor(2, "Ana Oreyano", "9876-5432", "V002");
        ListadeVendedores.Add(v2);

        Vendedor v3 = new Vendedor(3, "Mariana Luz", "3467-0005", "v003");
        ListadeVendedores.Add(v3);

        Vendedor v4 = new Vendedor(4, "Ina  Cuevas", "9489-9008", "v004");
        ListadeVendedores.Add(v4);

        Vendedor v5 = new Vendedor(5, "Gladys Rosa", "3278-9098", "v005");
        ListadeVendedores.Add(v5);

        Vendedor v6 = new Vendedor(6, "Jimmy  Diaz", "3868-9090", "v006");
        ListadeVendedores.Add(v6);

        Vendedor v7 = new Vendedor(7, "Joshua Abar", "9268-9391", "v007");
        ListadeVendedores.Add(v7);

        Vendedor v8 = new Vendedor(8, "Gissel Clos", "8978-1028", "v008");
        ListadeVendedores.Add(v8);

        Vendedor v9 = new Vendedor(9, "Renata Viya", "9048-5898", "v009");
        ListadeVendedores.Add(v9);
    }
    

    public void ListarProductos()
    {
        Console.BackgroundColor = ConsoleColor.Yellow;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Clear();
        Console.WriteLine("||--------------------------------------------------------------------------------||");
        Console.WriteLine("||                                   Lista de Productos                           ||");
        Console.WriteLine("||                                   *****************                            ||");
        Console.WriteLine("||--------------------------------------------------------------------------------||");
        Console.WriteLine("");
        Console.WriteLine("Codigo Producto  ||     Descripcion del Producto                  || Precio del producto");
        Console.WriteLine("****************************************************************************************");

        foreach (var producto in ListadeProductos)
        {
            Console.WriteLine("         "+producto.Codigo + "       ||               " + producto.Descripcion + "       ||       " + producto.Precio);
        }

        Console.ReadLine();
    }

    public void ListarClientes()
    {
        Console.BackgroundColor = ConsoleColor.Cyan;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Clear();
        Console.WriteLine("||--------------------------------------------------------------------------------||");
        Console.WriteLine("||                                   Lista de Clientes                            ||");
        Console.WriteLine("||                                   *****************                            ||");
        Console.WriteLine("||--------------------------------------------------------------------------------||");
        Console.WriteLine("");
        Console.WriteLine("Orden Cliente || Nombre del Cliente || Telefono del Cliente || Direccion del Cliente");
        Console.WriteLine("=====================================================================================");

        foreach (var cliente in ListadeClientes)
        {
            Console.WriteLine("       "+ cliente.Codigo + "      ||   " + cliente.Nombre + "     ||     " + cliente.Telefono + "        ||    " + cliente.Direccion);
        }

        Console.ReadLine();
    }

    public void ListarVendedores()
    {
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Clear();
        Console.WriteLine("||--------------------------------------------------------------------------------||");
        Console.WriteLine("||                                   Lista de Vendedores                          ||");
        Console.WriteLine("||                                   *******************                          ||");
        Console.WriteLine("||--------------------------------------------------------------------------------||");
        Console.WriteLine("");
        Console.WriteLine("Orden Vendedor || Nombre del Vendedor || Telefono del Vendedor || Codigo del Vendedor");
        Console.WriteLine("=====================================================================================");

        foreach (var vendedor in ListadeVendedores)
        {
            Console.WriteLine("     " + vendedor.Codigo + "         ||    " + vendedor.Nombre + "      ||      " + vendedor.Telefono + "        ||        " + vendedor.CodigoVendedor);
        }

        Console.ReadLine();
    }
    public void crearOrden()
    {
        Console.BackgroundColor = ConsoleColor.Magenta;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Clear();
        Console.WriteLine("==========================");
        Console.WriteLine("|    Creando su orden    |");
        Console.WriteLine("==========================");
        Console.WriteLine(" ");

        Console.Write("Ingrese el codigo del cliente: ");
        string codigoCliente = Console.ReadLine();

        Cliente cliente = ListadeClientes.Find(c => c.Codigo.ToString() == codigoCliente);
        if (cliente == null)
        {
            Console.WriteLine("Cliente no encontrado");
            Console.ReadLine();
            return;
        }
        else
        {
            Console.WriteLine("Cliente: " + cliente.Nombre);
            Console.WriteLine("");
        }


        Console.Write("Ingrese el codigo del vendedor: ");
        string codigoVendedor = Console.ReadLine();

        Vendedor vendedor = ListadeVendedores.Find(v => v.Codigo.ToString() == codigoVendedor);
        if (vendedor == null)
        {
            Console.WriteLine("Vendedor no encontrado");
            Console.ReadLine();
            return;
        }
        else
        {
            Console.WriteLine("Vendedor: " + vendedor.Nombre);
            Console.WriteLine("");
        }
        
        int nuevoCodigo = ListaOrdenes.Count + 1;

        Orden nuevaOrden = new Orden(nuevoCodigo, DateTime.Now, "SPS" + nuevoCodigo, cliente, vendedor);
        ListaOrdenes.Add(nuevaOrden);


        while (true)
        {
           Console.Write("Ingrese el producto: ");
           string codigoProducto = Console.ReadLine();
           Producto producto = ListadeProductos.Find(p => p.Codigo.ToString() == codigoProducto);
            if (producto == null)
            {
                Console.WriteLine("Producto no encontrado");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Producto agregado: " + producto.Descripcion);
                Console.WriteLine("Con precio de: " + producto.Precio);
                nuevaOrden.AgregarProducto(producto);
                Console.WriteLine("");
                Console.Write("¿Desea continuar? s/n: ");
                string continuar = Console.ReadLine();
                Console.WriteLine("");
                
                if (continuar.ToLower() == "n")
                {
                //descuento
                Console.Write("Desea agregar un descuento? s/n: " );
                string continuar1 = Console.ReadLine();
                Console.WriteLine("");
                if (continuar1.ToLower()=="s")
                {
                Console.Write("Ingrese el descuento (en numeros enteros): " );
                double numero = 0;
                numero = int.Parse(Console.ReadLine());
                Console.WriteLine("El descuento es de: " + numero/100 * nuevaOrden.Subtotal);
                Console.WriteLine("");
                Console.WriteLine("El SubTotal de su orden es de: " + nuevaOrden.Subtotal);
                Console.WriteLine("El subtotal con descuentos es de: " + ( nuevaOrden.Subtotal - numero/100 * nuevaOrden.Subtotal ));
                Console.WriteLine("Total de Impuesto es de: " + ( nuevaOrden.Subtotal - numero/100 * nuevaOrden.Subtotal) * (0.15 ));
                Console.WriteLine("Total de su Orden es: " + (( nuevaOrden.Subtotal - numero/100 * nuevaOrden.Subtotal ) + ( nuevaOrden.Subtotal - numero/100 * nuevaOrden.Subtotal) * (0.15 )));
                Console.WriteLine("=======================================================================================================");
                Console.ReadLine();
                break;
                }
                else{
                Console.WriteLine("El SubTotal de su orden es de: "+ nuevaOrden.Subtotal);
                Console.WriteLine("Total de Impuesto es de: " + nuevaOrden.Impuesto);
                Console.WriteLine("Total de su Orden es: " + nuevaOrden.Total);
                Console.WriteLine("=======================================================================================================");
                Console.ReadLine();
                }
                break;
                
                }
            }
        } 
    }
    public void ListarOrdenes()
    {
        Console.BackgroundColor = ConsoleColor.White;
         Console.ForegroundColor = ConsoleColor.Black;
        Console.Clear();
        Console.WriteLine("                     COMERCIAL EL MAÑANA");
        Console.WriteLine("==============================================================");
        Console.WriteLine("                 **************************");
        Console.WriteLine("                 |     Listado de Ordenes  |");
        Console.WriteLine("                 **************************");
        Console.WriteLine(" ");

        foreach (var orden in ListaOrdenes)
        {
            Console.WriteLine("===============================================================");
            Console.WriteLine("Codigo   |             Fecha       |     Total con IVA incluido");
            Console.WriteLine("===============================================================");
            Console.WriteLine("      "+orden.Codigo + "  |    " + orden.Fecha + "    |     " + orden.Total );
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("Nombre del Cliente: " + orden.Cliente.Nombre);
            Console.WriteLine("");
            Console.WriteLine("Nombre del Vendedor: " + orden.Vendedor.Nombre);
            Console.WriteLine("");
            Console.WriteLine(" ");

            foreach (var detalle in orden.ListaOrdenDetalle)
            {
            Console.WriteLine("Producto: " + detalle.Producto.Descripcion);
            Console.WriteLine("Cantidad: " + detalle.Cantidad);
            Console.WriteLine("Precio: " + detalle.Precio);
            Console.WriteLine("============================================================");
            Console.WriteLine("");
            }
            Console.WriteLine(" ");
        }

        Console.ReadLine();
    }
}