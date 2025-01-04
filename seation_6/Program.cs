namespace seation_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("======================== Course Class ============================\n");

            #region ListOfCourse
                Course course1 = Course.AddCourse(".Net C#", "Mohammed Nabih");
                Course course2 = Course.AddCourse("Basics With C++", "Hossam Ibrahim");
                Course course3 = Course.AddCourse("Laravel PHP", "Mostafa Mohsen");

                Console.WriteLine(Course.DesplayDetails(course1));
                Console.WriteLine(Course.DesplayDetails(course2));
                Console.WriteLine(Course.DesplayDetails(course3));
            #endregion
            Console.WriteLine("\n======================== Students Class ============================\n");

            #region ListOfStudents
                Student students1 = Student.AddStudent("Abdelrahman", new() { course1, course2 });
                                 
                Student students2 = Student.AddStudent("Mohammed Hassanien", new() { course1 });
                                 
                Student students3 = Student.AddStudent("Abdo El saied", new() { course1, course2, course3 });

                Console.WriteLine(Student.DesplayDetails(students1));
                Console.WriteLine(Student.DesplayDetails(students2));
                Console.WriteLine(Student.DesplayDetails(students3));

            Console.WriteLine("\n======================== Student's Course With Indexer ============================\n");

            Console.WriteLine(Course.DesplayDetails(course1[1]));

            #endregion

            Console.WriteLine("\n============ Add Students To School =============\n");
            School.StudentAdded += School_StudentAdded;
            School.AddStudent(students1);
            School.AddStudent(students2);
            School.AddStudent(students3);

            Console.WriteLine("\n============ Add Course To School =============\n");
            School.CourseAdded += School_CourseAdded;
            School.AddCourse(course1);
            School.AddCourse(course2);
            School.AddCourse(course3);

            Console.WriteLine("\n============ All Students =============\n");
            Console.WriteLine(Student.DisplayAllStudensts());

            Console.WriteLine("\n============ All Course =============\n");
            Console.WriteLine(Course.DisplayAllCourse());

            Console.WriteLine("\n============ Update Course =============");
            School.EnrollStudentInCourse(2, course3);
            Console.WriteLine();
            Console.WriteLine(Student.DisplayAllStudensts());

            Console.ReadKey();
        }

        private static void School_CourseAdded(Course course)
        {
            Console.WriteLine($"Course {course.Name} Added");
        }

        private static void School_StudentAdded(Student student)
        {
            Console.WriteLine($"Student {student.Name} Added");
        }
    }
}