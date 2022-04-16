using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    public class MonthlyPayment
    {
        public void Payment()
        {
            Console.WriteLine("Enter your Payment : ");
            double P = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter Number of Year : ");
            double Y = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter rate of Interest : ");
            double R = Convert.ToSingle(Console.ReadLine());

            double n = 12 * Y, r = R / (12 * 100);
            double payment = 0;

            payment = (double)(P * r / 1 - Math.Pow((1 + r), (-n)));
            Console.WriteLine(payment);
        }
    }
}
