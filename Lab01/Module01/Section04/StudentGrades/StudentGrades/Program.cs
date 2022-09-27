using System;
using System.Reflection;

namespace StudentGrades
{
    internal class Program{
        static void Main(string[] args)
        {
            
            // Arrays
            string[] studentNames = { "Daniel", "Logan", "Matt", "Andrea" };
            int[] studentGrades = { 90, 66, 80, 92 };

            // Convert 2d and ask for input
            new ClassRoom(studentNames, studentGrades);

            // Testing console output only, no input
            ClassRoom classroom = new ClassRoom(30);
            classroom.addStudent("matt", 55);
            classroom.print();
            classroom.addStudent("matt", 55);
            classroom.print();
            classroom.addStudent("matt", 55);
            classroom.print();
            classroom.addStudent("matt", 55);
            classroom.print();
            Console.ReadLine();

        }


    }
}

