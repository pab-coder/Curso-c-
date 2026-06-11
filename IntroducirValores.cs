class IntroducirValores
{
    public static void Run()
    {
        ImprimirValoresIntroducidos();
    }

    static void ImprimirValoresIntroducidos()
    {
        // Leer datos del usuario
        Console.Write($"Escribe algo: "); // peticion a usuario a escribir dato
        var cadena = Console.ReadLine(); // se almacena en variable cadena lo que escribio el usuario

        // imprime el valo introducido
        Console.WriteLine($"Tu escribiste: {cadena}");

    }
}