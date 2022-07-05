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
            long sum = 2;
            List<long> primeNumbers = new List<long>();
            bool correspondence;
            primeNumbers.Add(2);

            for (long i = 3; i < 2_000_000; i++)
            {
                correspondence = true;
                foreach (long prime in primeNumbers)
                {
                    if (i % prime == 0)
                    {
                        correspondence = false;
                        break;
                    }
                }
                if (correspondence)
                {
                    primeNumbers.Add(i);
                    sum += i;
                }
            }

            return sum.ToString();
        }
    }
}
