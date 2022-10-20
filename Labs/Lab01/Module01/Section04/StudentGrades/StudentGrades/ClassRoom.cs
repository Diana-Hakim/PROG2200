using System;
using System.Runtime.InteropServices;

namespace StudentGrades
{
    internal class ClassRoom
    {
        private static string[,] gradebook;
        private static int maxClassRoom;
        private static int index = 0;
        public string[,] Gradebook { get; set; }
        public int MaxClassRoom { get; set; }
        public int Index { get; set; }



        public ClassRoom(string[] studentNames, int[] studentGrades)
        {
            //Convert two lists to a 2D array, add a student to the 2d array
            convertTo2d(studentNames, studentGrades);
            for (int i = 0; i < (maxClassRoom - studentNames.Length); i++)
            {
                Console.WriteLine("\nPress Enter to add a student");
                Console.ReadLine();

                string name = inputName();
                int grade = inputInt("Input Grade: ");
                //Add
                addStudent(name, grade);

                //Print
                print();
            }
        }

        public ClassRoom(int max)
        {
            maxClassRoom = max;
            gradebook = new string[maxClassRoom, 2];
        }


        public bool addStudent(string name, int grade)
        {
            //Add a student to the 2d array

            if (gradebook.GetLength(0) != index)
            {
                gradebook[index, 0] = name;
                gradebook[index, 1] = grade.ToString();
                index++;
                Console.WriteLine("Student Added");
                return true;
            }
            else
            {
                Console.WriteLine("Cannot add more students, Max Reached");
                return false;
            }

        }

        private static void convertTo2d(string[] names, int[] grades)
        {
            // Merge the two arrays given into one a single two-dimensional array, these arrays must be the same length
            // This function will ask users to enter what is the max number of items in the array are.
            maxClassRoom = 0;
            while (maxClassRoom < names.Length)
            {
                maxClassRoom = inputInt("What is the Max Number of Students:");
                Console.Write((maxClassRoom < names.Length) ? "Cannot add given list, max number is too small. " : "Converted given info to a 2D Array\n");
            }
            var array = new string[maxClassRoom, 2];
            for (int i = 0; i <= names.Length - 1; i++)
            {
                array[i, 0] = names[i];
                array[i, 1] = grades[i].ToString();
                index = i;
            }
            index++;
            gradebook = array;
        }

        private static string inputName()
        {
            //input a sting with the given parmeters 
            int min = 2;
            int max = 15;
            Console.Write("Input Students Name: ");
            string input = Console.ReadLine();
            while (!((min <= input.Length) && (input.Length <= max)))
            {
                Console.Write("Input Must Be Between " + min + " to " + max + " characters long: ");
                input = Console.ReadLine();
            }
            return input;
        }

        private static int inputInt(string contextString)
        {
            //input an int with the given parmeters 
            int input = 0;
            int min = 0;
            int max = 100;
            bool correctInput = false; // Bool: false in order to enter while loop 
            while (!correctInput)
            {
                Console.Write(contextString); // Input
                correctInput = int.TryParse(Console.ReadLine(), out input) && (min <= input && input <= max); // Bool: If input is Incorrect / Correct 
                Console.Write((!correctInput) ? "Enter a Number Between " + min + " - " + max + " \n" : ""); // Output: if input is Incorrect / Correct 
            }
            return input;
        }


        public void print()
        {
            Console.WriteLine("----------------GRADEBOOK------------------");
            for (int i = 0; i < gradebook.GetLength(0); i++)
            {
                for (int j = 0; j < gradebook.GetLength(1); j++)
                {
                    Console.Write(gradebook[i, j] + "\t");
                }
                if (gradebook[i, 0] == null && gradebook[i, 1] == null) { break; }
                Console.WriteLine();
            }
        }

    }
}


//public void addStudent(string name, int grade)
//{
//    int addIndex = 0;
//    Console.WriteLine(checkForValue(null) == false ? "Cannot add more students" : "");
//    for (int i = 0; i <= gradebook.GetLength(0) - 1; i++)
//    {
//        if (gradebook[i, 0] == null && gradebook[i, 1] == null)
//        {
//            addIndex = i;
//            Console.WriteLine(addIndex + ", " + index);
//            break;
//        }
//    }
//    gradebook[addIndex, 0] = name;
//    gradebook[addIndex, 1] = grade.ToString();
//}
