using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimitiveDataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first name : ");
            // I am not caring specifically about the datatype of the varaiable "name"
            var firstName = Console.ReadLine(); //Impliciltly declared as a string datatype variable

            // Explicitly declared
            Console.WriteLine("Enter the student last name : ");
            string empLastName = Console.ReadLine();
            Console.WriteLine("Enter the age : ");
            int age = int.Parse(Console.ReadLine()); // Data casting from string to integer
            Console.WriteLine(firstName + " " + empLastName + " age of : " + age + " Years");

            Console.WriteLine("The student name is : {0} and the age is :  {1}", firstName, age);
            
            //String Interpolation

            Console.WriteLine($"The student name is : {firstName} and the age is :  {age}");

        }
    }
}
