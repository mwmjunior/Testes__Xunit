using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{
    public static class Calculo
    {
        public static double Somar(double x, double y)
        {
            return (x + y);
        }
        public static double Subtrair(double x, double y)
        {
            return (x - y);
        }
        public static double Divisao(double x, double y)
        {
            return (x / y);
        }
        public static double Multiplicacao(double x, double y)
        {
            return (x * y);
        }
        public static double[] Baskara( double b, double a, double c)
        {
            double delta = ((b * b) - (4 * a * c));

            double X1 = (-b + Math.Sqrt(delta) / 2 * a);
            double X2 = (-b - Math.Sqrt(delta) / 2 * a);

            return new double[] { X1, X2 };


        }



    }
}
