using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    public class Cuadrado : Figura
    {
        private double a { get; set; }

        public Cuadrado(double a)
        {
            this.a = a;
        }
        public override double calcularPerimetro()
        {
            double p = 0;
            return p = 4 * a;
        }
        public override double calcularArea()
        {
            double area = 0;
            return area = Math.Pow(a,2);
        }
        public override String mostrarResultado()
        {
            return "Perimetro: " + calcularPerimetro() + "  Area: " + calcularArea();
        }

    }
}
