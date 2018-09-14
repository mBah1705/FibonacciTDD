using System.Numerics;

namespace FibonacciTDD.Logic
{
    public class FibonacciCalculator
    {
        public BigInteger CalculateValue(int v)
        {
            //if (v == 1 || v == 2)
            //    return 1;
            //else return CalculateValue(v - 1) + CalculateValue(v - 2);

            if (v < 2)
                return v;

            BigInteger[] f = new BigInteger[v + 1];
            f[0] = 0;
            f[1] = 1;

            for (int i = 2; i <= v; i++)
            {
                f[i] = f[i - 1] + f[i - 2];
            }
            return f[v];
        }
    }
}
