using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projecteuler._1_100._1_10
{
    public class task_3 : ITask
    {
        public string answer()
        {
            List<long> primeNumbers = new List<long>();
            List<long> divisorsOfNumber = new List<long>();
            long number = 600851475143;
            bool correspondence;

            primeNumbers.Add(2);
            for (long i = 3; i < Math.Sqrt(number); i++)
            {
                correspondence = true;


                Parallel.ForEach(primeNumbers, (prime, state) =>
                {
                    if (i % prime == 0)
                    {
                        correspondence = false;
                        state.Break();
                    }
                });

                if (correspondence)
                {
                    primeNumbers.Add(i);
                    if (number % i == 0)
                    {
                        divisorsOfNumber.Add(i);
                    }
                } 
            }
            return divisorsOfNumber[divisorsOfNumber.Count - 1].ToString();
        } 
    }
}
