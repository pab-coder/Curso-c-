class TiposDinamicos
{
    public static void Run()
    {
        ImprimirDatosDinamicos();
    }

    static void ImprimirDatosDinamicos()
    {
        //Declaracion de variable con VAR, al declarar solo toma el valor el cual es declarado
        //var miNumero = 10;
        //Console.WriteLine($"Variable Entero con VAR: {miNumero}");

        // Con Dynamic se puede modificar el valor de la variable de entero a string
        dynamic miNumero = 10;

        Console.WriteLine($"Valor: {miNumero}");
        Console.WriteLine($"Tipo: {miNumero.GetType()}");

        miNumero = "Hola";

        Console.WriteLine($"Valor: {miNumero}");
        Console.WriteLine($"Tipo: {miNumero.GetType()}");

        //mi cadena (string)
        dynamic miCadena = "Hola Mundo";
        //miCadena = 10; no procede a dar informacion de la cadena a un dato tipo int
        Console.WriteLine($"Mi cadena: {miCadena}");
        Console.WriteLine($"Largo cadena: {miCadena.Length}");

    }
}