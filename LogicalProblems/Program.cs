﻿using System;

namespace LogicalProblems
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Logical Problems");
            bool end = true;
            Console.WriteLine("1. Fibonacci Series\n2. Perfect Numbers\n3. Prime Number\n4. Reverse Numbers\n5. Day Of Week\n6. Tempreture\n7. Monthly Payment\n8. Monthly Payment2\n9. Vending Machine\n");
            while (end == true)
            {
                Console.WriteLine("Take an option to execute");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        FibonacciSeries flip = new FibonacciSeries();
                        flip.Fibonacci();
                        break;
                    case 2:
                        PerfectNumber per = new PerfectNumber();
                        per.Number();
                        break;
                    case 3:
                        PrimeNumbers Number = new PrimeNumbers();
                        Number.Prime();
                        break;
                    case 4:
                        ReverseNumber Rvs = new ReverseNumber();
                        Rvs.Reverse();
                        break;
                    case 5:
                        DayOfWeek Day = new DayOfWeek();
                        Day.Week();
                        break;
                    case 6:
                        Tempreture TEMP = new Tempreture();
                        TEMP.Temp();
                        break;
                    //case 7:
                    //    MonthlyPayment Pay = new MonthlyPayment();
                    //    Pay.Payment();
                    //    break;
                    //case 8:
                    //    MonthlyPayment PAy = new MonthlyPayment();
                    //    PAy.Payment();
                    //    break;
                    //case 9:
                    //    VendingMachine Ven = new VendingMachine();
                    //    Ven.Machine();
                    //    break;
                    default:
                        Console.WriteLine("Enter Proper Option To Execute");
                        Console.WriteLine("Choose Number Between 1-9");
                        break;
                }
            }
        }
    }
}