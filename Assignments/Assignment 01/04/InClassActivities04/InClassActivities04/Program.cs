using ChatLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace InClassActivities04
{
    internal class Program{
        // -------------------------------------------------------- Variables  
        // special keys and wait times
        private const int WAIT_TIME = 500;
        private const ConsoleKey INSERT_KEY = ConsoleKey.I;
        private const ConsoleKey ESCAPE_KEY = ConsoleKey.Escape;
        // if client
        private static readonly string[] STATUS = { "Server","Client"};
        private static bool isClient = true;  // default
        // chat history 
        private static readonly List<ConsoleKey> chatHistory = new List<ConsoleKey>();

        //---------------------------------------------------------- Functions
        static void Main(string[] args) { 
            if (args.Contains("-server")){
                SetUserStatus(false);
                Server server = new Server(); // server: create a new object
            }else {
                SetUserStatus(true);
                Client client = new Client(); // client: create a new object
            }
            //Messaging();
            Console.ReadLine();

        }

        static void SetUserStatus(bool client) {
            if (!client) { // if server
                isClient = !isClient; //swap so this is false
            }
            Console.WriteLine(STATUS[Convert.ToInt32(isClient)]);

        }

        
        public static void Messaging(){
            Console.WriteLine("Start Messaging........\nPress '"+ESCAPE_KEY+"' to exit");
            ConsoleKeyInfo userKeyInfo = new ConsoleKeyInfo();
            do
            {
                Console.WriteLine("Listening for messages");
                if (Console.KeyAvailable)
                {
                    userKeyInfo = Console.ReadKey();
                    if (!(userKeyInfo.Key == INSERT_KEY))
                    {
                        Console.WriteLine($": You typed {userKeyInfo.Key}");
                        Thread.Sleep(WAIT_TIME);
                    }
                    else
                    {
                        Console.WriteLine(": ‘" + userKeyInfo.Key + "’ is PRESSED >>");
                        Console.ReadLine();
                    }
                    userKeyInfo = Console.ReadKey();
                    chatHistory.Add(userKeyInfo.Key);
                }
            } while (!(userKeyInfo.Key == ESCAPE_KEY));
            EndofMessaging(); // warn and keep window up
        }



        private static void EndofMessaging() {
            PrintEach("Your Chat History", chatHistory);
            Console.WriteLine("Exit Messaging\n\n\n\n\n\n\nPress ENTER to Exit");
        }
        
    public static void PrintEach(string context, List<ConsoleKey> userInput)
    {
        Console.WriteLine("\n" + context);
        foreach (var input in userInput)
        {
            Console.WriteLine(input);
        }
    }
}
}
