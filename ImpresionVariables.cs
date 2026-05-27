using System;

class ImpresionVariables
{
    public static void Run()
    {
        ImprimirVariables();
    }

    static void ImprimirVariables()
    {
        int num1 = 10;
        int num2 = 20;

        Console.WriteLine($"Los numeros uno y dos: {num1} {num2} Escrito por interpolación");

        Console.WriteLine("Los números uno y dos: " 
            + num1 + " " + num2 + " Escrito con Concatenación");

        Console.WriteLine("Los numeros uno y dos: {0} {1} Escrito por índices", 
            num1, num2);
    }
}