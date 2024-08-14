using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace seation_6
{
    internal class School
    {
        public School(List<Students> students = null, List<Courses> courses = null)
        {
            Students = new List<Students>();
            Courses = new List<Courses>();
        }

        public List<Students> Students { get; set; }
        public List<Courses> Courses { get; set; }

        public void DisplayAllStudensts()
        {
            foreach (var student in Students)
            {
                student.DesplayDetails();
            };
        }      
        public void DisplayAllCourses()
        {
            foreach (var course in Courses)
            {
                course.DesplayDetails();
            };
        }

        public void AddStudent(Students student)
        {
            Students.Add(student);
            Console.WriteLine($"Student {student.Name} Added");
        }
        public void AddCourse(Courses course)
        {
            Courses.Add(course);
            Console.WriteLine($"Course {course.Name} Added");
        }

        public void EnrollStudentInCourse(int StudentId, Courses courseName)
        {
            Students student = Students.Find((e) => e.Id == StudentId);

            //Student student = new();
            //foreach (var e in Students)
            //{
            //    if(e.Id == StudentId)
            //    {
            //        student = e;
            //        break;
            //    }
            //}

            student.Courses.Add(courseName);
        }
    }
}
