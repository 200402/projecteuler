using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projecteuler._1_100._11_20
{
    internal class task_14:ITask
    {
        public string answer()
        {
            ulong theLongestStart = 0;
            ulong maxLength = 0;
            for (ulong i = 1; i < 1_000_000; i++)
            {
                ulong lengthI = calculateTheLengthOfTheSequence(i);
                if (lengthI > maxLength) 
                {
                    maxLength = lengthI;
                    theLongestStart = i; 
                }
            }
            return theLongestStart.ToString();
        }

        ulong calculateTheLengthOfTheSequence(ulong i)
        {
            ulong length = 1;
            while (i != 1)
            {
                if (i % 2 == 0)
                    i /= 2;
                else
                    i = 3 * i + 1;
                length++;
            }
            return length;
        }

    }
}
