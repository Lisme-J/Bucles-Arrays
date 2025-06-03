using System;
// Crear un programa que lea una contraseña, si es incorrecta, mostrar un mensaje que lo indique
// y tenga como máximo 3 intentos, luego después de esos intentos, mostrar un mensaje indicando
// que ha agotado el numero de intentos y el programa debe terminar.

class Program
{
    static void Main()
    {
        string contraseñaCorrecta = "clave123";
        string intento;
        int intentos = 0;
        int maxIntentos = 3;
        bool accesoConcedido = false;

        while (intentos < maxIntentos)
        {
            Console.Write("Ingrese la contraseña: ");
            intento = Console.ReadLine();

            if (intento == contraseñaCorrecta)
            {
                Console.WriteLine("¡Contraseña correcta! Acceso concedido.");
                accesoConcedido = true;
                break;
            }
            else
            {
                Console.WriteLine("Contraseña incorrecta.");
                intentos++;
            }
        }

        if (!accesoConcedido)
        {
            Console.WriteLine("Ha agotado el número de intentos. El programa ha terminado.");
        }
    }
}
