using System;

namespace Ejercicio8
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
                array[i] = i;
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
