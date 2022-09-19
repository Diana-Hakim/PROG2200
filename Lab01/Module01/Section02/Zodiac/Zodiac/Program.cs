using System;

namespace Zodiac
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();

            Console.WriteLine("What is your age?");
            var age = Console.ReadLine();

            Console.WriteLine("What month were you born?");
            var month = Console.ReadLine();

            Console.WriteLine("What is your email?");
            var email = Console.ReadLine();

            Console.WriteLine("What date were you born?");
            var date = Console.ReadLine();



            Console.WriteLine("Your name is: {0}", name);
            Console.WriteLine("Your name is: {0}", age);
            Console.WriteLine("Your name is: {0}", month);
            Console.WriteLine("Your name is: {0}", email);
            Console.WriteLine("Your name is: {0}", date);

            Console.ReadLine(); // Keep open

            if (month == "march") 
            {
                Console.WriteLine("You are an Aries");
            }
            else if (month == "april") 
            {
                Console.WriteLine("You are a Taurus");
            }
            else if (month == "may")
            {
                Console.WriteLine("You are a Gemini");
            }

        }
    }
}
