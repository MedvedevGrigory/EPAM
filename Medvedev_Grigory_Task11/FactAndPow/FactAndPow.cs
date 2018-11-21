using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactAndPow
{
    public class FactAndPow
    {
        public static int Factorial(int number)
        {
            int factorial = 1;
            for (int i = 2; i <= number; i++)
            {
                factorial *= i;
            }

            return factorial;
        }

        public static double Pow(double number, double exp)
        {
            return Math.Pow(number, exp);
        }
    }
}
