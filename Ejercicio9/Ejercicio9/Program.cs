using System;

namespace Ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la longitud del array: ");
            int longitud = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[longitud];

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Ingrese el valor para el elemento {i}: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Contenido del array:");

            foreach (int elemento in array)
            {
                Console.WriteLine(elemento);
            }

            // Esperar a que el usuario presione una tecla antes de salir
            Console.WriteLine("Presione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
