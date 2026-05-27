using System;
//Tipos de Datos en C#
//Tipos Enteros

class TiposDatos
{
    public static void Run()
    {
        ImprimirDatos();
    }

    static void ImprimirDatos()
    {
        //Tipos Entero
        int miEntero = 10;
        Console.WriteLine($"Numero entero: {miEntero}");

        //Tipo Long (letra l o L es opcional)
        long miLong = 100L;
        Console.WriteLine($"Numero Long: {miLong}");

        //Tipo float (la letra f o F)
        float miFlotante = 6.5F;
        Console.WriteLine($"Número flotante: {miFlotante}");

        //Tipo Double
        double miDouble = 10.7;
        Console.WriteLine($"Número Double: {miDouble}");

        //Tipo char
        char miCaracter = 'A';
        Console.WriteLine($"Tipo Char: {miCaracter }");

        //Tipo String
        string miString = "Hola Mundo";
        Console.WriteLine($"Tipo Cadena: {miString}");
        Console.WriteLine(value: $"Comprobación largo de la cadena de la variable: {miString.Length}");
        
        //Tipo Bool
        bool miBooleano = false;
        Console.WriteLine($"Tipo Bool: {miBooleano}");

    }
}
