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
            /*
             //EJERCICIO 1
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

            double perimetro = 2 * (rectangulo_cal.calcularDistancia() + rectangulo_cal.calcularDistancia2());
            double area = rectangulo_cal.calcularDistancia() * rectangulo_cal.calcularDistancia2();


            Console.WriteLine("Perimetro: " + perimetro );
            Console.WriteLine("Área: " + area );

            Console.Read();
            */

            //EJERCICIO 2

            double x1, x2, x3;
            double y1, y2, y3;

            Console.WriteLine("Ingresar x1");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingresar y1");
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingresar x2");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingresar y2");
            y2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingresar x3");
            x3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingresar y3");
            y3 = Convert.ToDouble(Console.ReadLine());

            RectanguloObj rectanguloObj = new RectanguloObj(x1, x2, x3, y1, y2, y3);

            Console.WriteLine("Punto 1: " + rectanguloObj.Punto1());

            Console.WriteLine("Punto 2: " + rectanguloObj.Punto2());

            Console.WriteLine("Perimetro: " + rectanguloObj.Perimetro());

            Console.WriteLine("área: " + rectanguloObj.Area());

            Console.Read();

        }
    }
}
