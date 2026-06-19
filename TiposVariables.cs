using System;
using System.ComponentModel.DataAnnotations;

class TiposVariables
{
    public static void Run()
    {
        AprendiendoVariables();
    }

    static void AprendiendoVariables()
    {
        Console.Clear();
        Console.WriteLine("En C# existen variables donde se almacenan varios tipos de datos");
        Console.WriteLine("estos pueden ser Caracteres, Cadenas de Caracteres, Números, Booleanos");
        Console.WriteLine("En C# se conocen como char, string, numeros (int, float, double, long), boolean (elección True o False) ");
        Console.WriteLine();

        char miChar = 'A';
        Console.WriteLine($"Mi caracter: {miChar} aquí solo se permite un caracter");
        Console.WriteLine();

        string miCadena = "Textos largos con numeros, letras y simbolos";
        Console.WriteLine($"Mi cadena: {miCadena}");
        Console.WriteLine();

        int miEntero = 10;
        Console.WriteLine($"Mi entero {miEntero}");
        Console.WriteLine();

        long miLong = 500L;
        Console.WriteLine($"Mi Long {miLong}");
        Console.WriteLine();

        float miFloat = 125.5F;
        Console.WriteLine($"Mi Flotante {miFloat}");
        Console.WriteLine();

        double miDouble = 10.7;
        Console.WriteLine($"Mi Double: {miDouble}");
        Console.WriteLine();

        Console.Write("\nPresione una tecla para regresar...");
        Console.ReadKey();
        Console.Clear();
        VariablesTemas.MostrarTemas();

    }
}