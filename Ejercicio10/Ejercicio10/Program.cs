using System;

namespace Ejercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un número para mostrar su tabla de multiplicar hasta el 10: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Tabla de multiplicar del {numero}:");

            // Generar y mostrar la tabla de multiplicar hasta 10
            for (int i = 0; i <= 10; i++)
            {
                int resultado = numero * i;
                Console.WriteLine($"{numero} * {i} = {resultado}");
            }

            // Esperar a que el usuario presione una tecla antes de salir
            Console.WriteLine("Presione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
