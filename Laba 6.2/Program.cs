using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_6._2
{
    using System;

    class Program
    {
        static void Main()
        {
            
            double x = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());

           
            double y = CalculateY(x, b);

            
            Console.WriteLine(y);
        }

        static double CalculateY(double x, double b)
        {
            double a = A(x, b);
            double c = C(a, b);
            return Math.Pow(c, 3) / Math.Cos(c);
        }

       
        static double A(double x, double b)
        {
            return Math.Sqrt(x) + Math.Exp(Math.Sqrt(b));
        }

        static double C(double a, double b)
        {
            return Math.Pow(a, 2) + Math.Pow(b, 2);
        }
    }
}






