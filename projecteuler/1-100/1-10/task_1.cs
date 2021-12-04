﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projecteuler
{
    public class task_1 : ITask
    {
        int[] arrayOfMultiplicity = new int[] { 3, 5 };
        int start = 0;
        int end = 100000;

        public string answer()
        {
            long sum = 0;
            bool fit;

            for (int i = start; i < end; i++)
            {
                fit = false;
                for (int ii = 0; ii < arrayOfMultiplicity.Length; ii++)
                {
                    if (i % arrayOfMultiplicity[ii] == 0)
                        fit = true;
                }
                if (fit)
                    sum += i;
            }

            return sum.ToString();
        }
    }
}
