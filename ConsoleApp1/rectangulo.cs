using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class rectangulo
    {
        public double x1 { get; set; }
        public double x2 { get; set; }
        public double y1 { get; set; }
        public double y2 { get; set; }
        public double x3 { get; set; }
        public double y3 { get; set; }

        public double base_rec { get; set; }
        public double altu_rec { get; set; }

        public double calcularDistancia() {
            base_rec = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            return base_rec;
        }

        public double calcularDistancia2() {
            altu_rec = Math.Sqrt(Math.Pow((x3 - x2), 2) + Math.Pow((y3 - y2), 2));
            return altu_rec;
        }
    }
}
