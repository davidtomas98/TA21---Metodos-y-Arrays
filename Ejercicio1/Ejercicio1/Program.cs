using System;

namespace Ejercicio1
{
    class Program
    {
        // Método para calcular el área de un círculo
        static double CalcularAreaCirculo(double radio)
        {
            return Math.PI * Math.Pow(radio, 2);
        }

        // Método para calcular el área de un triángulo
        static double CalcularAreaTriangulo(double baseTriangulo, double altura)
        {
            return (baseTriangulo * altura) / 2;
        }

        // Método para calcular el área de un cuadrado
        static double CalcularAreaCuadrado(double lado)
        {
            return lado * lado;
        }

        static void Main(string[] args)
        {
            Console.Write("Ingrese la figura para la que desea calcular el área (circulo/triangulo/cuadrado): ");
            string figura = Console.ReadLine().ToLower();

            double area = 0;

            switch (figura)
            {
                case "circulo":
                    Console.Write("Ingrese el radio del círculo: ");
                    double radio = Convert.ToDouble(Console.ReadLine());
                    area = CalcularAreaCirculo(radio);
                    break;
                case "triangulo":
                    Console.Write("Ingrese la base del triángulo: ");
                    double baseTriangulo = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Ingrese la altura del triángulo: ");
                    double altura = Convert.ToDouble(Console.ReadLine());
                    area = CalcularAreaTriangulo(baseTriangulo, altura);
                    break;
                case "cuadrado":
                    Console.Write("Ingrese el lado del cuadrado: ");
                    double lado = Convert.ToDouble(Console.ReadLine());
                    area = CalcularAreaCuadrado(lado);
                    break;
                default:
                    Console.WriteLine("Figura no válida");
                    return;
            }

            // Mostrar el resultado del cálculo del área
            Console.WriteLine($"El área del {figura} es: {area}");

            // Esperar a que el usuario presione una tecla antes de salir
            Console.WriteLine("Presione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
