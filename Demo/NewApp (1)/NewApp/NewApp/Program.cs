using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi");
            Console.WriteLine("Yousef");
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Enter the student first name: ");
            var stFirstName = Console.ReadLine();
            Console.WriteLine("Enter the student last name: ");
            String stLastName = Console.ReadLine();
            Console.WriteLine(stFirstName);
            Console.WriteLine(stLastName);
            //var num1 = Console.Read(); What do you think?
            var num1 = 5;
            var int newNumber;// Implicitly declared.
            int num2 = 7; // Explicitly declared.
            double total = num1 + num2;
            Console.WriteLine("{0} + {1} = {2}", num1, num2, total);
            // First declare the required variable :
            int firstNum, secondNum, result;
            Console.WriteLine("*****************************************************");
            Console.WriteLine("Another declaration way and data casting");
            Console.WriteLine("Enter the first number");
            firstNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            secondNum = Convert.ToInt32(Console.ReadLine());            
            result = firstNum * secondNum;
            Console.WriteLine("the result of firstNum * secondNum is : " + result);
        }
    }
}
