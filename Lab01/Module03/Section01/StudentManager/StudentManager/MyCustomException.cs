using System;
namespace StudentManager
{
    [Serializable]

    internal class MyCustomException : FormatException
    {

        public void StringException(string context)
        {
            Console.WriteLine("An exception occured, Please Re-enter the " + context.Remove(context.Length - 1) + ".  (Note: This input only excepts letters. No numbers or special characters");
        }
        public void IntException(string context)
        {
            // custom error msg
            Console.WriteLine("An exception occured, Please Re-enter the " + context.Remove(context.Length - 1) + "." + " (Note: This input only excepts Integers.");
            // If it is a grade show examples
            Console.WriteLine(context.Contains("Grade") ? "Good Input : 56, 89, 90, 10, etc...\nBad Input : 56.2, A+, B, -10, etc..." : "Please make sure your input does not contain letters or special characters");

        }
    }

    // https://www.c-sharpcorner.com/UploadFile/e83792/how-the-custom-exception-is-handle/
    //class TestMyException
    //{
    //    public static void Main(String[] arg)
    //    {
    //        int d, div, res;
    //        div = Int32.Parse(Console.ReadLine());
    //        d = Int32.Parse(Console.ReadLine());
    //        try
    //        {
    //            if (div == 0)
    //            {
    //                throw new MyCustomException();
    //            }
    //        }
    //        catch (MyCustomException e)
    //        {
    //            e.IntException();
    //        }

    //        res = d / div;
    //        Console.WriteLine("Result:{0}", res);
    //    }
    //}
}
