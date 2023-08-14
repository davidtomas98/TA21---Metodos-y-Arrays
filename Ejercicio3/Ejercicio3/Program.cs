using System;

namespace Ejercicio3
{
    class Program
    {
        // Método para verificar si un número es primo
        static bool EsNumeroPrimo(int numero)
        {
            // Los números menores o iguales a 1 no son primos
            if (numero <= 1)
                return false;

            // Verificar si el número es divisible por algún número desde 2 hasta la raíz cuadrada de ese número
            for (int i = 2; i * i <= numero; i++)
            {
                if (numero % i == 0)
                    return false;
            }
            return true;
        }

        static void Main(string[] args)
        {
            Console.Write("Ingrese un número para verificar si es primo: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            bool esPrimo = EsNumeroPrimo(numero);

            Console.WriteLine();

            if (esPrimo)
            {
                Console.WriteLine($"{numero} es un número primo.");
            }
            else
            {
                Console.WriteLine($"{numero} no es un número primo.");
            }
            // Esperar a que el usuario presione una tecla antes de salir
            Console.WriteLine("Presione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
