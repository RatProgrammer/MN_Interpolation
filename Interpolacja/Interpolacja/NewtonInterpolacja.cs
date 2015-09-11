using System;

namespace Interpolacja
{
    public class NewtonInterpolacja
    {
        private double Funkcja(double x)
        {
            return Math.Exp(x);
        }
        public double[] Newton(double x0, int n, double h, double x)
        {

            var tabRoznicProgresywnych = TablicaRoznicProgresywnych(x0, n, h);
            var tabRoznicWstecznych = TablicaRoznicWstecznych(x0, n, h);

            double t = (x - x0) / h;
            double suma = 0;
            suma += Funkcja(x0);
            for (int i = 1; i < n; i++)
            {
                double iloczyn = 1;
                double silnia = 1;
                for (int j = 0; j < i; j++)
                {
                    iloczyn *= (t - j);
                    silnia *= j+1;
                }
                suma += tabRoznicProgresywnych[0,i]*(iloczyn/silnia);
            }
            var wynik = new double[2];
            wynik[0] = suma;

            suma = 0;
            t = (x - (n-1)) / h;
            t *= -1;
            suma += tabRoznicWstecznych[n-1,0];
            for (int i = 1; i < n-1; i++)
            {
                double iloczyn = 1;
                double silnia = 1;
                for (int j = 0; j < i; j++)
                {
                    iloczyn *= (-t + j);
                    silnia *= j + 1;
                }
                suma += tabRoznicWstecznych[n - 1, i] * (iloczyn / silnia);
            }
            wynik[1] = suma;
            return wynik;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x0">pierwszy wezeł</param>
        /// <param name="n">ilość węzłów</param>
        /// <param name="h">stała odległość między węzłami</param>
        /// <returns></returns>
        private double[,] TablicaRoznicProgresywnych(double x0, int n, double h)
        {
            double[,] tablicaRoznicProgresywnych = new double[n, n];

            for (int i = 0; i < n; i++)
            {
                double x = x0 + (h*i);
                tablicaRoznicProgresywnych[i, 0] = Funkcja(x);
            }
            for (int i = 1; i < n; i++)
            {
                for (int j = 0; j < n-i; j++)
                {
                    tablicaRoznicProgresywnych[j, i] = tablicaRoznicProgresywnych[j+1, i-1] - tablicaRoznicProgresywnych[j, i - 1];
                }
            }
            return tablicaRoznicProgresywnych;
        }

        private double[,] TablicaRoznicWstecznych(double x0, int n, double h)
        {
            double [,] tablicaRoznicProgresywnych = new double[n,n];
            for (int i = 0; i < n; i++)
            {
                double x = x0 + (h*i);
                tablicaRoznicProgresywnych[i, 0] = Funkcja(x);
            }
            for (int i = 1; i < n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    tablicaRoznicProgresywnych[n - j, i] = tablicaRoznicProgresywnych[n - j, i - 1] - tablicaRoznicProgresywnych[n - j - 1, i - 1];
                }
            }
            return tablicaRoznicProgresywnych;
        }
    }
}