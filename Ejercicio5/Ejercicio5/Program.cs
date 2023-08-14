using System;

namespace Ejercicio5
{
    class Program
    {
        // Método para convertir un número decimal a binario
        static string ConvertirDecimalABinario(int numeroDecimal)
        {
            if (numeroDecimal == 0)
                return "0";

            string binario = "";

            // Realizar la conversión de decimal a binario utilizando divisiones sucesivas entre 2
            while (numeroDecimal > 0)
            {
                int residuo = numeroDecimal % 2;
                binario = residuo.ToString() + binario;
                numeroDecimal /= 2;
            }

            return binario;
        }

        static void Main(string[] args)
        {
            Console.Write("Ingrese un número decimal para convertir a binario: ");
            int numeroDecimal = Convert.ToInt32(Console.ReadLine());

            string binario = ConvertirDecimalABinario(numeroDecimal);

            Console.WriteLine($"El número decimal {numeroDecimal} en binario es: {binario}");

            // Esperar a que el usuario presione una tecla antes de salir
            Console.WriteLine("Presione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
