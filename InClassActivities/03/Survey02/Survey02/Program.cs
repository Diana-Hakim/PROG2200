using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Chat
{
    internal class Program
    {
        private static double TIMER = .5; //sec
        private static int TIMER_MILI_SEC = (int)(TIMER*1000); //milsec

        static void Main(string[] args)
        {
            // ----------------------------------------------- Phase 1 
            ////Part 1
            ////1.Run as Client vs Server
            //Console.WriteLine("Listening for messages");
            ////2.User input mode: when user press "I" key.            
            //var userKey = Console.ReadKey();
            ////3.Display incoming message
            ////4.Allow for input
            ////5.Let the user quit
            //Console.WriteLine($"You typed {userKey.Key}");
            //Console.Beep();
            //Console.ReadLine();
            // ----------------------------------------------- Phase 2 
            //Part 1
            //1.Run as Client vs Server
            //Console.WriteLine("Listening for messages");
            //2.User input mode: when user press "I" key.            
            //while (true)
            //{
            //    var userKey2 = Console.ReadKey();
            //    //3.Display incoming message
            //    //4.Allow for input
            //    //5.Let the user quit
            //    Console.WriteLine($"You typed {userKey2.Key}");
            //    Console.Beep();
            //    Console.ReadLine();
            //}
            // ----------------------------------------------- Phase 3
            //Part 1
            //Console.WriteLine("Start Messaging........");
            //while (true)
            //{
            //    //ConsoleKeyInfo consoleKeyInfo = new ConsoleKeyInfo();
            //    ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();
            //    System.Threading.Thread.Sleep(500);
            //    while (!Console.KeyAvailable)
            //    {
            //        Console.WriteLine("Listening for messages");
            //        System.Threading.Thread.Sleep(2000);
            //    }
            //    Console.WriteLine($"You typed {consoleKeyInfo.Key}");
            //    Console.Beep();
            //    //Console.WriteLine("Message Sent");
            //    //Console.ReadLine();
            //}
            // ----------------------------------------------- Phase 4


            // ---------------------------Phase 4 My Attempt With Video (see below for without)
            Console.WriteLine("Start Messaging........");
            Console.WriteLine("Press 'ESC' to exit");
            ConsoleKeyInfo userKeyInfo = new ConsoleKeyInfo(); // 
            do {
                Console.WriteLine("Listening for messages"+TIMER_MILI_SEC);
                if (Console.KeyAvailable){
                    userKeyInfo = Console.ReadKey();
                    if (!(userKeyInfo.Key == ConsoleKey.I)){ // anything but i, prints out 
                        Console.WriteLine($": You typed {userKeyInfo.Key}");
                        Thread.Sleep(TIMER_MILI_SEC);
                    }
                    else { // insert a line of text by pressing 'i'
                        Console.WriteLine(": ‘I’ is PRESSED >>");
                        Console.ReadLine();
                    }
                    
                }
            } while (!(userKeyInfo.Key == ConsoleKey.Escape));// to escape the loop 
        }
    }
}









        // ---------------------------Phase 4 My Attempt With Out Video
        //public static void RunWOVideo() { 
        //    Console.WriteLine("Start Messaging........");
        //    Console.WriteLine("Press 'ESC' to exit");
        //    List<ConsoleKey> userInput = new List<ConsoleKey>();
        //    ConsoleKey input = GetInput(); //first input

        //    while (!(input == ConsoleKey.Escape)){ // to get out
        //        if (!(input == ConsoleKey.NoName)){ // enter input
        //            Console.WriteLine((input == ConsoleKey.I) ? ": ‘I’ is PRESSED >>" : $": You typed {input}");
        //            userInput.Add(input);
        //            Console.Beep();
        //        }
        //        input = GetInput(); // get input
        //    }
        //    PrintEach("Items Entered.......", userInput);
        //    Console.ReadLine();
        //}
        



        //// wait a few seconds and get consolekey input
        //public static ConsoleKey GetInput(){
        //    //Console.Write("Input: ");
        //    ConsoleKeyInfo consoleKeyInfo = new ConsoleKeyInfo();
        //    ConsoleKey consoleKey = ConsoleKey.NoName; //default

        //    var task = Task.Run(() => consoleKeyInfo = Console.ReadKey());
        //    if (task.Wait(TimeSpan.FromSeconds(TIMER))){
        //        return consoleKeyInfo.Key;
        //    }else{
        //        Console.WriteLine("\nListening for messages");
        //        return consoleKey;
        //    }
        //}
        ////print each item in a list
        //public static void PrintEach(string context,List<ConsoleKey> userInput)
        //{
        //    Console.WriteLine("\n"+context);
        //    foreach (var input in userInput)
        //    {
        //        Console.WriteLine(input);
        //    }
        //    Console.ReadLine();
        //}
