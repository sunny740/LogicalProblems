using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    public class ReverseNumber
    {
        public void Reverse()
        {
            Console.WriteLine("Enter your number : ");
            int Num, reverse = 0;
            //int remo = 0, rvs = 0;
            Num = Convert.ToInt32(Console.ReadLine());
            while (Num > 0)
            {
                reverse = reverse * 10 + Num % 10;
                Num = Num / 10;

                //remo = Num % 10;
                //Num = Num / 10;
                //rvs = rvs * 10 + remo;
            }
            Console.WriteLine(reverse + " " + "is the reversed number");
        }
    }
}
