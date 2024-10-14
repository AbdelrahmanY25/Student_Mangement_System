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
        public delegate void AddStudentsHandler(Students student);
        public delegate void AddCoursesHandler(Courses course);

        public event AddStudentsHandler? StudentAdded;
        public event AddCoursesHandler? CoursesAdded;
        public Students this[int s]
        {
            get
            {
                return _students[s];
            }
        }

        public Students this[string name]
        {
            get
            {
                var res = _students.Find((s) => s.Name == name);
                return res != null ? res : null;
            }
        }
        public School(List<Students>? students = null, List<Courses>? courses = null)
        {
            _students = students;
            _courses = courses;
        }

        private readonly List<Students>? _students;
        private readonly List<Courses>? _courses; 
        public List<Students>? Students => _students;
        public List<Courses>? Courses => _courses;

        public string DisplayAllStudensts()
        {
            var students = "";
            foreach (var student in _students)
            {
                students += student.DesplayDetails() + "\n";
            };
            return students;
        }      
        public string DisplayAllCourses()
        {
            var courses = "";
            foreach (var course in _courses)
            {
                courses += course.DesplayDetails() + "\n";
            };
            return courses;
        }

        public bool AddStudent(Students student)
        {
            _students.Add(student);
            StudentAdded?.Invoke(student);
            return true;
        }
        public bool AddCourse(Courses course)
        {
            _courses.Add(course);
            CoursesAdded(course);
            return true;
        }
        public void EnrollStudentInCourse(int StudentId, Courses courseName)
        {
            Students? student = _students.Find((e) => e.Id == StudentId);
            student.Courses.Add(courseName);
        }
    }
}
