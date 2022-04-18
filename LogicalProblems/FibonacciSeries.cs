using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    public class FibonacciSeries
    {
        public void Fibonacci()
        {
            int num1 = 0, num2 = 1, sum;
            Console.WriteLine("Enter The Value Of Series");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Fibonacci Series: ");
            Console.WriteLine(+num1);
            for (int i = 1; i < num; i++)
            {
                sum = num1 + num2;
                Console.WriteLine(" " + sum);
                num1 = num2;
                num2 = sum;
            }
        }
    }
}
