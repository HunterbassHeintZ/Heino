using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTHK
{
    class Teachers
    {   public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IsFullTime { get; set; }
        public List<Course> Courses { get; set; }

        
        public Teachers(string firstName, string lastName, string isFullTime)
        {
            FirstName = firstName;
            LastName = lastName;
            IsFullTime = isFullTime;
            Courses = new List<Course>();
        }
        
        public void AddCourses(Course course)
        {
            Courses.Add(course);
        }        

        public override string ToString()
        {
            return $"{FirstName} {LastName} {IsFullTime} ";
        }
    }
}
