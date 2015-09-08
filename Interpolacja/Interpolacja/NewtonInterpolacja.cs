using System;

namespace Interpolacja
{
    public class NewtonInterpolacja
    {
        private double[] X = new double[2] { 0, 2 };
        public double Newton(double x, double n)
        {

            double h = X[1] - X[0];//odległość miedzy wezłami- musi byc stała dla Newtona!

            double t = (x - X[0]) / h;
            for (int i = 0; i < n; i++)
            {
                //double wielomian = Funkcja(x0) + 
            }
            return 0;
        }

        private double Funkcja(double x)
        {
            return Math.Exp(x);
        }
        private double[,] TablicaRoznicprogresywnych(double x, int n, double h)
        {
            double[,] tablicaRoznicProgresywnych = new double[n + 1, n + 1];

            for (int i = 0; i < n; i++)
            {
                tablicaRoznicProgresywnych[i, 0] = Funkcja(X[i]);
            }
            for (int k = 1; k < n; k++)
            {
                for (int i = 1; i < n - k; i++)
                {
                    tablicaRoznicProgresywnych[i, k] = tablicaRoznicProgresywnych[i, k - 1];
                }
            }

            return new double[1,1];
        }
    }
}