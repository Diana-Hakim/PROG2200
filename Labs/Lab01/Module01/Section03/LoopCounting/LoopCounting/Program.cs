//
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace LoopCounting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            countLoop(5, 10);

            // Testing
            //countLoop(5, 11);
            //countLoop(10, 5); 
            //countLoop(2, 3); 
            //countLoop(1, 10);

            //keep console up
            Console.ReadLine(); 
        }

        /// <summary>
        /// Write up to the max number given then down to 1, this will repeats according to the number given (repeats).
        /// </summary>
        /// <param name="repeats">positive input only, number of times output will count up and down. </param>
        /// <param name="max">positive input only, the max number the program will print untill. </param>
        private static void countLoop(int repeats, int max) {// number of repeats and the max number to reach
            // Variables
            int count = 0;
            bool goingDown = false;
            max = Math.Abs(max);
            // For loops 
            for (int i = 0; i < repeats * 2; i++) {// Ex. 5 * 2
                for (int j = 0; j < max; j++) { // Ex. print 10 times: 1-10 or 10-1
                    int change = (count < max && (!goingDown)) ? 1 : -1; // if larger than the max then go down 
                    count += change; // add to count
                    Console.Write(count + " | "); // Print out the count
                }
                Console.WriteLine();
                goingDown = !goingDown; // to switch true and false
                count = (max + 1) * Convert.ToInt32(goingDown); // a way to print max twice without another if statement, up = 1, down = 0 
            }
        }
    }
}



// Other Tries
//for (int i = 0; i < 5; i++) // 5 times
//{
//    int count = 1;
//    bool goingdown = false; // 
//    foreach (var j in Enumerable.Range(1, 19)) // 19 times to have no repeats 1,2,3,4,5,6,7,8,9,10,9,8,7,6,5,4,3,2,1 = count of 19
//    {
//        //print current number
//        Console.WriteLine(count);
//        // if count is greater then 10, or is going down
//        if ((count < 10) && !goingdown)
//        {
//            count++;
//        }
//        else
//        {
//            goingdown = true;
//            count--;
//        }
//    }
//}

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