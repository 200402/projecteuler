using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projecteuler
{
    class task_3 : ITask
    {
        public string answer()
        {
            List<long> primeNumbers = new List<long>();
            List<long> divisorsOfNumber = new List<long>();
            long number = 600851475143;
            bool correspondence;

            primeNumbers.Add(2);
            for (int i = 3; i < number/2; i++)
            {
                correspondence = true;
                foreach (long prime in primeNumbers)
                {
                    if (i%prime == 0)
                    {
                        correspondence = false;
                        break;
                    }
                }

                if (correspondence)
                {
                    primeNumbers.Add(i);
                    if (number % i == 0)
                        divisorsOfNumber.Add(i);
                }
            }

            return divisorsOfNumber[divisorsOfNumber.Count-1].ToString();
        }
    }
}
