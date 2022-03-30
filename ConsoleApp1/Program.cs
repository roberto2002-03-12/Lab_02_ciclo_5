using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresar coordenadas");
            
            rectangulo rectangulo_cal = new rectangulo();

            Console.WriteLine("Ingresar x1");
            rectangulo_cal.x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingresar y1");
            rectangulo_cal.y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingresar x2");
            rectangulo_cal.x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingresar y2");
            rectangulo_cal.y2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingresar x3");
            rectangulo_cal.x3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingresar y3");
            rectangulo_cal.y3 = Convert.ToDouble(Console.ReadLine());



            Console.WriteLine("Perimetro: " + 2*(rectangulo_cal.calcularDistancia() + rectangulo_cal.calcularDistancia2()) );
            Console.WriteLine("Área: " + (rectangulo_cal.calcularDistancia() * rectangulo_cal.calcularDistancia2()) );

            Console.Read();

        }
    }
}
