class OperadoresAritmeticos
{
    public static void Run()
    {
        ImprimirOperadoresArtirmeticos();
    }

    static void ImprimirOperadoresArtirmeticos()
    {
        //Operadores Aritmeticos
        //Suma +
        var a = 3 + 4;
        Console.WriteLine($"Suma: {a}");

        // Resta
        var b = 6 - 2;
        Console.WriteLine($"Resta con número negativo: {b}");

        // multiplicacion
        var c = a * 12;
        Console.WriteLine($"Multiplicacion con la variable a de la suma por 12: {c}");

        // Division
        var d = b / 2.5;
        Console.WriteLine($"Division con la variable b de la resta entre 2.5: {d}");

        //Modulo es el residuo de la operacion
        var f = 9 % 2;
        Console.WriteLine($"Residuo de la Division 9 / 2: {f}");

        //Potencia
        var e = Math.Pow(a, 2);
        Console.WriteLine($"La potencia de variable a al cuadrado: {e}");
    }
    
}


