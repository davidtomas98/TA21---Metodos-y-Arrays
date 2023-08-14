using System;

namespace Ejercicio14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la longitud del array: ");
            int longitud = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[longitud];

            // Generar números aleatorios entre 1 y 10 y llenar el array
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 11);
            }

            Console.Write("Ingrese un número para buscar en el array: ");
            int numeroBusqueda = Convert.ToInt32(Console.ReadLine());

            bool encontrado = false;

            // Verificar si el número de búsqueda existe en el array
            foreach (int elemento in array)
            {
                if (elemento == numeroBusqueda)
                {
                    encontrado = true;
                    break;
                }
            }

            if (encontrado)
            {
                Console.WriteLine($"El número {numeroBusqueda} existe en el array.");
            }
            else
            {
                Console.WriteLine($"El número {numeroBusqueda} no existe en el array.");
            }

            // Esperar a que el usuario presione una tecla antes de salir
            Console.WriteLine("Presione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
