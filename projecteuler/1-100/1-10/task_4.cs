using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projecteuler
{
    class task_4
    {
        public int answer()
        {
            string product = "";
            int productInt = 0;
            bool shit;
            for (int i = 999; i > 100; i--)
            {
                for (int ii = 999; ii > 100; ii--)
                {
                    shit = true;
                    if (i * ii < productInt)
                        break;
                    product = (i * ii).ToString();
                    for (int j = 0; j < product.Length/2; j++)
                    {
                        if (product[j] != product[product.Length - j - 1])
                        {
                            shit = false;
                            break;
                        }
                    }
                    if (shit)
                        productInt = Convert.ToInt32(product);
                }
            }
            return productInt;
        }
    }
}
