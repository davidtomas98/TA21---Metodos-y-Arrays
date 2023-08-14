using System;

namespace Ejercicio17
{
    class Program
    {
        // Método para rellenar valores en un array
        static void RellenarArray(int[] array)
        {
            Console.WriteLine("Ingrese los valores para el array:");

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Elemento {i}: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        // Método para mostrar el contenido de un array
        static void MostrarArray(int[] array)
        {
            Console.WriteLine("Contenido del array:");

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Índice {i}: Valor {array[i]}");
            }
        }

        static void Main(string[] args)
        {
            int[] array = new int[10];

            RellenarArray(array);
            MostrarArray(array);

            // Esperar a que el usuario presione una tecla antes de salir
            Console.WriteLine("Presione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
