using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpolacja
{
    public class LagrangeInterpolacja
    {
        private double[] X = new double[3] {1,-2,4};
        private double [] Y=new double[3] {3,5,7};
       

        

        public double Lagrangea(double x)
        {
            double iloczyn = 1;
            double suma = 0;
            double wynik = 0;
            double omega = 1;
            for (int i = 0; i < X.Length; i++)
            {
                
                for (int j = 0; j < X.Length; j++)
                {
                    if (j != i)
                    {
                        iloczyn *= X[i] - X[j];
                        omega *= (x - X[j]);
                    }
                }
                suma += Y[i]*(omega /  iloczyn);
            }
           
            return suma;
        }
    }
}
