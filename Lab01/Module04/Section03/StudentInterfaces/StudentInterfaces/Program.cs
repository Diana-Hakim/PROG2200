using System;
using System.Collections.Generic;

/*
 * After completing the code in this section, extend by doing the following: 
 * move Student & Member to their own class files. y
 * create an interface called IGraduate with a method of graduate(). y
 * Make student implement IGraduate as well as extend Member. y
 * Make sure the graduate() method prints to the console when called. y
 * Add a new class called Registrar that;
 *  - takes the list of students as <IGraduate>s y
 *  - calls the graduate() method on each one in a graduateAll() method. y 
This should be called at the end of the Program main method.y
 * 
 * 
*/




namespace StudentInterfaces
{

    class Program
    {
        static List<Student> students = new List<Student>();

        static void Main(string[] args)
        {
            //PayRoll payRoll = new PayRoll();
            //payRoll.PayAll();
            //Console.ReadLine();
            //Graduate grads = new Graduate();
            //grads.GraduateAll();

            Registrar registrar = new Registrar(new Graduate().Grads);
            registrar.GraduateAll();
            
            Console.ReadLine();
        }
    }
}




//var adding = true;

//while (adding)
//{
//    try
//    {
//        var newStudent = new Student();

//        newStudent.Name = Util.Console.Ask("Student Name: ");

//        newStudent.Grade = Util.Console.AskInt("Student Grade: ");

//        newStudent.School = (School)Util.Console.AskInt("School Name (type the corresponding number): \n 0: Hogwarts High \n 1: Harvard \n 2: MIT \n)");

//        newStudent.Birthday = Util.Console.Ask("Student Birthday: ");

//        newStudent.Address = Util.Console.Ask("Student Address: ");

//        newStudent.Phone = Util.Console.AskInt("Student Phone Number: ");

//        students.Add(newStudent);
//        Student.Count++;
//        Console.WriteLine("Student Count: {0}", Student.Count);

//        Console.WriteLine("Add another? y/n");

//        if (Console.ReadLine() != "y")
//            adding = false;
//    }
//    catch (FormatException msg)
//    {
//        Console.WriteLine(msg.Message);
//    }
//    catch (Exception)
//    {
//        Console.WriteLine("Error adding student, Please try again");
//    }
//}

//foreach (var student in students)
//{
//    Console.WriteLine("Name: {0}, Grade: {1}", student.Name, student.Grade);
//}
//Exports();
//        }

//        static void Import()
//{
//    var importedStudent = new Student("Jenny", 86, "birthday", "address", 123456);
//    Console.WriteLine(importedStudent.Name);
//}

//static void Exports()
//{
//    foreach (var student in students)
//    {
//        switch (student.School)
//        {
//            case School.Hogwarts:
//                Console.WriteLine("Exporting to Hogwarts");
//                break;
//            case School.Harvard:
//                Console.WriteLine("Exporting to Harvard");
//                break;
//            case School.MIT:
//                Console.WriteLine("Exporting to MIT");
//                break;
//        }
//    }
//}
//    }