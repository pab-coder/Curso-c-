class DentroRango
{
    public static void Run()
    {
        EjemploDentroRango();
    }

    static void EjemploDentroRango()
    {
        //Ejercicio dentro de rango
        //Definir variables
        var minimo = 0;
        var maximo = 5;
        //Se solicita valores entre 0 y 5
        Console.Write("Proporciona un dato entre 0 y 5:  ");
        var dato = Convert.ToInt32(Console.ReadLine());
        // se hace la Validacion si el dato esta dentro del rango
        var dentroRango = dato >= minimo && dato <= maximo;
        Console.WriteLine($"Valor dentro de rango? {dentroRango}");

        //Se estudia la precedencia de operadores
        var d = 12 / 3 + 2 * 3 - 1;
        //paso 1. se realizala division 12/3 = 4
        //paso 2. se realiza la multiplicacion 2 * 3 = 6
        //paso 3. se realiza la suma de los dos primero resultado 4 + 6 = 10
        //paso 4. se realiza la resta de la suma de 10 - 1 
        Console.WriteLine($"Valor de d es: {d}");
    }
}