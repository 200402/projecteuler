using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace projecteuler._1_100._11_20
{
    internal class task_16 : ITask
    {
        int startNumber = 2;
        int degree = 1000;
        public string answer()
        {
            BigInteger number = 1;
            for (int i = 0; i < degree; i++)
            {
                number *= startNumber;
            }
            int sum = 0;
            while (number > 0)
            {
                sum += (int)(number % 10);
                number /= 10;
            }
            return sum.ToString();
        }
    }
}
