using System;

namespace Survey
{
    public class Stats
    {

        //Public Variables
        public event PostHandler Post;
        public delegate void PostHandler(Stats stats);

        public void Start()
        {
            //Prints that the Statistics Team is waiting for this survey to be completed
            Log("The Statistics Team is waiting for this survey to be completed....");
            if (Post != null)
            {
                Program.post += HasPosted;
                Log("Statistics: Post is not null");
            }
        }

        public void HasPosted()
        {
            //Prints that the survey has been posted then calls MessagePrt() in Marketing Class
            Log("Survey post, Run Stats");
            Post(this); // post sens to marketing
        }
        
        private void Log(string str)
        {
            // Used for testing, prints what is given to it in grey
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(str);
            Console.ForegroundColor = ConsoleColor.White;
        }

    }
}


