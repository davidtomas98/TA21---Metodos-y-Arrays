using System;

namespace Ejercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la longitud del array: ");
            int longitud = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[longitud];

            Console.WriteLine("Ingrese los valores para el array:");

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Elemento {i}: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            bool esCapicua = true;

            // Verificar si el array es capicúa
            for (int i = 0; i < array.Length / 2; i++)
            {
                if (array[i] != array[array.Length - 1 - i])
                {
                    esCapicua = false;
                    break;
                }
            }

            if (esCapicua)
            {
                Console.WriteLine("El array es capicúa.");
            }
            else
            {
                Console.WriteLine("El array no es capicúa.");
            }

            // Esperar a que el usuario presione una tecla antes de salir
            Console.WriteLine("Presione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
