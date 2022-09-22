using System;

namespace superClass
{
    public class Animal
    {
        public string repColor = "brown";
    }
    public class Reptile : Animal
    {
        string repColor = "green";
        public void display()
        {
            Console.WriteLine("Color: " + base.repColor);
            Console.WriteLine("Color: " + repColor);
        }
    }
    public class Demo
    {
        public static void Main()
        {
            Reptile rep = new Reptile();
            rep.display();
        }
    }
}
