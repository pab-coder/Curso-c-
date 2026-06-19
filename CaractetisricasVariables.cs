class CaracterísticasVariables
{
    public static void Run()
    {
        CaracteristicasDeVariables();
    }

    static void CaracteristicasDeVariables()
    {
        Console.WriteLine("Se muestra el tipo de dato de cada variable");
        Console.WriteLine("Así como sus caracteristicas y atributos");
        Console.WriteLine();

        char miChar = 'A';
        Console.WriteLine($"Mi caracter: {miChar} , Almacena un solo caracter Unicode");
        Console.WriteLine($"Muestra tipo dato: {miChar.GetType()}");
        Console.WriteLine($"Tamaño en byte: {sizeof(Char)} o 16 bits");
        Console.WriteLine();

        string miCadena = "Textos largos con numeros, letras y simbolos";
        Console.WriteLine($"Muestra tipo String: {miCadena.GetType()}");
        Console.WriteLine($"Tamaño en bytes es largo de la cadena {miCadena.Length} * 2");
        Console.WriteLine();
        
        int miEntero = 10;
        Console.WriteLine($"Mi entero {miEntero}");
        Console.WriteLine($"Tamaño en byte: {sizeof(int)}");
        Console.WriteLine($"Valor mínimo {int.MinValue}, valor Máximo: {int.MaxValue}");
        Console.WriteLine();

        long miLong = 500L;
        Console.WriteLine($"Mi Long {miLong}");
        Console.WriteLine($"Tamaño en byte: {sizeof(long)}");
        Console.WriteLine($"Valor mínimo {long.MinValue}, valor Máximo: {long.MaxValue}");
        Console.WriteLine();

        float miFloat = 125.5F;
        Console.WriteLine($"Mi Flotante {miFloat}");
        Console.WriteLine($"Tamaño en byte: {sizeof(float)}");
        Console.WriteLine($"Valor mínimo {float.MinValue}, valor Máximo: {float.MaxValue}");
        Console.WriteLine();

        double miDouble = 10.7;
        Console.WriteLine($"Mi Double: {miDouble}");
        Console.WriteLine($"Tamaño en byte: {sizeof(double)}");
        Console.WriteLine($"Valor mínimo {double.MinValue}, valor Máximo: {double.MaxValue}");
        Console.WriteLine();

        Console.Write("\nPresione una tecla para regresar...");
        Console.ReadKey();
        VariablesTemas.MostrarTemas();
        
    }
}