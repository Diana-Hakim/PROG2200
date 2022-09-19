// Author Diana
// NSCC
// Sept 19, 2022
// Test if the code inputted is correct

using System;

namespace Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //----------------------Simplifed Video-------------------------------
            // Create the code variable 
            string code = "secret";

            // Get input
            Console.WriteLine("What is the pass code?");
            var codeInput = Console.ReadLine();

            // Test if correct
            bool correct = codeInput == code; //test if the code was correct
            Console.WriteLine(correct ? "Authenticted" : "Not Authenticted");// no need to write brackets for one command  

            //----------------------------Video-----------------------------------
            //Console.WriteLine("What is the pass code?");
            //var codeInput = Console.ReadLine();
            //if (codeInput == "secert")
            //{
            //    Console.WriteLine("Authenticted");
            //}
            //else if (codeInput != "secret") 
            //{
            //    Console.WriteLine("Not Authenticted");
            //}


            //----------------Testing how I'd fix it---------------------------------------------
            //SecureString theSecureString = new NetworkCredential("", "secret").SecurePassword;
            //bool correct = false;

            //while (!loop)
            //{
            //    Console.WriteLine("What is the pass code?");
            //    var codeInput = Console.ReadLine();
            //    correct = (codeInput == new NetworkCredential("", theSecureString).Password) ? true : false;
            //    Console.WriteLine(correct ? "Authenticted" : "Not Authenticted");
            //}


            Console.ReadLine();

        }
    }
}
