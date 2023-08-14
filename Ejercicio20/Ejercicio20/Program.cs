using System;

namespace Ejercicio20
{
    class Program
    {
        private static Random random = new Random();

        // Método para generar un número aleatorio entre min (inclusive) y max (exclusive)
        private static int GenerarNumeroAleatorio(int min, int max)
        {
            return random.Next(min, max);
        }

        // Método para rellenar un array con números aleatorios
        static void RellenarArray(int[] array, int min, int max)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = GenerarNumeroAleatorio(min, max);
            }
        }

        // Método para multiplicar elementos de dos arrays y devolver el resultado en un nuevo array
        static int[] MultiplicarArrays(int[] array1, int[] array2)
        {
            int[] resultado = new int[array1.Length];

            for (int i = 0; i < array1.Length; i++)
            {
                resultado[i] = array1[i] * array2[i];
            }

            return resultado;
        }

        static void Main(string[] args)
        {
            Console.Write("Ingrese la longitud de los arrays: ");
            int longitud = Convert.ToInt32(Console.ReadLine());

            int[] array1 = new int[longitud];
            int[] array2 = array1; // array2 apunta al mismo array que array1

            // Rellenar el primer array con números aleatorios
            RellenarArray(array1, 1, 11);

            // Crear un nuevo array y rellenarlo con números aleatorios
            int[] array3 = new int[longitud];
            RellenarArray(array3, 1, 11);

            // Multiplicar los elementos de array1 y array3
            int[] resultadoMultiplicacion = MultiplicarArrays(array1, array3);

            // Mostrar el contenido de cada array
            Console.WriteLine("Contenido del primer array:");

            foreach (int elemento in array1)
            {
                Console.WriteLine(elemento);
            }

            Console.WriteLine("\nContenido del segundo array (apuntando al primer array):");

            foreach (int elemento in array2)
            {
                Console.WriteLine(elemento);
            }

            Console.WriteLine("\nContenido del tercer array (creado de nuevo):");

            foreach (int elemento in array3)
            {
                Console.WriteLine(elemento);
            }

            Console.WriteLine("\nResultado de la multiplicación:");

            foreach (int elemento in resultadoMultiplicacion)
            {
                Console.WriteLine(elemento);
            }

            // Esperar a que el usuario presione una tecla antes de salir
            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
