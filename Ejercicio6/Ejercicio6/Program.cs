using System;

namespace Ejercicio6
{
    class Program
    {
        // Método para contar el número de cifras en un número entero positivo
        static int ContarCifras(int numero)
        {
            if (numero == 0)
                return 1;

            int cifras = 0;

            // Realizar el conteo de cifras dividiendo sucesivamente entre 10
            while (numero > 0)
            {
                cifras++;
                numero /= 10;
            }

            return cifras;
        }

        static void Main(string[] args)
        {
            Console.Write("Ingrese un número entero positivo para contar sus cifras: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero < 0)
            {
                Console.WriteLine("Por favor, ingrese un número entero positivo.");
            }
            else
            {
                int cifras = ContarCifras(numero);
                Console.WriteLine($"El número {numero} tiene {cifras} cifras.");

                // Esperar a que el usuario presione una tecla antes de salir
                Console.WriteLine("Presione cualquier tecla para salir...");
                Console.ReadKey();
            }
        }
    }
}
