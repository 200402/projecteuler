using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace projecteuler._1_100._1_10
{
    internal class task_10 : ITask
    {
        public string answer()
        {
            long sum = 0;

            for (long i = 1; i < 2_000_000; i++)
            {
                if (IsPrime(i))
                {
                    sum += i;
                }
            }

            return sum.ToString();
        }

        public static bool IsPrime(long number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
                if (number % i == 0)
                    return false;

            return true;
        }
    }
}
