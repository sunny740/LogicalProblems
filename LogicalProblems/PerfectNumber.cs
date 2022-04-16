using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    public class PerfectNumber
    {
        public void Number()
        {
            int num, j;
            Console.WriteLine("Enter your number : ");

            int per, sum = 0;
            num = Convert.ToInt32(Console.ReadLine());
            for (j = 1; j < num; j++)
            {
                per = num % j;
                if (per == 0)
                {
                    sum = sum + j;
                }
            }
            if (sum == num)
            {
                Console.WriteLine(num + " " + "is a Perfect Number");
            }
            else
            {
                Console.WriteLine(num + " " + "is not a Perfect Number");
            }
        }
    }
}
