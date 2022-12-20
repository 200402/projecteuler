using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace projecteuler._1_100._11_20
{
    internal class task_20 : ITask
    {
        public string answer()
        {
            BigInteger number = Fact(100);
            int sum = 0;
            while (number > 0)
            {
                sum += (int)(number % 10);
                number /= 10;
            }
            return sum.ToString();
        }

        public static BigInteger Fact(long n)
        {
            if (n == 0)
                return 1;
            else
                return n * Fact(n - 1);
        }
    }
}
