using System;

namespace _10_Ordenes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            DatosdePrueba datos = new DatosdePrueba();
            string opcion = (" ");

            while (true)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Clear();
                Console.WriteLine("                                                      _______________________________________________");
                Console.WriteLine("                                                      ||                                           ||");
                Console.WriteLine("                                                      ||          ****COMERCIAL EL MAÑANA****      ||");
                Console.WriteLine("                                                      ||                                           ||");
                Console.WriteLine("                                                      ||              B I E N V E N I D O S        ||");
                Console.WriteLine("                                                      ||                                           ||");
                Console.WriteLine("                                                      ||               Sistema de Ordenes          ||");
                Console.WriteLine("                                                      ||               ==================          ||");
                Console.WriteLine("                                                      ||                                           ||");
                Console.WriteLine("                                                      ||           1 - Lista de Productos          ||");
                Console.WriteLine("                                                      ||                                           ||");
                Console.WriteLine("                                                      ||           2 - Crear Orden                 ||");
                Console.WriteLine("                                                      ||                                           ||");
                Console.WriteLine("                                                      ||           3 - Lista de Clientes           ||");
                Console.WriteLine("                                                      ||                                           ||");
                Console.WriteLine("                                                      ||           4 - Lista de Vendedores         ||");
                Console.WriteLine("                                                      ||                                           ||");
                Console.WriteLine("                                                      ||           5 - Lista de Ordenes            ||");
                Console.WriteLine("                                                      ||                                           ||");
                Console.WriteLine("                                                      ||           0 - Salir                       ||");
                Console.WriteLine("                                                      ||                                           ||");
                Console.WriteLine("                                                      ||___________________________________________||");
                Console.WriteLine("");
                Console.Write(    "                                                             ***********Seleccione una opcion: ");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        datos.ListarProductos();
                        break;

                    case "2":
                        Console.Clear();
                        datos.crearOrden();
                        break;

                    case "3":
                        datos.ListarClientes();
                        break;

                    case "4":
                        datos.ListarVendedores();
                        break;
                    case "5":
                        Console.Clear();
                        datos.ListarOrdenes();
                        break;
                    default:
                        break;
                }

                if (opcion == "0")
                {
                    break;
                }
            }
        }
    }
}
