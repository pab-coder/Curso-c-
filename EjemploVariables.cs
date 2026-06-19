using System.Runtime.InteropServices;

class EjemploVariables
{
    public static void Run()
    {
        EjemploPracticoVariables();
    }

    static void EjemploPracticoVariables()
    {
        Console.Clear();
        Console.WriteLine("Utilizaremos ejemplos en concatenació, suma o resta");
        Console.WriteLine();
        Console.Write("Asigne cualquier numero a la variable var a: ");
        var a = Console.ReadLine();
        Console.Write("Asigne cualquier numero a la variable var b: ");
        var b = Console.ReadLine();
        var resultado = a + b;
        Console.WriteLine("Dentro de la variable resultado asignamos la suma de a t b");
        Console.WriteLine($"Valor de {a} + {b} es: {resultado}");
        Console.WriteLine($"Podemos concatenar texto y numeros para mostrar datos en pantalla");
        Console.WriteLine();

        Console.WriteLine("Para ejemplo se declaran las variables num1 = 10 y num2 = 20 tipo int");
        int num1 = 10;
        int num2 = 20;

        Console.WriteLine($"Los numeros uno y dos: {num1} {num2} Escrito por interpolación");

        Console.WriteLine("Los números uno y dos: "
            + num1 + " " + num2 + " Escrito con Concatenación");

        Console.WriteLine("Los numeros uno y dos: {0} {1} Escrito por índices",
            num1, num2);



        Console.Write("\nPresione una tecla para regresar...");
        Console.ReadKey();
        Console.Clear();
        VariablesTemas.MostrarTemas();
    }
}