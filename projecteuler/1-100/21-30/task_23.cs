using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projecteuler._1_100._21_30
{
    internal class task_23 : ITask
    {
        public string answer()
        {
            var end = 28123;
            bool[] checkAbundant = new bool[end];
            bool[] checkSumOf2Abundant = new bool[end];
            for (int i = 0; i < end; i++)
            {
                checkAbundant[i] = isAbundant(i);
                checkSumOf2Abundant[i] = false;
            }

            int sum = 0;
            for (int i = 1; i < end; i++)
                if (checkAbundant[i])
                    for (int j = i; j < end; j++)
                        if (checkAbundant[j] && i + j < end)
                            checkSumOf2Abundant[i + j] = true;

            for (int i = 0; i < end; i++)
                if (!checkSumOf2Abundant[i])
                    sum += i;

            return (sum).ToString();
        }

        bool isAbundant(int number)
        {
            int sum = 0;
            for (int i = 1; i <= number / 2; i++)
            {
                if (number % i == 0)
                    sum += i;
            }
            return sum > number;
        }
    }
}
