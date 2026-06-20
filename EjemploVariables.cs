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
        Console.WriteLine("A continuación ingrese la información que se le pide");
        Console.WriteLine();
        Console.Write("Asigne valor a: ");
        var a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Asigne valor b: ");
        var b = Convert.ToInt32(Console.ReadLine());
        var resultado = a + b;
        Console.WriteLine("Dentro de la variable resultado asignamos la suma de a y b");
        Console.WriteLine($"Resultado de {a} + {b} es: {resultado}");
        Console.WriteLine($"Podemos concatenar texto y numeros para mostrar datos en pantalla");
        Console.WriteLine($"Cabe destacar que al ingresr los valores estos se toman como una cadena");
        Console.WriteLine($"Estos valores se convirtieron a tipo int para resolver la operación");
        Console.WriteLine();

        
        int num1 = 10;
        int num2 = 20;
        Console.WriteLine("En este ejemplo se declaran las variables tipo int ");
        Console.WriteLine("num1 = 10 y num2 = 20 tipo int");
        Console.WriteLine("Podemos agregar estas variables a una cadena de texto de manera concatenada");
        Console.WriteLine();
        Console.WriteLine("Uso de Interpolation");
        Console.WriteLine($"Las variables num1 y num2: {num1} y {num2} Escrito por interpolación");
        Console.WriteLine("se agregar a nuestra cadena ($''Texto {num1} y {num2}'')  y queda por interpolación,");
        Console.WriteLine("al usar interpolation nos ayuda a tener valores de variables sin tener que concatenar.");
        Console.WriteLine();
        Console.WriteLine("Uso de Concatenación");
        Console.WriteLine("Los números uno y dos: " + num1 + " y " + num2 + " Escrito con Concatenación");
        Console.WriteLine("La diferencia en la concatenación es que se debe cerrar entre comillas dobles agregar símbolo +");
        Console.WriteLine("abrir y cerrar comillas para concatenar tanto se desee en la cadena.");
        Console.WriteLine("Los números uno y dos: ' + num1 + ' y ' + num2 + ' Escrito con Concatenación");
        Console.WriteLine();
        Console.WriteLine("Uso de Indices");
        Console.WriteLine("El uso de índices se agrega después de la cadena con separación con comas");
        Console.WriteLine("(Los numeros uno y dos: {0} {1} Escrito por índices,num1, num2)");
        Console.WriteLine("Los numeros uno y dos: {0} {1} Escrito por índices",num1, num2);



        Console.Write("\nPresione una tecla para regresar...");
        Console.ReadKey();
        Console.Clear();
        VariablesTemas.MostrarTemas();
    }
}