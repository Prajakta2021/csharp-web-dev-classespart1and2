using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolPractice
{
    public class Course
    {
       public List<Student> StudentDetails = new List<Student>();
       public Teacher TeacherName { get; set;}
       public int CourseHours { get; set;}

        public Course(List<Student> studentDetails, Teacher teacherName, int courseHours)
        {
            StudentDetails = studentDetails;
            this.TeacherName = teacherName;
            CourseHours = courseHours;
        }
    }
}
