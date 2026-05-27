class TamañoTipoDatos
{
    public static void Run()
    {
        ImprimirTamañoTipoDatos();
    }

    static void ImprimirTamañoTipoDatos()
    {
        //Tipo entero
        int miEntero = 10;
        Console.WriteLine($"Número Entero: {miEntero}");
        Console.WriteLine($"Entero tamaño bytes: {sizeof(int)}");
        Console.WriteLine($"Valor mínimo entero: {int.MinValue}");
        Console.WriteLine($"Valor Máximo entero: {int.MaxValue}");

        //Tipo Long (letra l o L es opcional)
        long miLong = 100L;
        Console.WriteLine($"Numero Long: {miLong}");
        Console.WriteLine($"Long tamaño bytes: {sizeof(long)}");
        Console.WriteLine($"Valor mínimo Long: {long.MinValue}");
        Console.WriteLine($"Valor Máximo Long: {long.MaxValue}");

        //Tipo float (la letra f o F)
        float miFlotante = 6.5F;
        Console.WriteLine($"Número flotante: {miFlotante}");
        Console.WriteLine($"Float tamaño bytes: {sizeof(float)}");
        Console.WriteLine($"Valor minimo float: {float.MinValue}");
        Console.WriteLine($"Valor Máximo float: {float.MaxValue}");

        //Tipo Double
        double miDouble = 10.7;
        Console.WriteLine($"Número Double: {miDouble}");
        Console.WriteLine($"Double tamaño bytes: {sizeof(double)}");
        Console.WriteLine($"Valor minimo Double: {double.MinValue}");
        Console.WriteLine($"Valor Máximo Double: {double.MaxValue}");

        //Tipo char
        char miCaracter = 'A';
        Console.WriteLine($"Tipo Char: {miCaracter}");
        Console.WriteLine($"Char tamaño bytes: {sizeof(char)}");
        Console.WriteLine($"Valor minimo Char: {char.MinValue}");
        Console.WriteLine($"Valor Máximo Char: {char.MaxValue}");

        //Tipo String
        string miString = "Hola Mundo";
        Console.WriteLine($"Tipo Cadena: {miString}");
        Console.WriteLine(value: $"Comprobación largo de la cadena de la variable: {miString.Length}");
        
        //Tipo Bool
        bool miBooleano = false;
        Console.WriteLine($"Tipo Bool: {miBooleano}");
        Console.WriteLine($"Bool tamaño bytes: {sizeof(bool)}");
    }
}