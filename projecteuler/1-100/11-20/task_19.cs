using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projecteuler._1_100._11_20
{
    internal class task_19 : ITask
    {
        public string answer()
        {
            int counter = 0;
            for (int y = 1901; y <= 2000; y++)
            {
                for (int m = 1; m <= 12; m++)
                {
                    if (new DateTime(y, m, 1).DayOfWeek == 0)
                        counter++;
                }
            }
            return counter.ToString();
        }
    }
}
