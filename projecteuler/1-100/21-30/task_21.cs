using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projecteuler._1_100._21_30
{
    internal class task_21 : ITask
    {
        public string answer()
        {
            long sum = 0;
            for (int i = 0; i < 10000; i++)
                if (isAmicable(i)) { sum+=i; }
            return sum.ToString();
        }

        public bool isAmicable(int numb)
        {
            int a = divisorSum(numb);
            return a!=numb && divisorSum(a) == numb;
        }

        private int divisorSum(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n/2; i++)
            {
                if (n % i == 0)
                    sum += i;
            }
            return sum;
        }
    }
}
