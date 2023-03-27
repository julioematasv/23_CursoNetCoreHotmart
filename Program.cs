using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoNetoreHotmart
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor1 = 3;
            int valor2 = 6;
            var suma = valor1 + valor2;
            Console.WriteLine("El valor de la suma es: {0}",suma);

            int year = 2023;
            double decimales = 2.5;
            string nombre = "Julio";
            Console.WriteLine("Hola Julio, en Hotmart estamos en el año: " + year);
            Console.WriteLine("Otra forma de mostrar datos: es el año {0} y el decimal {1}", year,decimales);
            Console.WriteLine("Hola {1}, en Hotmart estamos en el año: {0}",year,nombre);

            int totalSuma = Sumar(5, 10);
            Console.WriteLine("La suma de los dos números es: " + totalSuma);

            Console.WriteLine("Reutilizando la Función Sumar(): con diferentes valores");
            int totalSuma2 = Sumar(25, 15);
            Console.WriteLine("La suma de la segunda vez de la funcion es: " + totalSuma2);
            int totalSuma3 = Sumar(20, 55);
            Console.WriteLine("La suma de la tercera vez de la funcion es: " + totalSuma3);

            Console.ReadLine();
        }

        static int Sumar(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
