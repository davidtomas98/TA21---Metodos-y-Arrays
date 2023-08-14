using System;

namespace Ejercicio19
{
    class Program
    {
        private static Random random = new Random();

        // Método para comprobar si un número es primo
        private static bool EsPrimo(int numero)
        {
            if (numero <= 1)
                return false;

            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0)
                    return false;
            }

            return true;
        }

        // Método para rellenar el array con números primos entre min y max
        static void RellenarArrayPrimos(int[] array, int min, int max)
        {
            int contador = 0;

            while (contador < array.Length)
            {
                int numeroAleatorio = GenerarNumeroAleatorio(min, max);
                if (EsPrimo(numeroAleatorio))
                {
                    array[contador] = numeroAleatorio;
                    contador++;
                }
            }
        }

        // Método para generar un número aleatorio entre min (inclusive) y max (exclusive)
        private static int GenerarNumeroAleatorio(int min, int max)
        {
            return random.Next(min, max);
        }

        // Método para encontrar el mayor número en el array
        static int EncontrarMayor(int[] array)
        {
            int mayor = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > mayor)
                {
                    mayor = array[i];
                }
            }
            return mayor;
        }

        static void Main(string[] args)
        {
            Console.Write("Ingrese el tamaño del array: ");
            int tamaño = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el valor mínimo: ");
            int min = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el valor máximo: ");
            int max = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[tamaño];

            // Rellenar el array con números primos aleatorios entre min y max
            RellenarArrayPrimos(array, min, max);

            // Mostrar el contenido del array
            Console.WriteLine("Contenido del array:");

            foreach (int elemento in array)
            {
                Console.WriteLine(elemento);
            }

            // Encontrar y mostrar el mayor número en el array
            int mayor = EncontrarMayor(array);
            Console.WriteLine($"El mayor número en el array es: {mayor}");

            // Esperar a que el usuario presione una tecla antes de salir
            Console.WriteLine("Presione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
