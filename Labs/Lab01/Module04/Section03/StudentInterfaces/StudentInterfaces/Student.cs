using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInterfaces
{
    enum School
    {
        Hogwarts,
        Harvard,
        MIT
    }
    class Student : Member, IGraduate
    {
        static public int Count = 0;

        public int Grade;
        public string Birthday;
        public School School;
        private bool graduate = false; 

        public Student()
        {

        }

        public Student(string name, int grade, string birthday, string address, int phone)
        {
            Name = name;
            Grade = grade;
            Birthday = birthday;
            Address = address;
            Phone = phone;
        }

        public void Graduate()
        {
            graduate = true;
            Console.WriteLine("Student Graduated!");
        }

        public string ShowInfo() 
        {
            return
                "Name: " + Name + " \n" +
                "Grade: " + Grade + " \n" +
                "Birthday: " + Birthday + " \n" +
                "Address: " + Address + " \n" +
                "Phone: " + phone + " \n" +
                "Gradute: " + graduate;
        }

    }
}
