using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projecteuler._1_100._11_20
{
    internal class task_12 : ITask
    {
        public string answer()
        { 
            long triangle = 0; 

            for (long i = 0; ; i++)
            {
                triangle += i;
                long divisionCount = 2;
                long end = (long)Math.Sqrt(triangle);
                for (long ii = 2; ii <= end; ii++)
                {
                    if (triangle % ii == 0)
                    {
                        divisionCount += 2;
                    }
                }
                if (divisionCount > 500)
                {
                    return triangle.ToString();
                }
            }
        }
    }
}
