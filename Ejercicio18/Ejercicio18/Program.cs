using System;

namespace Ejercicio18
{
    class Program
    {
        private static Random random = new Random();

        // Método privado para generar un número aleatorio entre min (inclusive) y max (exclusive)
        private static int GenerarNumeroAleatorio(int min, int max)
        {
            return random.Next(min, max);
        }

        // Método para rellenar el array con números aleatorios entre min y max
        static void RellenarArray(int[] array, int min, int max)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = GenerarNumeroAleatorio(min, max);
            }
        }

        // Método para mostrar el contenido y la suma del array
        static void MostrarArrayYSuma(int[] array)
        {
            Console.WriteLine("Contenido del array:");

            int suma = 0;
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Posición {i}: Valor {array[i]}");
                suma += array[i];
            }

            Console.WriteLine($"Suma total de los valores en el array: {suma}");
        }

        static void Main(string[] args)
        {
            Console.Write("Ingrese el tamaño del array: ");
            int tamaño = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[tamaño];

            // Rellenar el array con números aleatorios entre 0 y 9
            RellenarArray(array, 0, 10);

            // Mostrar el contenido y la suma del array
            MostrarArrayYSuma(array);

            // Esperar a que el usuario presione una tecla antes de salir
            Console.WriteLine("Presione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
