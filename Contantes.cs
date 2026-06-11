class Constantes
{
    public static void Run()
    {
        ImprimirDatosConstantes();
    }

    static void ImprimirDatosConstantes()
    {
        //Definir Constante con palabra reservada const
        const int MI_CONSTANTE = 10;
        Console.WriteLine($"Mi Constante: {MI_CONSTANTE}");
        // MI_CONSTANTE =20; la variable declarada como constante no puede ser modificada

        //Declaraco de Constante PI
        const float PI = 3.1416F;
        Console.WriteLine($"Mi Constante: {PI}");

        // Constante PI pero con uso de la clase Math
        Console.WriteLine($"Mi Constante Math.PI: {Math.PI}");

        // Constanbte de segundos por minuto

        const int SEGUNDOS_POR_MINUTO = 60;
        Console.WriteLine($"Constante segundos por minuto: {SEGUNDOS_POR_MINUTO}");
    }
}