class EjercicioTipoDeDatos
{
    public static void Run()
    {
        ImprimirEjercicio();
    }

    static void ImprimirEjercicio()
    {
        //Ejercisio tipo de datos

        //Leer los valores
        Console.Write($"Escribe tu nombre: ");
        var nombre = Console.ReadLine();
        Console.Write($"Escribe tu edad: ");
        var edad = Convert.ToInt32(Console.ReadLine());
        Console.Write($"Escribe tu sueldo en USD: ");
        var sueldo = Convert.ToDouble(Console.ReadLine());
        Console.Write($"Eres un empleado de confianza (true/false): ");
        var empleadoDeConfianza = Convert.ToBoolean(Console.ReadLine());

        //Imprimir valores
        Console.WriteLine($"La informacion proporcionada es: ");
        Console.WriteLine($"Nombre: {nombre}");
        Console.WriteLine($"Edad: {edad} ");
        Console.WriteLine($"Sueldo: {sueldo:C2}"); // Currency nos da el formato de moneda
        Console.WriteLine($"Eres de confianza: {empleadoDeConfianza} ");
    }
}