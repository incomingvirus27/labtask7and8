using System;

namespace SchoolPortal
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student(34, "Luke", 789);
            Console.WriteLine("Please enter your department");
            string department = Console.ReadLine();
            if(department == csi)
            Console.WriteLine("Hello World!");
        }
    }
}
