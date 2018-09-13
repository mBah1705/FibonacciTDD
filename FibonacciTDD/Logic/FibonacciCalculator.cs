using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FibonacciTDD.Logic
{
    public class FibonacciCalculator
    {
        public long CalculateValue(int v)
        {
            if (v == 1 || v == 2)
                return 1;
            else return CalculateValue(v - 1) + CalculateValue(v - 2);
        }
    }
}
