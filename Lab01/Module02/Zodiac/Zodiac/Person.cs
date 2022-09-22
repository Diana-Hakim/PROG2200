using System;
using System.Globalization;

namespace Zodiac
{
    internal class Person
    {

        //public string FirstName { get; set; }
        //public string LastName { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
        //public int Age { get; set;}
        //private string zodiac;
        public string Zodiac { get; set; }


        public Person()
        {
            // Get the users input
            Console.WriteLine("Find your Zodiac:");
            Month = inputMonth();
            Day = inputDay();
            SetZodiac();
        }

        public Person(int month, int date)
        {
            // Get input manually entered, no error testing
            Month = month;
            Day = date;
            SetZodiac();
        }

        public void SetZodiac()
        {  
            // Arrays
            string[] zodiacList = new string[] { "Capricorn", "Aquarius", "Pisces", "Aries", "Taurus", "Gemini", "Cancer", "Leo", "Virgo", "Libra", "Scorpio", "Sagittarius" };
            int[] zodiacDate = new int[] { 20, 19, 20, 20, 21, 22, 22, 23, 23, 23, 22, 22 };
            // Switch
            switch (Month) // Note: I believe that a switch case could be replaced for something beter 
            { //> Zodiac = zodiacList[FindZodiac(zodiacDate[Month], Month-1, Month)]; and a if statement for december would work fine
                case 1:// Jan:  Capricorn vs Aquarius
                    Zodiac = zodiacList[FindZodiac(zodiacDate[Month - 1], Month - 1, Month)]; 
                    break;
                case 2:// Feb:  Aquarius vs Pisces
                    Zodiac = zodiacList[FindZodiac(zodiacDate[Month - 1], Month - 1, Month)]; 
                    break;
                case 3:// Mar:  Pisces vs Aries
                    Zodiac = zodiacList[FindZodiac(zodiacDate[Month - 1], Month - 1, Month)]; 
                    break;
                case 4:// Apr:  Aries vs Taurus
                    Zodiac = zodiacList[FindZodiac(zodiacDate[Month - 1], Month - 1, Month)]; 
                    break;
                case 5:// May:  Taurus vs Gemini
                    Zodiac = zodiacList[FindZodiac(zodiacDate[Month - 1], Month - 1, Month)]; 
                    break;
                case 6:// June: Gemini vs Cancer
                    Zodiac = zodiacList[FindZodiac(zodiacDate[Month - 1], Month - 1, Month)]; 
                    break;
                case 7:// July: Cancer vs Leo
                    Zodiac = zodiacList[FindZodiac(zodiacDate[Month - 1], Month - 1, Month)]; 
                    break;
                case 8:// Aug:  Leo vs Virgo
                    Zodiac = zodiacList[FindZodiac(zodiacDate[Month - 1], Month - 1, Month)]; 
                    break;
                case 9:// Sept: Virgo vs Libra
                    Zodiac = zodiacList[FindZodiac(zodiacDate[Month - 1], Month - 1, Month)]; 
                    break;
                case 10:// Oct:  Libra vs Scorpio
                    Zodiac = zodiacList[FindZodiac(zodiacDate[Month - 1], Month - 1, Month)]; 
                    break;
                case 11:// Nov:  Scorpio vs Sagittarius
                    Zodiac = zodiacList[FindZodiac(zodiacDate[Month - 1], Month - 1, Month)]; 
                    break;
                case 12:// Dec:  Sagittarius vs Capricorn
                    Zodiac = zodiacList[FindZodiac(zodiacDate[Month - 1], Month - 1, 0)];
                    break;
                default: // Else
                    Zodiac = "Not Found";
                    break;
            }
        }

        public int FindZodiac(int endday, int month1, int month2)
        {
            // Find which month the zodaic is under 
            return (Day < endday) ? month1 : month2;
        }

        private static int inputInt(string context_string, int min, int max)
        {
            //input an int with the given parmeters 
            int input = 0;
            bool correctInput = false; // Bool: false in order to enter while loop 
            while (!correctInput)
            {
                Console.Write(context_string); // Input
                correctInput = int.TryParse(Console.ReadLine(), out input) && (min <= input && input <= max); // Bool: If input is Incorrect / Correct 
                Console.Write((!correctInput) ? "Enter a Number Between " + min + " - " + max + " \n" : ""); // Output: if input is Incorrect / Correct 
            }
            return input;
        }

        private static int inputMonth()
        {
            //Use inputInt function to find users birth month
            return inputInt("Input the month you were born in:", 1, 12);
        }

        private int inputDay()
        {
            //Use inputInt function to find users birth date, this will also check to see if the birthday is possible (not needed but usefull to have)
            int[] lastDay = new int[] {31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
            return inputInt("Input the date you were born: ", 1, lastDay[Month-1]);
        }
    }
}