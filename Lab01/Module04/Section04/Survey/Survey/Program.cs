using System;
/*
 * After completing the code in this section, extend by doing the following: 
 * - The marketing department also wants to be notified when the Survey is completed.
 * - Add a second class called Marketing that will act as a listener to the post event that will print to the console - 
 *      - "Thank you for completing the survey. You are now subscribed to ten of our newsletters." 
 * - Demonstrate to your instructor in the video recording part.
 */

namespace Survey
{
    class Program
    {
        static public event Action post;
        static void Main(string[] args)
        {
            Stats stats = new Stats();
            new Marketing().Listen(stats);
            stats.Start(); // 
            new Data(); // user input
            post?.Invoke(); // or run post if not null

            Console.ReadLine();
        }


    }
    class Data
    {
        // This Class holds users Name, Age, and Birth Month.
        // Once called this function askes for user input.

        // Variables
        private string name;
        private int age;
        private string month;


        public Data() 
        {
            //User input for Name, Age, and Birth Month, then prints info.

            Console.WriteLine("What is your name?");
            name = TryAnswer();

            Console.WriteLine("What is your age?");
            age = int.Parse(TryAnswer());

            Console.WriteLine("What month were you born in?");
            month = TryAnswer();
            
            Display();
        }


        private static string TryAnswer()
        {
            //Return string user input
            var question = Console.ReadLine();
            if (question == "")
            {
                Console.WriteLine("You didn't type anything, please try again:");
                return Console.ReadLine();
            }
            return question;
        }



        private void Display()
        {
            //Print Data 
            Console.WriteLine("_______________DATA_________________");
            Console.WriteLine("Your name is: {0}", name);
            Console.WriteLine("Your age is: {0}", age);
            Console.WriteLine("Your birth month is: {0}", month);
            Console.WriteLine("____________________________________");
        }
    }
}
