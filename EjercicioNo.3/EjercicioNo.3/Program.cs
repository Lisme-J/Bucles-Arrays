using System;

// Crear un programa que lea n cantidad de números enteros, si la sumatoria es
// mayor o igual a 100, el programa debe mostrar un mensaje indicando que la
// sumatoria es mayor o igual a 100.

class Program
{
    static void Main()
    {
        int n, numero, suma = 0;

        Console.Write("Ingrese la cantidad de números: ");
        n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.Write($"Ingrese el número {i}: ");
            numero = int.Parse(Console.ReadLine());
            suma += numero;
        }

        Console.WriteLine($"\nLa sumatoria total es: {suma}");

        if (suma >= 100)
        {
            Console.WriteLine("La sumatoria es mayor o igual a 100.");
        }
        else
        {
            Console.WriteLine("La sumatoria es menor que 100.");
        }
    }
}

