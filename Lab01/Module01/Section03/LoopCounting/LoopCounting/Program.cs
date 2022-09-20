//
using System;
using System.Linq;


namespace LoopCounting
{
    internal class Program
    {
        static void Main(string[] args)
        {
           for (int i = 0; i < 5; i++) // 5 times
            {
                int count = 1;
                bool goingDown = false; // 
                foreach (var j in Enumerable.Range(1, 19)) // 19 times to have no repeats or 0's
                {
                    //Print current Number
                    Console.WriteLine(count);
                    // if count is greater then 10, or is going down
                    if ((count < 10) && !goingDown)
                    {
                        count++;
                    }
                    else
                    {
                        goingDown = true;
                        count--;
                    }
                }
            }





            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //var count = 1;
            //while (count <= 10)
            //{
            //    Console.WriteLine(count);
            //    count++;
            //}
            Console.ReadLine(); // keep console up
        }
    }
}
