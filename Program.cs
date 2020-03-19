using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(" **************   TRIANGULO  ***************");
            String linea = "";
            int lado1, lado2,lado3;
            Console.Write("INGRESE LADO 1: "); linea = Console.ReadLine(); lado1 = int.Parse(linea);
            Console.Write("INGRESE LADO 2: "); linea = Console.ReadLine(); lado2 = int.Parse(linea);
            Console.Write("INGRESE LADO 3: "); linea = Console.ReadLine(); lado3 = int.Parse(linea);
            Triangulo t1 = new Triangulo(lado1, lado2, lado3);
            Console.WriteLine(t1.mostrarResultado());

            Console.WriteLine(" ***************  CUADRADO  *****************");
            int ladoCua;
            Console.Write("INGRESE 1 lado: "); linea = Console.ReadLine(); ladoCua = int.Parse(linea);
            Cuadrado c1 = new Cuadrado(ladoCua);
            Console.WriteLine(c1.mostrarResultado());

            Console.WriteLine(" ***************  RECTANGULO  *****************");
            int ladoBase, ladoAltura;
            Console.Write("INGRESE BASE: "); linea = Console.ReadLine(); ladoBase = int.Parse(linea);
            Console.Write("INGRESE ALTURA: "); linea = Console.ReadLine(); ladoAltura = int.Parse(linea);
            Rectangulo r1 = new Rectangulo(ladoBase, ladoAltura);
            Console.WriteLine(r1.mostrarResultado());
           
            Console.ReadKey();
        }
    }
}
