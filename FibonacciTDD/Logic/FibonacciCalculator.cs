namespace FibonacciTDD.Logic
{
    public class FibonacciCalculator
    {
        public double CalculateValue(int v)
        {
            if (v == 1 || v == 2)
                return 1;
            else return CalculateValue(v - 1) + CalculateValue(v - 2);
        }
    }
}
