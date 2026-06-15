class OperadoresAsignacion
{
    public static void Run()
    {
        ImprimirOperadoresAsignacion();
    }

    static void ImprimirOperadoresAsignacion()
    {
        //Operador de asignación de incremento
        var a = 10;
        Console.WriteLine($"Variable (a) con valor de: {a}");
        a += 1;
        Console.WriteLine($"Operador de asignacion += incrementa 1: {a}");
        a -= 2;
        Console.WriteLine($"Operador de asignacion -= decrementa 1: {a}");
        var resultado = a *= 2;
        Console.WriteLine($"Operador de asignacion *= multiplica por 2: {resultado}");
        a  /= 5;
        Console.WriteLine($"Operador de asignacion /= division {resultado} entre 5: {a}");
        a %=5;
        Console.WriteLine($"Operador de asignacion %= modulo o residuo {resultado} entre 5: {a}");


    }
}