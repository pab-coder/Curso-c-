class OperadoresIncrementeDecremento
{
    public static void Run()
    {
        ImprimirIncrementoDecremento();
    }

    static void ImprimirIncrementoDecremento()
    {
        //Operador de incremento ++
        var a = 0;
        
        //Operador de POST-incremento
        Console.WriteLine($"Valor de variable a = {a}");
        a++;
        Console.WriteLine($"Variable despues de incrementar (a++): {a}");
        //Operador de PRE-incremento
        a = 5;
        Console.WriteLine($"Valor de variable a = {a}");
        ++a;
        Console.WriteLine($"Variable antes de incrementar (++a): {a}");

        //Operador de decremento --
        //Operador despues de decremento
        var b = 10;
        Console.WriteLine($"Valor de Variable b = {b}");
        b--;
        Console.WriteLine($"Variable despues de decrementar (b--) {b}");
        
        //Operador antes de drecremento
        b = 20;
        Console.Write($"Valor de variable b = {b}");
        --b;
        Console.WriteLine($"Variable antes de decrementar (--b): {b}");
    }
}