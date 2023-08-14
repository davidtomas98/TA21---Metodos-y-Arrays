using System;

namespace Ejercicio2
{
    class Program
    {
        // Método para generar un número entero aleatorio dentro de un rango
        static int GenerarNumeroAleatorio(int minimo, int maximo)
        {
            Random random = new Random();
            return random.Next(minimo, maximo + 1);
        }

        static void Main(string[] args)
        {
            Console.Write("Ingrese el valor mínimo para generar números aleatorios: ");
            int minimo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el valor máximo para generar números aleatorios: ");
            int maximo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese la cantidad de números aleatorios que desea generar: ");
            int cantidad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Números aleatorios generados:");

            // Generar y mostrar los números aleatorios
            for (int i = 0; i < cantidad; i++)
            {
                int numeroAleatorio = GenerarNumeroAleatorio(minimo, maximo);
                Console.WriteLine($"Número {i + 1}: {numeroAleatorio}");
            }

            // Esperar a que el usuario presione una tecla antes de salir
            Console.WriteLine("Presione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
