using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTHK
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Teachers> Teachers = new List<Teachers>();

            Console.WriteLine("Please enter the teachers first name!");
            string firstName = Console.ReadLine();

            Console.WriteLine("Please enter the teachers last name");
            string lastName = Console.ReadLine();            

            Console.WriteLine("Is the teacher full time: True/False");
            string isFullTime = Console.ReadLine();

            Teachers teacher = new Teachers(firstName, lastName, isFullTime);

            Teachers.Add(teacher);

            Console.WriteLine("Do you want to add a course");

            while (true)
            {
                if (Console.ReadLine() == "Y")
                {
                    Console.WriteLine("What courses does the teacher have");
                    string courseName = Console.ReadLine();

                    Console.WriteLine("How long are the courses");
                    int duration = int.Parse(Console.ReadLine());

                    Course course = new Course(courseName, duration);

                    teacher.AddCourses(course);

                    Console.WriteLine("Is there anything else? Y/N");
                }

                else
                {
                    break;
                }
            }            
            
            Console.WriteLine(teacher);

            
            Console.ReadKey();
            
        }
        private static void CourseAdd()
        {

            if (Console.ReadLine() == "Y")
            {
                Console.WriteLine("What courses does the teacher have");
                string courseName = Console.ReadLine();

                Console.WriteLine("How long are the courses");
                int duration = int.Parse(Console.ReadLine());

                Course course = new Course(courseName, duration);

                Console.WriteLine("Is there anything else? Y/N");
            }

            else
            {
                return;
            }
            
        }
    }
}
