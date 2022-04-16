using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    public class Tempreture
    {
        public void Temp()
        {
            double Celcius, Fahrenheit;
            Console.WriteLine("Hi, you wanna know about Tempreture ");
            Console.WriteLine("Please Just Enter your Input in Celcius ");
            Celcius = Convert.ToSingle(Console.ReadLine());

            Fahrenheit = (double)((Celcius * 9 / 5.0) + 32);
            Console.WriteLine("Tempreture in Fahrenheit is " + " " + Fahrenheit);
            Console.WriteLine("Thank you for your Time ('_') ");
        }
    }
}
