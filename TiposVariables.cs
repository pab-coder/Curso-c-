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
        Console.WriteLine("En C# existen variables donde se almacenan varios tipos de datos");
        Console.WriteLine("estos pueden ser Caracteres, Cadenas de Caracteres, Números, Booleanos");
        Console.WriteLine("En C# se conocen como char, string, numeros (int, float, double, long), boolean (elección True o False) ");

        char miChar = 'A';
        Console.WriteLine($"Mi caracter: {miChar}");

        string miCadena = "Mi cadena de caracteres";
        Console.WriteLine($"Mi caracter: {miCadena}");

        int miEntero = 10;
        Console.WriteLine($"Mi entero {miEntero}");

        

        Console.WriteLine("Para ejemplo se declaran las variables num1 = 10 y num2 = 20 tipo int");
        
        int num1 = 10;
        int num2 = 20;

        Console.WriteLine($"Los numeros uno y dos: {num1} {num2} Escrito por interpolación");

        Console.WriteLine("Los números uno y dos: " 
            + num1 + " " + num2 + " Escrito con Concatenación");

        Console.WriteLine("Los numeros uno y dos: {0} {1} Escrito por índices", 
            num1, num2);
    }
}