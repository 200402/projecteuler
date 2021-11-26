using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace projecteuler
{
    class task_6
    {
        public long answer()
        {
            int sumOfSquares = 0;
            int squareOfSums = 0;

            for (int i = 1; i < 100; i++)
            {
                sumOfSquares += i * i;
                squareOfSums += i;
            }
            squareOfSums *= squareOfSums;
            return (long)Abs(sumOfSquares - squareOfSums);
        }
    }
}
