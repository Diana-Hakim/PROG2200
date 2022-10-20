using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Survey
{
    enum Month { 
        January = 1, February = 2, March = 3 , April = 4 , May = 5, June = 6, July = 7, August = 8, September = 9, Oct = 10, November = 11, December = 12, Unnown = 13
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var name = TryAnswer();

            Console.WriteLine("What is your age?");
            var age = TryAnswer();

            var month = (int)InputMonth();

            Console.WriteLine("Your name is: {0}", name);
            Console.WriteLine("Your age is: {0}", age);
            Console.WriteLine("Your birth month is: {0}", month);

            //if (month == "march")
            //{
            //    Console.WriteLine("you are an Aries.");
            //}
            //else if (month == "april")
            //{
            //    Console.WriteLine("you are a Taurus.");
            //}
            //else if (month == "may")
            //{
            //    Console.WriteLine("you are a Gemini.");
            //}
            Console.ReadLine();
        }

        static string TryAnswer()
        {
            var question = Console.ReadLine();
            if (question == "")
            {
                Console.WriteLine("You didn't type anything, please try again:");
                return Console.ReadLine();
            }
            return question;
        }

        static Month InputMonth() {
            Console.WriteLine("What month were you born in (type the corresponding number)?");
            var monthStr = TryAnswer();
            int month;
            Int32.TryParse(monthStr, out month);
            switch ((Month)month)
            {
                case Month.January:
                    return Month.January;
                case Month.February:
                    return Month.February;
                case Month.March:
                    return Month.March;
                case Month.April:
                    return Month.April;
                case Month.May:
                    return Month.May;
                case Month.June:
                    return Month.June;
                case Month.July:
                    return Month.July;
                case Month.August:
                    return Month.August;
                case Month.September:
                    return Month.September;
                case Month.November:
                    return Month.November;
                case Month.December:
                    return Month.December;
                default:
                    return Month.Unnown;
            }

        }


    }
}
