using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projecteuler
{
    public class task_7 : ITask
    {
        public string answer()
        {
            int count = 10001;
            List<int> primeNumbers = new List<int>();
            bool correspondence;
            primeNumbers.Add(2);

            for (int i = 3; primeNumbers.Count < count; i++)
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
                }
            }
            return primeNumbers[count - 1].ToString();
        }
    }
}
