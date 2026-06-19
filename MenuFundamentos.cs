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
        var opcion = Convert.ToInt32(Console.ReadLine());

        
            switch (opcion)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Variables");
                    Console.WriteLine();
                    VariablesTemas.MostrarTemas();
                    break;
                case 2:
                    Console.WriteLine("Lo sentimos, estamos trabajando en esta opcion");
                    return;
                case 3:
                    Console.WriteLine("Lo sentimos, estamos trabajando en esta opcion");
                    return; 
                case 4:
                    Console.WriteLine("Lo sentimos, estamos trabajando en esta opcion");
                    return; 
                case 0:
                    PantallaInicio.MenuPrincipal();
                    return;     
                default:
                    Console.WriteLine("Opción inválida");
                    break;          
            }
    }

   
}