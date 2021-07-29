using System;

namespace SchoolPractice
{
    class Program
    {
        public static void Main()
        // TODO: Instantiate your objects and test your exercise solutions with print statements here.
        {
            Student praj = new Student();
            praj.Name = "Prajakta";
            praj.StudentId = 111;
            praj.NumberOfCredits = 1;
            praj.Gpa = 4.0;
            Console.WriteLine($"{praj.Name} ({praj.StudentId})");
            Console.ReadLine();
           
        }
    }
}
