using System;
using System.CodeDom;
using System.Runtime.InteropServices.WindowsRuntime;

namespace Zodiac
{
    internal class Person
    {

        //public string FirstName { get; set; }
        //public string LastName { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
        //public int Age { get; set;}
        public string Zodiac { get; set; }

        // Static varribles for calcutions and error checking
        //months per year and days per month
        private static readonly int LASTMONTHYEAR = 12; // FIRST MONTH OF THE YEAR
        private static readonly int FIRSTMONTHYEAR = 1; // LAST MONTH OF THE YEAR
        private static readonly int FIRSTDAYMONTH = 1;
        private static readonly int[] LASTDAYMONTH = new int[] { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        //Z odiac info
        private static readonly string[] ZODIACNAMES = new string[] { "Capricorn", "Aquarius", "Pisces", "Aries", "Taurus", "Gemini", "Cancer", "Leo", "Virgo", "Libra", "Scorpio", "Sagittarius" };
        private static readonly int[] ZODIACDATES = new int[] { 20, 19, 20, 20, 21, 22, 22, 23, 23, 23, 22, 22 };


        public Person()
        {
            // Get the users input
            Console.WriteLine("Find your Zodiac:");
            Month = InputMonth();
            Day = InputDay();
            Zodiac = SetZodiac();
        }

        public Person(int month, int date)
        {
            try {
                TestInt(month, FIRSTMONTHYEAR, LASTMONTHYEAR);
                TestInt(date, FIRSTDAYMONTH, LASTDAYMONTH[month - 1]);
           }
            catch (IndexOutOfRangeException ex)
            { 
                Console.WriteLine("Error: Not Proper Input: " + ex.Message);
            
            }
            // assign 
            Month = month;
            Day = date;
            Zodiac = SetZodiac();
        }


        // ZODIAC CALCULATIONS 


        public string SetZodiac()
        {  
            // Switch
            switch (Month) // Note: I believe that a switch case could be replaced for something beter 
            { //> Zodiac = ZODIACNAMES[FindZodiac(ZODIACDATES[Month], Month-1, Month)]; and a if statement for december would work fine
                case 1:// Jan:  Capricorn vs Aquarius
                    //int zodiac = FindZodiac(ZODIACDATES[Month - 1], Month - 1, Month);
                    //if (zodiac == 0) { Console.WriteLine("Capricorn"); }
                    //else { Console.WriteLine("Aquarius"); }
                    return ZODIACNAMES[FindZodiac(ZODIACDATES[Month - 1], Month - 1, Month)]; 
                case 2:// Feb:  Aquarius vs Pisces
                    return ZODIACNAMES[FindZodiac(ZODIACDATES[Month - 1], Month - 1, Month)]; 
                case 3:// Mar:  Pisces vs Aries
                    return ZODIACNAMES[FindZodiac(ZODIACDATES[Month - 1], Month - 1, Month)]; 
                case 4:// Apr:  Aries vs Taurus
                    return ZODIACNAMES[FindZodiac(ZODIACDATES[Month - 1], Month - 1, Month)]; 
                case 5:// May:  Taurus vs Gemini
                    return ZODIACNAMES[FindZodiac(ZODIACDATES[Month - 1], Month - 1, Month)]; 
                case 6:// June: Gemini vs Cancer
                    return ZODIACNAMES[FindZodiac(ZODIACDATES[Month - 1], Month - 1, Month)]; 
                case 7:// July: Cancer vs Leo
                    return ZODIACNAMES[FindZodiac(ZODIACDATES[Month - 1], Month - 1, Month)]; 
                case 8:// Aug:  Leo vs Virgo
                    return ZODIACNAMES[FindZodiac(ZODIACDATES[Month - 1], Month - 1, Month)]; 
                case 9:// Sept: Virgo vs Libra
                    return ZODIACNAMES[FindZodiac(ZODIACDATES[Month - 1], Month - 1, Month)]; 
                case 10:// Oct:  Libra vs Scorpio
                    return ZODIACNAMES[FindZodiac(ZODIACDATES[Month - 1], Month - 1, Month)]; 
                case 11:// Nov:  Scorpio vs Sagittarius
                    return ZODIACNAMES[FindZodiac(ZODIACDATES[Month - 1], Month - 1, Month)]; 
                case 12:// Dec:  Sagittarius vs Capricorn
                    return ZODIACNAMES[FindZodiac(ZODIACDATES[Month - 1], Month - 1, 0)];
                default: // Else, should not see because of error checking
                    return "Not Found";
            }
        }

        public int FindZodiac(int endday, int month1, int month2)
        {
            // Find which month the zodaic is under 
            return (Day < endday) ? month1 : month2;
        }


        // INPUT



        private static (bool, int) GetInputInt(string context_string, int min, int max) {
            Console.Write(context_string); // Input
            int input;
            //Console.WriteLine(int.TryParse(Console.ReadLine(), out input) +" "+" "+ TestInt(input, min, max));
            bool correctInput = int.TryParse(Console.ReadLine(), out input) && TestInt(input, min, max); // Bool: If input is Incorrect / Correct 
            Console.Write((!correctInput) ? "Enter a Number Between " + min + " - " + max + " \n" : ""); // Output: if input is Incorrect / Correct
            return (correctInput, input);
        }


        private static bool TestInt(int test, int min, int max)
        {
            return (min <= test && test <= max);
        }


        private static int InputInt(string context_string, int min, int max)
        {
            //input an int with the given parmeters 
            int input = 0;
            bool correctInput = false; // Bool: false in order to enter while loop 
            while (!correctInput)
            {
                (correctInput, input) = GetInputInt(context_string, min, max);
            }
            return input;
        }



        private static int InputMonth()
        {
            //Use InputInt function to find users birth month
            return InputInt("Input the month you were born in:", FIRSTMONTHYEAR, LASTMONTHYEAR);
        }

        private int InputDay()
        {
            //Use InputInt function to find users birth date, this will also check to see if the birthday is possible (not needed but usefull to have)
            return InputInt("Input the date you were born: ", FIRSTDAYMONTH, LASTDAYMONTH[Month-1]); // check if possible
        }
    }
}