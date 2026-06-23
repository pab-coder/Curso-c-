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

        Console.WriteLine("Tambien existen tipos de variables dinamicas esto es,");
        Console.WriteLine("declarar una variable dynamic donde se utiliza tipo int");
        Console.WriteLine("y puedes cambiarlo a string");
        Console.WriteLine("Se declara dynamic miEnteroDinamico = 10");
        dynamic miEnteroDinamico = 10;
        Console.WriteLine();

        miEnteroDinamico = "Esto es texto dentro de la varaible miEnteroDinamico";
        Console.WriteLine($"Cambiamos el contenido a cadena: {miEnteroDinamico}");
        Console.WriteLine("Al ser una variable dinamica se puede declara una vez y usarla");
        Console.WriteLine("multiples veces, pero se puede volver dificil\nde sostener a lo largo de un proyecto");
        Console.WriteLine();

        Console.WriteLine("Existen las variables Constantes, nos permite mantener\nel mismo tipo de dato durante la ejecución del programa");
        Console.WriteLine("Se clara const seguido de el tipo de dato mas el nombre de la variable\nel nombre de la variable que se especifica en mayúsculas");
        const float MI_IVA = 0.16F;
        Console.WriteLine($"const float MI_IVA = .16F");
        Console.WriteLine($"MI_IVA: {MI_IVA}");



        Console.Write("\nPresione una tecla para regresar...");
        Console.ReadKey();
        VariablesTemas.MostrarTemas();

    }
}