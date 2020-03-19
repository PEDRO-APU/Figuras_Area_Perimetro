using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    class Triangulo : Figura
    {
        private double a { get; set; }
        private double b { get; set; }
        private double c { get; set; }
        public Triangulo(double _a, double _b, double _c)
        {
            this.a = _a;
            this.b = _b;
            this.c = _c;
        }
        public override double calcularPerimetro()
        {
            double p = 0;
            try
            {
                
                return p = a + b + c;
            }catch(Exception e)
            {
                Console.WriteLine(e);
            }
            return p;
        }
        public double calcularAltura()
        {
            double h = 0;
            double op1 = 0;
            double op2 = 0;
            op1 = Math.Pow(a,2);
            op2 = Math.Pow(c / 2, 2);
            return h = Math.Sqrt(op1-op2);

        }
        public override double calcularArea()
        {
            double area = 0;
            return area = (c * calcularAltura()) / 2;
        }
        public override  String mostrarResultado()
        {
            return "Perimetro: " + calcularPerimetro() + "  Area: " + calcularArea();
        }

    }
}
