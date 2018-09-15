using System.Numerics;

namespace FibonacciTDD.Logic
{
    public class FibonacciCalculator
    {
        public string CalculateValue(int v)
        {
            if (v < 1 || v > 100)
                return "Use a value between 0 and 100";
            else if (v < 2)
                return v.ToString();

            BigInteger[] f = new BigInteger[v + 1];
            f[0] = 0;
            f[1] = 1;

            for (int i = 2; i <= v; i++)
            {
                f[i] = f[i - 1] + f[i - 2];
            }
            return f[v].ToString();
        }
    }
}
