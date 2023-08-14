using System;

namespace Ejercicio4
{
    class Program
    {
        // Método para calcular el factorial de un número
        static int CalcularFactorial(int numero)
        {
            if (numero <= 1)
                return 1;

            int factorial = 1;
            for (int i = 2; i <= numero; i++)
            {
                factorial *= i;
            }
            return factorial;
        }

        static void Main(string[] args)
        {
            Console.Write("Ingrese un número para calcular su factorial: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            int factorial = CalcularFactorial(numero);

            Console.WriteLine($"El factorial de {numero} es: {factorial}");
            
            // Esperar a que el usuario presione una tecla antes de salir
            Console.WriteLine("Presione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
