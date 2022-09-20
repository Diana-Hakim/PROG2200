// Author Diana Hakim
// NSCC
// Created Sept 19, 2022
// Survey asking users for their information

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zodiac
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Testing - no input error handling
            Console.WriteLine("TESTING:");
            Person person1 = new Person(1, 20); //
            Console.WriteLine("Aquarius: "+person1.Zodiac);

            Person person2 = new Person(2, 19); 
            Console.WriteLine("Pisces: " + person2.Zodiac);

            Person person3 = new Person(5, 22); 
            Console.WriteLine("Gemini: " + person3.Zodiac);

            Person person4 = new Person(8, 13);
            Console.WriteLine("Leo: " + person4.Zodiac);



            //Input
            Console.WriteLine("\n\nINPUT TESTING:\n");
            while (true) { 
                Person person5 = new Person(); //input
                Console.WriteLine(person5.Zodiac);
            }

        }

    }
}
