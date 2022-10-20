using System;
using System.Collections.Generic;
using System.Net.Http.Headers;

namespace StudentManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>();
            var adding = true;
            while (adding)
            {
                // New Student
                var newStudent = new Student();
                newStudent.Name = Util.Console.AskName("Students Name:");
                newStudent.Grade = Util.Console.AskInt("Students Grade:");
                newStudent.Birthday = Util.Console.AskString("Students Birthday:");
                newStudent.Address = Util.Console.AskString("Students Address:");
                newStudent.Phone = Util.Console.AskInt("Students Phone Number:");
                students.Add(newStudent);
                Student.Count++;
                Console.WriteLine("Student Count {0}", Student.Count);

                // Add More?
                Console.WriteLine("Add another? y/n");
                if (Console.ReadLine() != "y" || Console.ReadLine() != "Y")
                {
                    adding = false;
                }

                // Print students
                foreach (var student in students) {
                    Console.WriteLine(student.Name+", "+student.Grade);
                }
            }
        }
    }
} 
class Member
{
    public string Name;
    public string Address;
    protected int phone;
    public int Phone
    {
        set
        {
            phone = value;
        }
    }
}
class Student : Member
{
    static public int Count = 0;
    public int Grade;
    public string Birthday;
    public Student() {}
    public Student(string name, int grade, string birthday, string address, int phone ) 
    {
        Name = name;
        Grade = grade;
        Birthday = birthday;
        Address = address;
        Phone = phone;
    }
}
