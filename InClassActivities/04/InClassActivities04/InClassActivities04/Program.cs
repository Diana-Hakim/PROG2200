using ChatLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting.Channels;
using System.Threading;

namespace InClassActivities04
{
    internal class Program
    {
        static void Main(string[] args){

            //---------------------------------------Phase 5
            //if (args.Contains("-server")){
            //    Console.WriteLine("Server");
            //    run();
            //}
            //else {
            //    Console.WriteLine("Client");
            //    run();
            //}
            //Console.ReadLine();
            //--------------------------------------Phase 6
            if (args.Contains("-server"))
            {
                Console.WriteLine("Server");
                Server server = new Server(); // server: create a new object
            }
            else
            {
                Console.WriteLine("Client");
                Client client = new Client(); // client: create a new object
            }
            runPhase6();
            EndofProject(); // warn and keep window up

           
        }

        // added ESC feature
        public static void runPhase6(){
            Console.WriteLine("Start Messaging........");
            Console.WriteLine("Press 'ESC' to exit");
            ConsoleKeyInfo userKeyInfo = new ConsoleKeyInfo();
            do {
                Console.WriteLine("Listening for messages");
                if (Console.KeyAvailable) {
                    userKeyInfo = Console.ReadKey();
                    if (!(userKeyInfo.Key == ConsoleKey.I)) {
                        Console.WriteLine($": You typed {userKeyInfo.Key}");
                        Thread.Sleep(500);
                    } else {
                        Console.WriteLine(": ‘I’ is PRESSED >>");
                        Console.ReadLine();
                    }
                    userKeyInfo = Console.ReadKey();
                }
            } while (!(userKeyInfo.Key == ConsoleKey.Escape));
            Console.WriteLine("Exiting Messaging");
        }



        private static void EndofProject() {
            Console.WriteLine("\n\n\n\n\n\nPress ENTER to Exit");
            Console.ReadLine();

        }
        


        // --------------------------  My attempt without video
    //    public static void run() {
    //        Console.WriteLine("Start Messaging........");
    //        Console.WriteLine("Press 'ESC' to exit");
    //        List<ConsoleKey> userInput = new List<ConsoleKey>();
    //        ConsoleKey input = GetInput(); //first input

    //        while (!(input == ConsoleKey.Escape))
    //        { // to get out
    //            if (!(input == ConsoleKey.NoName))
    //            { // enter input
    //                Console.WriteLine((input == ConsoleKey.I) ? ": ‘I’ is PRESSED >>" : $": You typed {input}");
    //                userInput.Add(input);
    //                Console.Beep();
    //            }
    //            input = GetInput(); // get input
    //        }
    //        PrintEach("Items Entered.......", userInput);
    //        Console.ReadLine();
    //    }

    //// wait a few seconds and get consolekey input
    //public static ConsoleKey GetInput()
    //{
    //    //Console.Write("Input: ");
    //    ConsoleKeyInfo consoleKeyInfo = new ConsoleKeyInfo();
    //    ConsoleKey consoleKey = ConsoleKey.NoName; //default

    //    var task = Task.Run(() => consoleKeyInfo = Console.ReadKey());
    //    if (task.Wait(TimeSpan.FromSeconds(timer)))
    //    {
    //        return consoleKeyInfo.Key;
    //    }
    //    else
    //    {
    //        Console.WriteLine("\nListening for messages");
    //        return consoleKey;
    //    }
    //}
    //print each item in a list
    public static void PrintEach(string context, List<ConsoleKey> userInput)
    {
        Console.WriteLine("\n" + context);
        foreach (var input in userInput)
        {
            Console.WriteLine(input);
        }
        Console.ReadLine();
    }
}
}
