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
        public School(List<Students>? students = null, List<Courses>? courses = null)
        {
            _students = students;
            _courses = courses;
        }

        private readonly List<Students>? _students;
        private readonly List<Courses>? _courses; 
        public List<Students>? Students => _students;
        public List<Courses>? Courses => _courses;

        public void DisplayAllStudensts()
        {
            foreach (var student in _students)
            {
                student.DesplayDetails();
            };
        }      
        public void DisplayAllCourses()
        {
            foreach (var course in _courses)
            {
                course.DesplayDetails();
            };
        }

        public void AddStudent(Students student)
        {
            _students.Add(student);
            Console.WriteLine($"Student {student.Name} Added");
        }
        public void AddCourse(Courses course)
        {
            _courses.Add(course);
            Console.WriteLine($"Course {course.Name} Added");
        }

        public void EnrollStudentInCourse(int StudentId, Courses courseName)
        {
            Students? student = _students.Find((e) => e.Id == StudentId);

            //Student student = new();
            //foreach (var e in _students)
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
