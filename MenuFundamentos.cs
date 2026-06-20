class MenuFundamentos
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
        Console.WriteLine();
        Console.Write("Seleccione una opcion: ");

        if (int.TryParse(Console.ReadLine(), out int opcion))
        {
            switch (opcion)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Variables");
                    Console.WriteLine();
                    VariablesTemas.MostrarTemas();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Operadores");
                    Console.WriteLine("\n\n");
                    Console.WriteLine("Lo sentimos, estamos trabajando en esta opcion");
                    Console.WriteLine("\n\nPresione cualquier tecla para continuar..");
                    Console.ReadKey();
                    Console.Clear();
                    VariablesTemas.MostrarTemas();
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("Condicionales");
                    Console.WriteLine("\n\n");
                    Console.WriteLine("Lo sentimos, estamos trabajando en esta opcion");
                    Console.WriteLine("\n\nPresione cualquier tecla para continuar");
                    Console.ReadKey();
                    Console.Clear();
                    VariablesTemas.MostrarTemas();
                    break; 
                case 4:
                    Console.Clear();
                    Console.WriteLine("Ciclos");
                    Console.WriteLine("\n\n");
                    Console.WriteLine("Lo sentimos, estamos trabajando en esta opcion");
                    Console.WriteLine("\n\nPresione cualquier tecla para continuar");
                    Console.ReadKey();
                    Console.Clear();
                    VariablesTemas.MostrarTemas();
                    break; 
                case 0:
                    PantallaInicio.MenuPrincipal();
                    return;              
            }
        }
        else
        {
            Console.WriteLine("\nOpción inválida.");
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
            VariablesTemas.MostrarTemas();
        }
            
    }

   
}