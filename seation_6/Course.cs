namespace seation_6
{
    internal class Course
    {
        private static int _numberOfCoursies = 1;
        private readonly int _courseId;
        private readonly string _courseName;
        private readonly string _instructor;
        private static List<Course> _courses = new List<Course>();
        public string Name => _courseName;
        public string Instructor => _instructor;
        public int CourseId => _courseId;
        public int NumberOfCourses => _numberOfCoursies;
        public List<Course> Courses => _courses;
        private Course(int courseId, string course, string instructor)
        {
            _courseId = courseId;
            _courseName = course;
            _instructor = instructor;
        }
        
        public static Course AddCourse(string courseName , string instructor)
        {
            var course = new Course(_numberOfCoursies, courseName, instructor);
            _courses.Add(course);
            _numberOfCoursies++;
            return course;
        }

        public static string DesplayDetails(Course course)
        {
            return $"CourseId: {course._courseId}, Name: {course._courseName}, Instructor: {course.Instructor}";
        }

        public static string DisplayAllCourse()
        {
            var Cours = "";
            foreach (var course in _courses)
            {
                Cours += DesplayDetails(course) + "\n";
            };
            return Cours;
        }
        public Course this[int course]
        {
            get
            {
                return _courses[course];
            }           
        }
    }
}
