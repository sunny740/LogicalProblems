using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    public class SqaureRoot
    {
        public void Sqaure()
        {
            Console.WriteLine("Enter the Positive Number");
            int Num = Convert.ToInt32(Console.ReadLine());

            double Root = Math.Sqrt(Num);
            Console.WriteLine("Square root of the number is: ===>" + Root);
            Console.WriteLine("Thnak you For Your Time ('_')");
        }
    }
}
