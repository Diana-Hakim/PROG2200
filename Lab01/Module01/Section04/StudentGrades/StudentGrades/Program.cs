using System;

namespace StudentGrades
{
    class Classroom
    {
        public string[,] Gradebook { get; set; }
        //private int maxClassroom;
        public int MaxClassroom { get; set; }


        public void addStudent(string name, int grade) 
        {
            int addIndex=0;
            for (int i = 0; i <= Gradebook.GetLength(0) - 1; i++)
            {
                if (Gradebook[i, 0] == null && Gradebook[i, 1] == null) {
                    addIndex = i;
                    break;
                }
                
            }
            Gradebook[addIndex, 0] = name;
            Gradebook[addIndex, 1] = grade.ToString();
        }

        public void print() {
            Console.WriteLine("----------------GRADEBOOK------------------");
            for (int i = 0; i < Gradebook.GetLength(0); i++)
            {
                for (int j = 0; j < Gradebook.GetLength(1); j++)
                {
                    Console.Write(Gradebook[i, j] + "\t");
                }
                if (Gradebook[i, 0] == null && Gradebook[i, 1] == null) { break; }
                Console.WriteLine();
            }
        }

    }




    internal class Program{
        static void Main(string[] args)
        {
            Classroom classroom = new Classroom();
            // Arrays
            string[] studentNames = { "Daniel", "Logan", "Matt", "Andrea" };
            int[] studentGrades = { 90, 66, 80, 92 };

            // Convert 
            convertTo2d(classroom, studentNames, studentGrades);

            while (true) { 
                Console.WriteLine("\nPress Enter to add a student");
                Console.ReadLine();
            
                string name = inputStr("Input Name: ", 15);
                int grade = inputInt("Input Grade: ",0,100);
                //Add
                classroom.addStudent(name, grade);

                //Print
                classroom.print();
            }

            //Console.ReadLine();

        }

        private static void convertTo2d(Classroom classroom, string[] names, int[] grades)
        {
            Console.Write("What is the Max Number of Students:");
            classroom.MaxClassroom = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Converting Students to 2D Array.......");
            var array = new string[classroom.MaxClassroom, 2];
            for (int i = 0; i <= names.Length - 1; i++)
            {
                array[i, 0] = names[i];
                array[i, 1] = grades[i].ToString();
                Console.WriteLine("{0}\t {1}", array[i, 0], array[i, 1]);
                //Console.ReadLine();
            }
            classroom.Gradebook = array;
        }


        private static string inputStr(string context_string, int max)
        {
            //input a sting with the given parmeters 
            int min = 2;
            Console.Write(context_string);
            string input = Console.ReadLine();
            while (!((min <= input.Length) && (input.Length <= max)))
            {
                Console.Write("Input Must Be Between " + min + " to " + max + " characters long: ");
                input = Console.ReadLine();
            }
            return input;
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
