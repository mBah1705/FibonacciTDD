using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FibonacciTDD.Logic
{
    public class FibonacciCalculator
    {
        public int CalculateValue(int v)
        {
            if (v == 1)
                return 1;
            else
                return v - 1;
             
        }
    }
}
