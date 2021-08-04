using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolPractice
{
    public class Course
    {
       public List<Student> StudentDetails = new List<Student>();
        public Teacher FirstName { get; set; }
        public int CourseHours { get; set; }
        public string Subject { get; set; }

        public Course(List<Student> studentDetails, Teacher teacherName, int courseHours)
        {
            StudentDetails = studentDetails;
            this.FirstName = teacherName;
            CourseHours = courseHours;
        }
        public override string ToString()
        {
            return Subject + " (Subject: " + FirstName + ", Instructor: " + StudentDetails + ")";
        }

        public override Boolean Equals(object coursesCompared)
        {
            if (coursesCompared.GetType() != this.GetType())
            {
                return false;
            }

            Course sub = coursesCompared as Course;
            return sub.StudentDetails == StudentDetails;
        }

    }
}
