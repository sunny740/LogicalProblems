using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    public class CoupanNumber
    {
        public void Coupan()
        {
            int count = 0;
            int[] coupon = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 12, 14, 15, 16, 17, 18, 19, 20 };
            int length = coupon.Length;
            for (int k = 0; k < length; k++)
            {
                count = 0;
                for (int l = 0; l < k; l++)
                {
                    Random random = new Random();
                    int check = random.Next(1, 20);
                    if (check == coupon[k])
                    {
                        count++;
                    }
                }
                if (count == 1)
                {
                    Console.Write(coupon[k] + " ");
                }
            }
        }
    }
}