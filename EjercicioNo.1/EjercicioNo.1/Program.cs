using System;

// Crear un programa que lea n cantidad de números enteros y determine cuantos son positivos,
// cuantos negativos, cuantos pares, cuantos impares, luego mostrar los resultados en pantalla.

class Program
{
    static void Main()
    {
        int n, numero;
        int positivos = 0, negativos = 0, pares = 0, impares = 0;

        Console.Write("Ingrese la cantidad de números: ");
        n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.Write($"Ingrese el número {i}: ");
            numero = int.Parse(Console.ReadLine());

            // Contar positivos y negativos
            if (numero > 0)
                positivos++;
            else if (numero < 0)
                negativos++;

            // Contar pares e impares
            if (numero % 2 == 0)
                pares++;
            else
                impares++;
        }

        Console.WriteLine("\n--- Resultados ---");
        Console.WriteLine($"Cantidad de números positivos: {positivos}");
        Console.WriteLine($"Cantidad de números negativos: {negativos}");
        Console.WriteLine($"Cantidad de números pares: {pares}");
        Console.WriteLine($"Cantidad de números impares: {impares}");
    }
}

