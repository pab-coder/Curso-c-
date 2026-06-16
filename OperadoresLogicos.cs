class OperadoresLogicos
{
    public static void Run()
    {
        ImprimirOperadoresLogicos();
    }

    static void ImprimirOperadoresLogicos()
    {
        //Operadores Logicos
        var a = true;
        var b = false;
        Console.WriteLine($"Valor a: {a}");
        Console.WriteLine($"Valor a: {b}");

        //Operador lógico && (and o Y)
        //Regresa TRUE si ambos operandos son True
        var c = a && b;
        Console.WriteLine($"Valor de a y b son True?: {c}");

        //Operador Lógico || (or u O)
        c = a || b;
        Console.WriteLine($"Valor de a o b son True?: {c}");

        //Operador Lógico ! (Not o NO)
        c = !a;
        Console.WriteLine($"Valor de a Negada es True?: {c}");
        c = !b;
        Console.WriteLine($"Valor de b Negada es False?: {c}");
    }
}