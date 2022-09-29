using System;
namespace StudentManager
{
    [Serializable]

    internal class MyCustomException : FormatException
    {

        public void StringException(string context)
        {
            // String Expception, no numbers or special characters
            Console.WriteLine("An exception occured, Please Re-enter the " + context.Remove(context.Length - 1) + ".  (Note: This input only excepts letters. No numbers or special characters");
        }
        public void IntException(string context)
        {
            // Int Expception, no characters, special characters, doubles or negitive numbers.
            // Custom output for grades
            Console.WriteLine("An exception occured, Please Re-enter the " + context.Remove(context.Length - 1) + "." + " (Note: This input only excepts Integers.");
            // If it is a grade show examples
            Console.WriteLine(context.Contains("Grade") ? "Good Input : 56, 89, 90, 10, etc...\nBad Input : 56.2, A+, B, -10, etc..." : "Please make sure your input does not contain letters or special characters");
        }



    }
}

    // https://www.c-sharpcorner.com/UploadFile/e83792/how-the-custom-exception-is-handle/
