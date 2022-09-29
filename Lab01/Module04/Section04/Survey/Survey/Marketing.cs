using System;
using System.Runtime.Remoting.Messaging;

namespace Survey
{
    public class Marketing
    {
        //Acts as a listener to the post event 
        public void Listen(Stats stats)
        {
            Log("The Marketing Team is waiting for this survey to be completed....");
            stats.Post += new Stats.PostHandler(MessagePrt); // assign
        }

        private void MessagePrt(Stats stats)
        {
            Log("\n\nPOSTED: AT "+ DateTime.Now);
            Log("Thank you for completing the survey. You are now subscribed to ten of our newsletters.");
        }

        private void Log(string str) 
        {
            // Used for testing, prints what is given to it in blue
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(str);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}

