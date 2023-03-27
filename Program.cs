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
            int year = 2023;
            double decimales = 2.5;
            string nombre = "Julio";
            Console.WriteLine("Hola Julio, en Hotmart estamos en el año: " + year);
            Console.WriteLine("Otra forma de mostrar datos: es el año {0} y el decimal {1}", year,decimales);
            Console.WriteLine("Hola {1}, en Hotmart estamos en el año: {0}",year,nombre);

            Console.ReadLine();
        }
    }
}
