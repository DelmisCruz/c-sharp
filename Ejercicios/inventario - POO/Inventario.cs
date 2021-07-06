using System;
public class Inventario
{    
    string [,] productos = new string[5,3]
    {
        { "001", "iPhone X", "0" },
        { "002", "Laptop Dell", "5" },
        { "003", "Monitor Samsung", "2" },
        { "004", "Mouse", "100" },
        { "005", "HeadSet", "25" }
    };
    public Inventario()
    {
        
    }

public void listarproductos(){
    Console.Clear();
    Console.WriteLine("");
    Console.WriteLine("Listado de Productos");
    Console.WriteLine("********************");
    Console.WriteLine("Codigo, Descripcion y Existencia");

    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine(productos[i, 0] + " | " + productos[i, 1] + " | " + productos[i, 2] );
    }
    Console.ReadLine();
}
private void movimientoInventario(string codigo, int cantidad, string tipoMovimiento) {
    for (int i = 0; i < 5; i++)
    {
            if (productos[i, 0] == codigo) {
                if (tipoMovimiento == "+") {
                    productos[i, 2] = (Int32.Parse(productos[i, 2]) + cantidad).ToString();
            } else {
                    productos[i, 2] = (Int32.Parse(productos[i, 2]) - cantidad).ToString();
            }
        }
    }
}

public void ingresoDeInventario() {
    string codigo = "";
    string cantidad = "";

        Console.Clear();
        Console.WriteLine("");
        Console.WriteLine("Ingreso de Productos al Inventario");
        Console.WriteLine("**********************************");
        Console.Write("Ingrese el codigo del producto: ");
        codigo = Console.ReadLine();
        Console.Write("Ingrese la cantidad del producto: ");
        cantidad = Console.ReadLine();

        movimientoInventario(codigo, Int32.Parse(cantidad), "+");
    }  
public void ajustePositivoDeInventario() {
        string codigo = "";
        string cantidad = "";

        Console.Clear();
        Console.WriteLine("");
        Console.WriteLine("Ajustes Positivos de Productos al Inventario" );
        Console.WriteLine("*******************************************");
        Console.Write("Ingrese el codigo del producto: ");
        codigo = Console.ReadLine();
        Console.Write("Ingrese la cantidad del producto: ");
        cantidad = Console.ReadLine();

        movimientoInventario(codigo, Int32.Parse(cantidad), "+");
    }

public void salidaDeInventario() {
        string codigo = "";
        string cantidad = "";

        Console.Clear();
        Console.WriteLine("");
        Console.WriteLine("Salida de Productos del Inventario" );
        Console.WriteLine("**********************************");
        Console.Write("Ingrese el codigo del producto: ");
        codigo = Console.ReadLine();
        Console.Write("Ingrese la cantidad del producto: ");
        cantidad = Console.ReadLine();

        movimientoInventario(codigo, Int32.Parse(cantidad), "-");
    }
public void ajusteNegativoDeInventario() {
        string codigo = "";
        string cantidad = "";

        Console.Clear();
        Console.WriteLine("");
        Console.WriteLine("Ajuste Negativo de Productos del Inventario");
        Console.WriteLine("*******************************************");
        Console.Write("Ingrese el codigo del producto: ");
        codigo = Console.ReadLine();
        Console.Write("Ingrese la cantidad del producto: ");
        cantidad = Console.ReadLine();

        movimientoInventario(codigo,Int32.Parse(cantidad), "-");
    }
}