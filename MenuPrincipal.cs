using Microsoft.VisualBasic;

class PantallaInicio
{
    public static void Mostrar()
    {
        Presentacion();
        MenuPrincipal();
    }

    static void Presentacion()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;

        Console.WriteLine("====================================================");
        Console.WriteLine("   _____          _      _          _               ");
        Console.WriteLine("  / ____|        | |    | |        | |              ");
        Console.WriteLine(" | |     ___   __| | ___| |     __ _| |__           ");
        Console.WriteLine(" | |    / _ \\ / _` |/ _ \\ |    / _` | '_ \\          ");
        Console.WriteLine(" | |___| (_) | (_| |  __/ |___| (_| | |_) |         ");
        Console.WriteLine("  \\_____\\___/ \\__,_|\\___|______\\__,_|_.__/          ");
        Console.WriteLine("                                                    ");
        Console.WriteLine("              CODELAB v1.0                          ");
        Console.WriteLine("         Laboratorio de Programación                ");
        Console.WriteLine("====================================================");

        Console.WriteLine("\nCargando módulos...");
        Thread.Sleep(2000);
        Console.Clear();

        Console.ResetColor();
    }

    public static void MenuPrincipal()
    {
        Console.Clear();
        Console.WriteLine($"===================");
        Console.WriteLine($"      CODELAB      ");
        Console.WriteLine($"===================");
        Console.WriteLine($" ");
        Console.WriteLine($"Versión : 1.0");
        Console.WriteLine($"Creado por : Pablo Rivera");
        Console.WriteLine($"Fecha : 16/06/2026");
        Console.WriteLine($" ");
        Console.WriteLine($"1. Fundamentosde C#");
        Console.WriteLine($"2. Programación Orientada a Objetos");
        Console.WriteLine($"3. Archivos");
        Console.WriteLine($"4. SQL Server");
        Console.WriteLine($" ");
        Console.WriteLine($"0. Salir");
        Console.WriteLine();
        Console.Write($"Seleccione una opcion: ");

        if (int.TryParse(Console.ReadLine(), out int opcion))
        {
            MenuEleccion(opcion);
        }
        else
        {
            Console.WriteLine("\nOpción inválida.");
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
            MenuPrincipal();
        }
    }

    static void MenuEleccion(int opcion)
    {
        while (true)
        {
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Modulo de Fundamentos");
                    Console.WriteLine();
                    MenuFundamentos.Run();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Modulo de POO");
                    Console.WriteLine("\n\n");
                    Console.WriteLine("Lo sentimos, módulo en construcción");
                    Console.WriteLine("\n\nPresione cualquier tecla para regresar");
                    Console.ReadKey();
                    Console.Clear();
                    PantallaInicio.MenuPrincipal();
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("Modulo de Archivos");
                    Console.WriteLine("\n\n");
                    Console.WriteLine("Lo sentimos, módulo en construcción");
                    Console.WriteLine("\n\nPresione cualquier tecla para regresar");
                    Console.ReadKey();
                    Console.Clear();
                    PantallaInicio.MenuPrincipal();
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("Modulo de SQL Server");
                    Console.WriteLine("\n\n");
                    Console.WriteLine("Lo sentimos, módulo en construcción");
                    Console.WriteLine("\n\nPresione cualquier tecla para regresar");
                    Console.ReadKey();
                    Console.Clear();
                    PantallaInicio.MenuPrincipal();
                    break;
                case 0:
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Opción inválida");
                    Console.ReadKey();
                    break;
            }
        }
    }
}