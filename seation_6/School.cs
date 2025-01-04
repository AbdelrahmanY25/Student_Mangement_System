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
        public delegate void AddStudentHandler(Student student);
        public delegate void AddCourseHandler(Course course);

        public static event AddStudentHandler? StudentAdded;
        public static event AddCourseHandler? CourseAdded;

        private static readonly List<Student>? _student = new List<Student>();
        private static readonly List<Course>? _course = new List<Course>();
        public List<Student>? Std => _student;
        public List<Course>? Coursies => _course;
        
        public static bool AddStudent(Student student)
        {
            _student.Add(student);
            StudentAdded?.Invoke(student);
            return true;
        }
        public static bool AddCourse(Course course)
        {
            _course.Add(course);
            CourseAdded(course);
            return true;
        }
        public static void EnrollStudentInCourse(int studentId, Course courseName)
        {
            Student student = _student.FirstOrDefault(s => s.Id == studentId);
            if (student == null)
                throw new Exception("Student not found");
            student.Courses.Add(courseName);
        }
    }
}
