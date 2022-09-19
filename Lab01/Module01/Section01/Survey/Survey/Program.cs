// Author Diana Hakim
// NSCC
// Created Sept 19, 2022
// Survey asking users for their information

using System;
using System.Collections.Generic;


namespace Survey
{
    class Person
    {
        // Persons Information
        private Dictionary<string, string> info = new Dictionary<string, string>();
        public string name { get; set; }
        public int age { get; set; }
        public int month { get; set; }
        public int day { get; set; }
        public string email { get; set; }
        //formatting 
        static readonly int FormatNum = 100;
        static readonly char FormatStr = '-';



        public Person()
        {
            //Print Formatting Once init
            Console.WriteLine(new String(FormatStr, FormatNum));
        }

        public void populate()
        {
            //add info to dictionary
            info.Add("Name: ", name);
            info.Add("Age: ", age.ToString());
            info.Add("Month: ", month.ToString());
            info.Add("Day: ", day.ToString());
            info.Add("Email: ", email);
        }

        public void outputData()
        {
            //add to dictonary then print
            populate();
            Console.WriteLine("\n" + new String(FormatStr, FormatNum));
            Console.Write("Data Entered:\n");
            Console.WriteLine(new String(FormatStr, FormatNum));
            foreach (var i in info)
            {
                Console.WriteLine(String.Format("|{0,-10}|{1,-10:N0}", i.Key, i.Value));
            }
            Console.WriteLine(new String(FormatStr, FormatNum));

        }


        internal class Program
        {
            //Testing
            //public static readonly string correct_output = "Data Was Successfully Inputted!";

            static void Main(string[] args)
            {
                //Videos 1-3
                //Assign
                //var anything = "My String";

                //Input
                //var anything = Console.ReadLine();

                //Output
                //Console.WriteLine(anything);


                // Video 4: Challenge 01
                //Program.correct_output = "Data Was Successfully Inputted!\n";
                Person person1 = new Person();
                // Three Question Survey
                person1.name = inputStr("What is your name? ", 15);
                person1.age = inputInt("How old are you? ", 1, 110);
                person1.month = inputInt("What month were you born in? ", 0, 12);
                //Two More Questions
                person1.day = inputInt("What day were you born on? ", 0, 31);
                person1.email = inputEmail("What is your email? ", 30);
                //Output Data
                person1.outputData();
                // Keep Console Up
                Console.WriteLine("\n\n\nPress Enter to Close Window");
                Console.Read();
            }

            private static string inputEmail(string context_string, int max)
            {
                //input an email with the given and specific parmeters 
                bool correctInput = false;
                string input = "";
                //string input = inputStr(context_string, max);
                while (!correctInput)
                {
                    input = inputStr(context_string, max);
                    correctInput = input.Contains(".") && input.Contains("@") && !input.Contains(" ");
                    Console.Write((!correctInput) ? "That is not an Email: \n" : ""); // Output: if input is Incorrect / Correct 

                }
                return input;
            }

            private static string inputStr(string context_string, int max)
            {
                //input a sting with the given parmeters 
                int min = 2;
                Console.Write(context_string);
                string input = Console.ReadLine();
                while (!((min <= input.Length) && (input.Length <= max)))
                {
                    Console.Write("Input Must Be Between " + min + " to " + max + " characters long: ");
                    input = Console.ReadLine();
                }
                return input;
            }

            private static int inputInt(string context_string, int min, int max)
            {
                //input an int with the given parmeters 
                int input = 0;
                bool correctInput = false; // Bool: false in order to enter while loop 
                while (!correctInput)
                {
                    Console.Write(context_string); // Input
                    correctInput = int.TryParse(Console.ReadLine(), out input) && (min <= input && input <= max); // Bool: If input is Incorrect / Correct 
                    Console.Write((!correctInput) ? "Enter a Number Between " + min + " - " + max + " \n" : ""); // Output: if input is Incorrect / Correct 
                }
                return input;
            }
        }
    }
}
