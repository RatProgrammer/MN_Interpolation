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
            NewtonInterpolacja newtonInterpolacja = new NewtonInterpolacja();
            newtonInterpolacja.Newton(0, 3, 1, 1);
        }
    }
}
