using System;
using System.Globalization;

namespace Zodiac
{
    internal class Person
    {

        //public string FirstName { get; set; }
        //public string LastName { get; set; }
        public int Month { get; set; }
        public int Day {get; set;}
        //public int Age { get; set;}
        //private string zodiac;
        public string Zodiac { get; set; }


        public Person() {
            Console.WriteLine("Find your Zodiac:");
            Month = inputInt("Input the month you were born in:", 1, 12);
            Day = inputInt("Input the date you were born: ", 1, 31);
            SetZodiac();
        }

        public Person(int month, int date)
        {
            Month = month;
            Day = date;
            SetZodiac();
        }

        public void SetZodiac() { // Note: I believe that a switch case could be replaced for something beter
            // Arrays
            string[] zodiacList = new string[] { "Capricorn", "Aquarius", "Pisces", "Aries", "Taurus", "Gemini", "Cancer", "Leo", "Virgo", "Libra", "Scorpio", "Sagittarius" };
            int[] zodiacDate = new int[] {20, 19, 20, 20, 21, 22, 22, 23, 23, 23, 22, 21}; 
            // Switch
            switch (Month)
            {
                case 1:
                    //Console.WriteLine(1+". "+zodiacList[0]+" , "+ zodiacList[1]);
                    Zodiac = zodiacList[FindZodiac(zodiacDate[0], 0, 1)];
                    break;
                case 2:
                    //Console.WriteLine(2 + ". " + zodiacList[1] + " , " + zodiacList[2]);
                    Zodiac = zodiacList[FindZodiac(zodiacDate[1], 1, 2)];
                    break;
                case 3:
                    //Console.WriteLine(3 + ". " + zodiacList[2] + " , " + zodiacList[3]);
                    Zodiac = zodiacList[FindZodiac(zodiacDate[2], 2, 3)];
                    break;
                case 4:
                    //Console.WriteLine(4 + ". " + zodiacList[3] + " , " + zodiacList[4]);
                    Zodiac = zodiacList[FindZodiac(zodiacDate[3], 3, 4)];
                    break;
                case 5:
                    //Console.WriteLine(5 + ". " + zodiacList[4] + " , " + zodiacList[5]);
                    Zodiac = zodiacList[FindZodiac(zodiacDate[4], 4, 5)];
                    break;
                case 6:
                    //Console.WriteLine(6 + ". " + zodiacList[5] + " , " + zodiacList[6]);
                    Zodiac = zodiacList[FindZodiac(zodiacDate[5], 5, 6)];
                    break;
                case 7:
                    //Console.WriteLine(7 + ". " + zodiacList[6] + " , " + zodiacList[7]);
                    Zodiac = zodiacList[FindZodiac(zodiacDate[6], 6, 7)];
                    break;
                case 8:
                    //Console.WriteLine(8 + ". " + zodiacList[7] + " , " + zodiacList[8]);
                    Zodiac = zodiacList[FindZodiac(zodiacDate[7], 7, 8)];
                    break;
                case 9:
                    //Console.WriteLine(9 + ". " + zodiacList[8] + " , " + zodiacList[9]);
                    Zodiac = zodiacList[FindZodiac(zodiacDate[8], 8, 9)];
                    break;
                case 10:
                    //Console.WriteLine(10 + ". " + zodiacList[9] + " , " + zodiacList[10]);
                    Zodiac = zodiacList[FindZodiac(zodiacDate[9], 9, 10)];
                    break;
                case 11:
                    //Console.WriteLine(11 + ". " + zodiacList[10] + " , " + zodiacList[11]);
                    Zodiac = zodiacList[FindZodiac(zodiacDate[10], 10, 11)];
                    break;
                case 12:
                    //Console.WriteLine(12 + ". " + zodiacList[11] + " , " + zodiacList[0]);
                    Zodiac = zodiacList[FindZodiac(zodiacDate[11], 11, 0)];
                    break;
                default:
                    Zodiac = "Not Found";
                    //Console.WriteLine("Your zodiac sign was not found! Please try again!");
                    break;
            }
        }

        public int FindZodiac(int endday, int month1, int month2) 
        {
            // Find which mo
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
    }
}