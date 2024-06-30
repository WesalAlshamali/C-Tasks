using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    internal class FactorialCalculator
    {
        public int CalculateFactorial(int n)
        {
            if (n < 0)
            {
                throw new ArgumentException("Factorial is not defined for negative numbers.");
            }

            int factorial = 1;
            for (int i = 2; i <= n; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}
