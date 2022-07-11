using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projecteuler._1_100._11_20
{
    internal class task_15 : ITask
    {
        public string answer()
        {
            ulong[,] arr = new ulong[21, 21];

            for (int i = 0; i < 21; i++)
            {
                arr[0, i] = 1;
                arr[i, 0] = 1;
            }
            for (int i = 1; i < 21; i++)
            {
                for (int ii = 1; ii < 21; ii++)
                {
                    arr[i, ii] = arr[i-1, ii] + arr[i, ii-1];
                }
            }
            return arr[20,20].ToString();
        }
    }
}
