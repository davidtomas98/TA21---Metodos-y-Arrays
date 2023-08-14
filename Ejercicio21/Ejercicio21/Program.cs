using System;

namespace Ejercicio21
{
    class Program
    {
        private static Random random = new Random();

        // Método para generar un número aleatorio entre min (inclusive) y max (inclusive)
        private static int GenerarNumeroAleatorio(int min, int max)
        {
            return random.Next(min, max + 1);
        }

        // Método para filtrar y mostrar números que terminan en un dígito específico
        static void FiltrarYMostrarNumeros(int[] array, int digito)
        {
            Console.WriteLine($"Números en el array que terminan en {digito}:");

            foreach (int numero in array)
            {
                if (numero % 10 == digito)
                {
                    Console.WriteLine(numero);
                }
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Ingrese el tamaño del array: ");
            int tamaño = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[tamaño];

            // Rellenar el array con números aleatorios entre 1 y 300
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = GenerarNumeroAleatorio(1, 300);
            }

            Console.Write("Ingrese el dígito para filtrar los números (0-9): ");
            int digito = Convert.ToInt32(Console.ReadLine());

            // Validar que el dígito esté en el rango correcto (0-9)
            if (digito >= 0 && digito <= 9)
            {
                FiltrarYMostrarNumeros(array, digito);
            }
            else
            {
                Console.WriteLine("Dígito inválido. Ingrese un dígito entre 0 y 9.");
            }

            // Esperar a que el usuario presione una tecla antes de salir
            Console.WriteLine("Presione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
