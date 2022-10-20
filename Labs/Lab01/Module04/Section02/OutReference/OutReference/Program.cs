using System;
using System.Globalization;

/*
 * Update the outreference class to have a static parseDouble function. 
 * This will take an input String and a double out. The function will explicitly return true if
 * parsed successfully or false if not. In the Main method provide 2 calls one that sets the value
 * properly, another which passes in your name and returns false. 
 * 
 */


namespace OutReference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  In the Main method provide 2 calls  

            var test = "1.5";
            var outDouble = 0.0;
            //Test(test, outDouble);
            Console.WriteLine("Result: {0}", parseDouble(test, out outDouble));// one that sets the value properly,
            Console.WriteLine("Test type is {0}", outDouble.GetType());
            test = "Ronan";
            outDouble = 0.0;
            //Test(test, outDouble);
            Console.WriteLine("Result: {0}", parseDouble(test, out outDouble));//another which passes in your name and returns false. 
            Console.WriteLine("Test value is {0}", outDouble);
            Console.ReadLine();
        }

        // The function will explicitly return true if parsed successfully or false if not.
        private static bool parseDouble(string test, out double outDouble)
        {
            return double.TryParse(test, out outDouble); // if possible then returns true
        }
    }
}








//internal class Program
//{
//    static void Main(string[] args)
//    {
//        //var x = 2;
//        //Console.WriteLine(x);

//        //Five(out x);
//        //Double(ref x);
//        //Console.WriteLine(x);
//        //Console.ReadLine();


//    }
//    static void Five(out int a)
//    {
//        a = 5;
//        Console.WriteLine(a);
//    }

//    static void Double(ref int a)
//    {
//        a *= 2;
//        Console.WriteLine(a);
//    }

//    //static void parseDouble() { }
//}
//}
