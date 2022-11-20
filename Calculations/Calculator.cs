using System;

namespace Calculations
{
    public static class Calculator
    {
        /// <summary>
        /// Calculate the following sum 1/1 + 1/2 + 1/3 + ... + 1/n, where n > 0.
        /// </summary>
        /// <param name="n">Number of elements.</param>
        /// <returns>Sum of elements.</returns>
        public static double GetSumOne(int n)
        {
            double sum = 0;
            double a = 1;
            for (int i = 0; i < n; i++)
            {
                sum = sum + (1 / a);
                a++;
            }

            return sum;
        }
        
        /// <summary>
        /// Calculate the following sum
        /// 1/(1*2) - 1/(2*3) + 1/(3*4) + ... + (-1)^(n+1) / (n * (n + 1)), where n > 0.
        /// </summary>
        /// <param name="n">Number of elements.</param>
        /// <returns>Sum of elements.</returns>
        public static double GetSumTwo(int n)
        {
            double sum = 0;
            double a = 1;
            double b = 2;
            double altA;
            double altB;
            for (int i = 0; i < n / 2; i++)
            {
                altA = a++;
                altB = b++;
                sum = sum + (1 / (a * b)) - (1 / (altA * altB));
                a++;
                b++;
            }

            return Math.Abs(sum);
        }
        
        /// <summary>
        /// Calculate the following sum
        /// 1/1^5 + 1/2^5 + 1/3^5 + ... + 1/n^5, where n > 0.
        /// </summary>
        /// <param name="n">Number of elements.</param>
        /// <returns>Sum of elements.</returns>
        public static double GetSumThree(int n)
        {
            double sum = 0;
            double a = 1;
            for (int i = 0; i < n; i++)
            {
                sum = sum + (1 / Math.Pow(a, 5));
                a++;
            }

            return sum;
        }
        
        /// <summary>
        /// Calculate the following sum
        /// 1/(3 * 3) + 1/(5 * 5) + 1/(7 * 7) + ... + 1/((2 * n + 1) * (2 * n + 1)), where n > 0.
        /// </summary>
        /// <param name="n">Number of elements.</param>
        /// <returns>Sum of elements.</returns>
        public static double GetSumFour(int n)
        {
            double sum = 0;
            double a = 3;
            for (int i = 0; i < n; i++)
            {
                sum = sum + (1 / (a * a));
                a = a + 2;
            }

            return sum;
        }

        /// <summary>
        /// Calculate the following product
        /// (1 + 1/(1 * 1)) * (1 + 1/(2 * 2)) * (1 + 1/(3 * 3)) * ... * (1 + 1/(n * n)), where n > 0.
        /// </summary>
        /// <param name="n">Number of elements.</param>
        /// <returns>Product of elements.</returns>
        public static double GetProductOne(int n)
        {
            double sum = 1;
            double a = 1;
            for (int i = 0; i < n; i++)
            {
                sum = sum * (1 + (1 / (a * a)));
                a++;
            }

            return sum;
        }
        
        /// <summary>
        /// Calculate the following sum
        /// -1/3 + 1/5 - 1/7 + ... + (-1)^n / (2 * n + 1), where n > 0.
        /// </summary>
        /// <param name="n">Number of elements.</param>
        /// <returns>Sum of elements.</returns>
        public static double GetSumFive(int n)
        {
            double sum = 0;
            double a = 3;
            for (int i = 0; i < n / 2; i++)
            {
                sum = sum - (1 / a);
                a = a + 2;
                sum = sum + (1 / a);
                a = a + 2;
            }

            return sum;
        }

        /// <summary>
        /// Calculate the following sum
        /// 1!/1 + 2!/(1+1/2) + 3!/(1+1/2+1/3) + ... + 1*2*...* n/ (1+1/2+1/3+...+1/n), where n > 0.
        /// </summary>
        /// <param name="n">Number of elements.</param>
        /// <returns>Sum of elements.</returns>
        public static double GetSumSix(int n)
        {
            double pos = double.PositiveInfinity;

            if (n > 100000)
            {
                return pos;
            }

            double sum = 1;
            double a = 1;
            double number = 1;

            for (int i = 2; i <= n; i++)
            {
                a = a * i;
                number = number + (1.0d / i);
                sum = sum + (a / number);
            }

            return sum;
        }

        /// <summary>
        /// Calculate the following sum
        /// Sqrt(2 + Sqrt(2 + ... + Sqrt(2))), where n > 0.
        /// </summary>
        /// <param name="n">Number of elements.</param>
        /// <returns>Sum of elements.</returns>
        public static double GetSumSeven(int n)
        {
            double a;
            double b = Math.Sqrt(2);
            for (int i = 0; i < n - 1; i++)
            {
                a = b + 2;
                b = Math.Sqrt(a);
            }

            return b;
        }
        
        /// <summary>
        /// Calculate the following sum
        /// 1/sin(1) + 1/(sin(1)+sin(2)) + ...+  1/(sin(1)+sin(2)+...+sin(n)), where n > 0.
        /// </summary>
        /// <param name="n">Number of elements.</param>
        /// <returns>Sum of elements.</returns>
        public static double GetSumEight(int n)
        {
            double sum = 0;
            int a = 2;
            double c = (1 * Math.PI) / 180;
            double b = Math.Sin(c);
            double k;
            for (int i = 0; i < n; i++)
            {
                k = (a * Math.PI) / 180;
                sum = sum + (1 / b);
                b = b + Math.Sin(k);
                a++;
            }

            return sum;
        }
    }
}
