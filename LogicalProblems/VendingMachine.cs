using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    public class VendingMachine
    {
        public void Machine()
        {
            int[] notes = { 1000, 500, 100, 50, 20, 10, 5, 2, 1 };
            int[] frequency = new int[notes.Length];
            Console.WriteLine("Enter amount");
            int amount = Convert.ToInt32(Console.ReadLine()); //2050/1000 => 2
            for (int i = 0; i < notes.Length; i++)
            {
                if (amount > 0)
                {
                    frequency[i] = amount / notes[i];  //2
                    amount -= frequency[i] * notes[i]; //2 * 1000
                }
            }
            for (int i = 0; i < frequency.Length; i++)
            {
                if (frequency[i] != 0)
                {
                    Console.WriteLine(notes[i] + "--->" + frequency[i]);
                }
            }
        }
    }
}
