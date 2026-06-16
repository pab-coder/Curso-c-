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

        
    }
}