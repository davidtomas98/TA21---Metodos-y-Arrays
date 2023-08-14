using System;

namespace Ejercicio7
{
    class Program
    {
        // Método para convertir una cantidad de euros a otra moneda
        static void ConvertirDivisa(double cantidadEuros, string monedaDestino)
        {
            double cambio = 0;

            // Determinar el cambio de divisas según la moneda destino
            switch (monedaDestino.ToLower())
            {
                case "libras":
                    cambio = 0.86;
                    break;
                case "dolares":
                    cambio = 1.28611;
                    break;
                case "yenes":
                    cambio = 129.852;
                    break;
                default:
                    Console.WriteLine("Moneda destino no válida.");
                    return;
            }

            double cantidadConvertida = cantidadEuros * cambio;

            Console.WriteLine($"{cantidadEuros} euros equivale a {cantidadConvertida} {monedaDestino}.");
        }

        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad de euros a convertir: ");
            double cantidadEuros = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese la moneda destino (libras/dolares/yenes): ");
            string monedaDestino = Console.ReadLine();

            ConvertirDivisa(cantidadEuros, monedaDestino);

            // Esperar a que el usuario presione una tecla antes de salir
            Console.WriteLine("Presione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
