using StudentManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Util
{
    internal class Console
    {



        static public string AskString(string question) 
        {
            System.Console.Write(question);
            return System.Console.ReadLine();
        }

        static public string AskName(string question)
        {
            string input;
            while (true)
            {
                try
                {
                    System.Console.Write(question);
                    input = System.Console.ReadLine();
                    // if no special characters or numbers 
                    if (!(new Regex("[^A-Za-z0-9]").IsMatch(input.ToString()) || input.Any(char.IsDigit)))
                    {
                        break;
                    }
                    else {
                        throw new MyCustomException();
                    }

                }
                catch (MyCustomException customException)
                {
                    customException.StringException(question);
                }

            }
            return input;
        }
    

        static public int AskInt(string question) 
        {
            int input = 0;
            bool correctInput = false;
            while (!correctInput) { 
                try
                {
                    System.Console.Write(question);
                    correctInput = int.TryParse(System.Console.ReadLine(), out input);
                    if (!correctInput) 
                    {
                        throw new MyCustomException();
                    }
                    
                }
                catch (MyCustomException customException)
                {
                    customException.IntException(question);
                }

            }
            return input;
        }

    }
}
