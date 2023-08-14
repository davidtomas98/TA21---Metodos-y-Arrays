using System;

namespace Ejercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la longitud del array: ");
            int longitud = Convert.ToInt32(Console.ReadLine());

            int[] arrayOriginal = new int[longitud];
            int[] arrayInvertido = new int[longitud];

            Console.WriteLine("Ingrese los valores para el array:");

            for (int i = 0; i < arrayOriginal.Length; i++)
            {
                Console.Write($"Elemento {i}: ");
                arrayOriginal[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Invertir los valores del array original y llenar el array invertido
            for (int i = 0; i < arrayOriginal.Length; i++)
            {
                arrayInvertido[i] = arrayOriginal[arrayOriginal.Length - 1 - i];
            }

            Console.WriteLine("Contenido del array invertido:");

            foreach (int elemento in arrayInvertido)
            {
                Console.WriteLine(elemento);
            }

            // Esperar a que el usuario presione una tecla antes de salir
            Console.WriteLine("Presione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
