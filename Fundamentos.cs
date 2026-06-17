class Fundamentos
{
    public static void Run()
    {
        Console.Clear();

        Console.WriteLine("=== Fundamentos de C# ===");
        Console.WriteLine("1. Variables");
        Console.WriteLine("2. Operadores");
        Console.WriteLine("3. Condicionales");
        Console.WriteLine("4. Ciclos");

        Console.WriteLine("0. Regresar menu principal");
        
        Console.Write("Seleccione una opcion");
        var opcion = Convert.ToInt32(Console.ReadLine());
        ElegirTema(opcion);
    }

    static void ElegirTema(int opcion)
    {
        Console.Clear();

        switch (opcion)
        {
            case 1:
                Console.WriteLine("Tipos de Variables");
                break;
        }
    }
}