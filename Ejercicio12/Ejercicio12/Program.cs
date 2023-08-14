using System;

namespace Ejercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            int suma = 0;

            // Solicitar valores al usuario y calcular la suma
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Ingrese el valor para la posición {i}: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
                suma += array[i];
            }

            // Calcular la media y mostrarla
            double media = (double)suma / array.Length;
            Console.WriteLine($"La media de los valores en el array es: {media}");

            // Esperar a que el usuario presione una tecla antes de salir
            Console.WriteLine("Presione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
