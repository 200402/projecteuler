using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projecteuler._1_100._1_10
{
    public class task_5:ITask
    {
        public string answer()
        {
            bool shit;
            for (ulong i = 1; ; i++)
            {
                shit = true;
                for (ulong ii = 2; ii < 20; ii++)
                {
                    if (i % ii != 0)
                    {
                        shit = false;
                        break;
                    }
                }
                if (shit)
                {
                    return i.ToString();
                }
            }
        }
    }
}
