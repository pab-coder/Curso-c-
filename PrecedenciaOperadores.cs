class PrecedenciaOperadores
{
    public static void Run()
    {
        PrecedenciaDeOperadores();
    }

    static void PrecedenciaDeOperadores()
    {
        //Se estudia la precedencia de operadores

        var a = 12 / 3 + 2 * 3 - 1;
        //paso 1. se realizala division 12/3 = 4
        //paso 2. se realiza la multiplicacion 2 * 3 = 6
        //paso 3. se realiza la suma de los dos primero resultado 4 + 6 = 10
        //paso 4. se realiza la resta de la suma de 10 - 1 
        Console.WriteLine($"Valor de a es: {a}");

        // Se hace ejemplo con operadores relacionales
        var b = 12 < 10 && 15 >= 15 ;
        Console.WriteLine($"Valor de b es: {b}");

        var c = 0 ;
        var d = 15;
        var operaciones =  --c * --d ;
        //Paso 1. El valor de c se Pre decrementa para obtener el valor ntes de realizar operacion 
        //Paso 2. El valor de d se Pre decrementa para obtener el valor antes de la operacion
        //Paso 3. La operacion se ejecuta cuando los valores ya estan definidos
        Console.WriteLine($"Valor de la operacion: {operaciones}");

        var e = 12;
        var f = 10;
        e += 2;
        f -= 1;
        var resultado = e * f;
        //La coordinacion para resolver el resultado es:
        //Primero. hacer la asignacion de la variables e=14 y f=9
        //Segundo. Con la variables resultas se puede hacer la multiplicacion
        //Tercero. Resolviendo las operaciones de manera atómica nos ayuda a llegar al camino que buscamos 
        Console.WriteLine($"Valor de resultado: {resultado}");
    }
}