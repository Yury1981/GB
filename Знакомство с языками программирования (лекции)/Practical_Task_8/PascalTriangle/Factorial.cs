using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PascalTriangle
{
    public class Factorial
    {
        public static float factorial(int n)
        {
            float i, x = 1;
            for (i = 1; i <= n; i++)
            {
                x *= i;
            }
            return x;
        }
    }
}
