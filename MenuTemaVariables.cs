class VariablesTemas
{
    public static void MostrarTemas()
    {
        ElegirTemas();
    }

    static void ElegirTemas()
    {
        Console.Clear();
        Console.WriteLine("==== Variables ====");
        Console.WriteLine();
        Console.WriteLine("1. Tipos de variables");
        Console.WriteLine("2. Características");
        Console.WriteLine("3. Ejemplos con variables");
        Console.WriteLine();
        Console.Write("0. Regresar a Menu anterior: ");
        var opcion = Convert.ToInt32(Console.ReadLine());


        switch (opcion)
        {
            case 1:
                Console.WriteLine("Tipos de Variables");
                Console.WriteLine();
                TiposVariables.Run();
                break;
            case 2:
                Console.WriteLine("Caracteristicas");
                Console.WriteLine();
                CaracterísticasVariables.Run();
                break;
            case 3:
                Console.WriteLine("Ejemplos con variables");
                Console.WriteLine();
                EjemploVariables.Run();
                break;
            case 0:
                PantallaInicio.MenuPrincipal();
                break;


            default:
                Console.WriteLine("Opción inválida");
                break;

        }
    }
}