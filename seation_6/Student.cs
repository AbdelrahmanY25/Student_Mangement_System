namespace seation_6
{
    internal class Student
    {
        private static int _numberOfStudents = 1;
        private readonly string _name;
        private readonly int _id;
        private readonly List<Course> _courses = new List<Course>();
        private static List<Student> _students = new List<Student>();
        public int NumberOfStudents => _numberOfStudents;
        public string Name => _name;
        public int Id => _id;
        public List<Course> Courses => _courses;
        public List<Student> Students => _students;
        private Student(int id, string name, List<Course> courses)
        {
            _id = id;
            _name = name;
            _courses = courses;
        }

        public static Student AddStudent(string name, List<Course> courses)
        {
            var student = new Student(_numberOfStudents, name, courses);
            _students.Add(student);
            _numberOfStudents++;
            return student;
        }        

        public static string DesplayDetails(Student student)
        {
            var details = $"Student_Id: {student.Id}, Name: {student.Name}, Courses [";
            foreach (var course in student.Courses)
            {
                details += $" {course.Name} ";
            }
            details += "]";
            return details;
        }

        public static string DisplayAllStudensts()
        {
            var St = "";
            foreach (var student in _students)
            {
                St += DesplayDetails(student) + "\n";
            };
            return St;
        }
    }
}
