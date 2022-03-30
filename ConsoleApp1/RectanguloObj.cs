using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class RectanguloObj
    {
        private double x1, x2, x3;
        private double y1, y2, y3;

        public RectanguloObj(double x1, double x2, double x3, double y1, double y2, double y3) {
        
            this.x1 = x1;
            this.x2 = x2;
            this.x3 = x3;
            this.y1 = y1;
            this.y2 = y2;
            this.y3 = y3;

        }
         
        public double Punto1()
        {
            return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
        }

        public double Punto2()
        {
            return Math.Sqrt(Math.Pow((x3 - x2), 2) + Math.Pow((y3 - y2), 2));
        }

        public double Perimetro()
        {
            return 2 * (Punto1() + Punto2());
        }

        public double Area()
        {
            return Punto1() * Punto2();
        }
    }
}
