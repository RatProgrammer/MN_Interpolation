using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpolacja
{
    class Program
    {
        static void Main(string[] args)
        {
            LagrangeInterpolacja lagrangeInterpolacja=new LagrangeInterpolacja();

           double wynik= lagrangeInterpolacja.Lagrangea(1);
            Console.WriteLine(wynik);
            Console.ReadKey();
        }
    }
}
