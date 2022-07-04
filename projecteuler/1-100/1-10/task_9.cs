using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projecteuler._1_100._1_10
{
    internal class task_9 : ITask
    {
        public string answer()
        {
            int sum = 1000;
            for (int a = 1; a < sum; a++)
            {
                for (int b = 1; b < sum; b++)
                {
                    double c = a * a + b * b;
                    if ((int)Math.Sqrt(c) != Math.Sqrt(c))
                        continue;
                    c = Math.Sqrt(c);
                    if (a + b + c == sum)
                    {
                        return $"{a*b*c}";
                    }
                }
            }
            return $"Тройки пифагора, которая бы в сумме давала {sum}, не существует";
        }
    }
}
