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
        Console.WriteLine($"Creado por : Pablo");
        Console.WriteLine($"Fecha : 16/06/2026");
        Console.WriteLine($" ");
        Console.WriteLine($"1. Fundamentosde C#");
        Console.WriteLine($"2. Programación Orientada a Objetos");
        Console.WriteLine($"3. Archivos");
        Console.WriteLine($"4. SQL Server");
        Console.WriteLine($" ");
        Console.WriteLine($"0. Salir");
        Console.WriteLine($" ");
        Console.Write($"Seleccione una opcion: ");
        var opcion = Convert.ToInt32(Console.ReadLine());
        MenuEleccion(opcion);
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
                    Console.WriteLine("Modulo de POO");
                    Console.WriteLine();
                    break;
                case 3:
                    Console.WriteLine("Modulo de Archivos");
                    Console.WriteLine();
                    break;
                case 4:
                    Console.WriteLine("Modulo de SQL Server");
                    Console.WriteLine();
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