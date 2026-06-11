//Convertir entero a cadena y viceversa
class ConvertirTipoDeDatos
{
    public static void Run()
    {
        ImprimirValoresConvertidos();
    }

    static void ImprimirValoresConvertidos()
    {
        //Tipo Entero
        var miEntero = 10;
        Console.WriteLine($"Mi Entero: {miEntero}");

        // Convertir a cadena
        var cadena = Convert.ToString(miEntero);
        Console.WriteLine($"Entero convertido a cadena: {cadena}"); 

        //convertir valor tipo string a entero

        var miCadena = "20";
        var entero = Convert.ToInt32(miCadena);
        Console.WriteLine($"Mi cadena: {miCadena}");
        Console.WriteLine($"Mi cadena convertida a entero {entero}");   
    }
}