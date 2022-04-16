using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    public class PrimeNumbers
    {
        public void Prime()
        {
            int num1, count = 0;
            Console.WriteLine("Enter Your Number : ");
            num1 = Convert.ToInt32(Console.ReadLine());

            if (num1 > 1)
            {
                for (int i = 1; i <= num1; i++)
                {
                    if (num1 % i == 0)
                        count++;
                }
                if (count == 2)
                {
                    Console.WriteLine("Entere A number is a Prime Number");
                }
                else
                {
                    Console.WriteLine("It is a Prime Number");
                }
            }
            else
            {
                Console.WriteLine("Is is not a Prime Number");
            }
        }
    }
}
