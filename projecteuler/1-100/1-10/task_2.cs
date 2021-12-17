using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projecteuler
{
    class task_2 : ITask
    {
        public string answer()
        {
            int firstNumber = 1;
            int secondNumber = 2;
            int newNumber;
            int end = 4_000_000;
            int i = 0;

            long sum = 0;
            while (firstNumber + secondNumber < end)
            {
                i++;
                newNumber = firstNumber + secondNumber;
                firstNumber = secondNumber;
                secondNumber = newNumber;
                if (newNumber % 2 == 0)
                    sum += newNumber;
            }
            //while (firstNumber + secondNumber < end)
            //{
            //    i++;
            //    newNumber = firstNumber + secondNumber;
            //    firstNumber = secondNumber;
            //    secondNumber = newNumber;
            //    if (i % 2 == 0)
            //        sum += newNumber;
            //}

            return sum.ToString();
        }
    }
}
