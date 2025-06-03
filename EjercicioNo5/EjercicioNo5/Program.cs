using System;

// Calcular la suma de los primeros 100 numeros naturales.
class Program
{
    static void Main()
    {
        int suma = 0;

        for (int i = 1; i <= 100; i++)
        {
            suma += i;
        }

        Console.WriteLine("La suma de los primeros 100 números naturales es: " + suma);
    }
}

