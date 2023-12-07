using System;

namespace Solution
{
    public static class Program
    {
        public static ulong Factorial(int n)
        {
            ulong result = 1;
            if (n < 1)
            {
                return result;
            }
            else
            {
                for (ulong i = (ulong)n; i > 0; i--)
                {
                    result *= i;
                }
            }
            return result;
        }
    }
}
