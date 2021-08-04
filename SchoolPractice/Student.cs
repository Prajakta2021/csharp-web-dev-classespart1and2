
using System;

// Start working here with your Student class.
// To instantiate the Student class, add your code to the Main method in Program

namespace SchoolPractice
{
   public class Student
    {
        /*   public string Name { get; set; }
          
           public int NumberOfCredits { get; set; }
           public double Gpa { get; set; }     */

        public int StudentId { get; set; }
        private static int nextStudentId = 1;
        public string Name { get; set; }
        private readonly int studentId;
        public int NumberOfCredits { get; set; }
        public double Gpa { get; set; }
        
        public Student(string name, int sId, int numberOfCredits, double gpa)
        {
            Name = name;
            studentId = sId;
            NumberOfCredits = numberOfCredits;
            Gpa = gpa;
        }

        public Student(string name, int sId)
        {
            Name = name;
            studentId = sId;
            NumberOfCredits = 0;
            Gpa = 0.0;
        }

        public Student(string name)
        {
            Name = name;
            studentId = nextStudentId;
            nextStudentId++;
            NumberOfCredits = 0;
            Gpa = 0.0;
        }
        public Student()
        {

        }

        public string StudentInfo()
        {
            return (Name + " has a GPA of: " + Gpa);
        }

        public double AddGrade(int courseCredits, double grade)
        {
            // Update the appropriate fields: NumberOfCredits, Gpa
            double qualityScore = courseCredits * grade;
            double totalQualityScore = qualityScore + Gpa;
            NumberOfCredits += courseCredits;
            Gpa = totalQualityScore / NumberOfCredits;
            return Gpa;
        }

        public string GetGradeLevel(int credits)
        {
            // Determine the grade level of the student based on NumberOfCredits

            if (credits <= 29)
            {
                return "freshman";
            }

            else if (credits <= 59 && credits >= 30)
            {
                return "Sophomore";
            }

            else if (credits <= 60 && credits >= 89)
            {
                return "Junior";
            }

            else if (credits >= 90)
            {
                return "Senior";
            }
            else 
            {
                return "Invalid input";
            }
        
        }
        public override string ToString()
        {
            return Name + "(Credits: " + NumberOfCredits + ", GPA : " + Gpa + ")";
        }

        public override Boolean Equals(object toBeCompared)
        {

            if (toBeCompared.GetType() != this.GetType())
            {
                return false;
            }

            Student s = toBeCompared as Student;
            return s.studentId == studentId;
        }

    }
}