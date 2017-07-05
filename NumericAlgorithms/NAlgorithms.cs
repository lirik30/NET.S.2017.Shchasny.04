using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace NumericAlgorithms
{
    public static class NAlgorithms
    {
        /// <summary>
        /// Computing accuracy
        /// </summary>
        private const double EPS = 1E-15;

        /// <summary>
        /// This method allows us to find the root n-th degree of the number 
        /// </summary>
        /// <param name="number">Number, from which we'll extract the root</param>
        /// <param name="n">Exponent</param>
        /// <returns>Result of operation, otherwise -1</returns>
        public static double FindRootOfNumber(double number, int n)
        {
            if (number < 0 || n <= 0)
                throw new ArgumentOutOfRangeException();

            double x = number;
            int iter = 0;
            while (true)
            {
                double xk = (x * n - x + number / Math.Pow(x, n - 1)) / n;
                if (Math.Abs(xk - x) < EPS)
                    return xk;
                x = xk;
            }
        }
    }
}
