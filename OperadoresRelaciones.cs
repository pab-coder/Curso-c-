class OperadoresRelacionales
{
    public static void Run()
    {
        ImprimirOperadoresRelaciones();
    }

    static void ImprimirOperadoresRelaciones()
    {
        //Operadores Relacionales (Comparacion)
        var a = 5;
        var b = 6;
        Console.WriteLine($"Valor de a: {a}");
        Console.WriteLine($"Valor de a: {b}");
        //Operador de igualdad ==
        var c = a==b;
        Console.WriteLine($"a igual que b? {c}");
        //Operador distinto !=
        c = a != b;
        Console.WriteLine($"a distinto que b? {c}");
        //Operador Mayor que
        c = a > b;
        Console.WriteLine($"a es Mayor que b? {c}");
        // Operador menor que
        c = a < b;
        Console.WriteLine($"a es menor que b? {c}");
        //Operador menor o igual que
        c = a <= b;
        Console.WriteLine($"a es menor o igual que b? {c}");
        // Operador mayor o igual que
         c = a >= b;
        Console.WriteLine($"a es Mayor o igual que b? {c}");
    }
}