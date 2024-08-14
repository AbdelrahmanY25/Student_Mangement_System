namespace seation_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("======================== Courses Class ============================\n");

            #region ListOfCourses
                Courses course1 = new Courses() { Name = "C#", Instructor = "Hassan" };
                Courses course2 = new Courses() { Name = "Java", Instructor = "Ibrahim" };
                Courses course3 = new Courses() { Name = "PHP", Instructor = "Mohamed" };

                course1.DesplayDetails();
                course2.DesplayDetails();
                course3.DesplayDetails();
            #endregion
            Console.WriteLine("\n======================== Students Class ============================\n");

            #region ListOfStudents
                Students students1 = new()
                {
                    Name = "Abdelrahman",
                    Id = 4200614,
                    Courses = { course1, course2, course3 }
                };

                Students students2 = new()
                {
                    Name = "Momen",
                    Id = 435126,
                    Courses = { course1, course3 }
                };

                Students students3 = new()
                {
                    Name = "Ali",
                    Id = 668852,
                    Courses = { course2 }
                };

                students1.DesplayDetails();
                students2.DesplayDetails();
                students3.DesplayDetails();
            #endregion
            Console.WriteLine("\n======================== School Class ============================");

            School school = new()
            {
                Courses = { course1, course2, course3 },
                Students = { students1, students2, students3 }
            };

            Console.WriteLine("============ Add Students =============\n");
            school.AddStudent(new()
            {
                Name = "Boda",
                Id = 4200420,
                Courses = new List<Courses>() { course1 }
            });

            Console.WriteLine("\n============ Add Courses =============\n");
            school.AddCourse(new()
            {
                Name = "JavaScript",
                Instructor = "Reda Islam"
            });

            Console.WriteLine("\n============ All Students =============\n");
            school.DisplayAllStudensts();

            Console.WriteLine("\n============ All Courses =============\n");
            school.DisplayAllCourses();

            Console.WriteLine("\n============ Update Courses =============");
            school.EnrollStudentInCourse(4200420, course3);
            Console.WriteLine();
            school.DisplayAllStudensts();
        }
    }
}
