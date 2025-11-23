using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_Assignment9
{
    public class Student
    {
        public int StudentId { get; set; }
        public string FullName { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Department { get; set; }
        public List<CourseGrade> Courses { get; set; } = new List<CourseGrade>();
        public double AverageGrade => Courses.Count > 0 ? Courses.Average(c => c.Grade) : 0;
    }


}
