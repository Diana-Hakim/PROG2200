// Author Diana
// NSCC
// Sept 19, 2022
// Test if the code inputted is correct

using System;
using System.IO;

namespace Login
{
    internal class Program
    {
        public static string FILE_NAME = "code.txt";

        static void Main(string[] args)
        {
            // checks if user knows the password before allowing them to change the password. The password is saved after every use
            string code = getLastCode();//replace 'getLastCode()' with "'secret'" to remove file element
            Console.WriteLine("The code is.... "+"'"+code+"'"); // Testing: can be removed

            // Get input
            Console.WriteLine("What is the pass code?");
            var codeInput = Console.ReadLine();

            // Test if correct
            while (!(codeInput == code)) {
                Console.WriteLine("Not Authenticted");
                Console.WriteLine("What is the pass code?");
                codeInput = Console.ReadLine();
            }
            newCode(); //change the password comment out to remove file element
            //code = newCode();// add to remove file element
            Console.ReadLine();
        }

        
        private static string newCode()
        {
            //get new pass code, from user input 
            string code = inputNewCode("Input your new pass code:", 10);
            saveToFile(code);//comment out to remove file element
            Console.WriteLine("Password Changed! ");
            return code;
        }

        private static string inputNewCode(string context_string, int max)
        {
            //input a sting with the given parmeters, return tring entered if correct
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
        private static void saveToFile(string txt)
        {
            //Save string to FILE_NAME given
            try
            {
                using (StreamWriter w = File.AppendText(FILE_NAME))
                {
                    AddtoFile(txt, w); // add txt to file
                    w.Close();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        
        private static string getLastCode() 
        {
            //Get the last line of text in a file
            string line;
            string code = "";
            StreamReader sr = File.OpenText(FILE_NAME);
            while ((line = sr.ReadLine()) != null)
            {
                code = line;
            }
            sr.Close();
            return code;
        }
        public static void AddtoFile(string logMessage, TextWriter w)
        {
            // Write to file
            w.Write("\n"+logMessage);
            
        }
    }
}







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