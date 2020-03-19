using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    class Rectangulo : Figura
    {
        private double a { get; set; }
        private double b{ get; set; }

        public Rectangulo(double _a, double _b)
        {
            this.a = _a;
            this.b = _b;
        }
        public override double calcularPerimetro()
        {
            double p = 0;
            return p = (2 * a) + (2 * b);
        }
        public override double calcularArea()
        {
            double area = 0;
            return area = a * b;
        }
        public override String mostrarResultado()
        {
            return "Perimetro: " + calcularPerimetro() + "  Area: " + calcularArea();
        }

    }
}
