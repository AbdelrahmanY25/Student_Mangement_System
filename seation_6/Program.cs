namespace seation_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("======================== Courses Class ============================\n");

            #region ListOfCourses
                Courses course1 = new Courses("C#","Hassan");
                Courses course2 = new Courses("Java", "Ibrahim");
                Courses course3 = new Courses("PHP", "Mohamed");

                Console.WriteLine(course1.DesplayDetails());
                Console.WriteLine(course2.DesplayDetails());
                Console.WriteLine(course3.DesplayDetails());
            #endregion
            Console.WriteLine("\n======================== Students Class ============================\n");

            #region ListOfStudents
                Students students1 = new Students("Abdelrahman", 4200614, new() { course1, course2, course3 });

                Students students2 = new Students("Momen", 435126, new() { course1, course2 });

                Students students3 = new Students("Ali", 668852, new() { course2 });

                Console.WriteLine(students1.DesplayDetails());
                Console.WriteLine(students2.DesplayDetails());
                Console.WriteLine(students3.DesplayDetails());

                Console.WriteLine("\n======================== Student's Courses With Indexer Class ============================\n");

                Console.WriteLine(students1[1].DesplayDetails());
                students1[1] = new Courses("C++", "Abdelrahman");
                Console.WriteLine(students1[1].DesplayDetails());

                Console.WriteLine(students3["Ibrahim"].DesplayDetails());
                students3["Ibrahim"] = new Courses("HTML", "Osama");
                Console.WriteLine(students3["Osama"].DesplayDetails());
            #endregion
            Console.WriteLine("\n======================== School Class ============================");

            School school = new School(new() { students1, students2, students3 }, new() { course1, course2, course3 });

            Console.WriteLine("============ Add Students =============\n");
            Console.WriteLine(school.AddStudent(new("Boda", 4200420, new() { course1 })));

            Console.WriteLine("\n============ Add Courses =============\n");
            Console.WriteLine(school.AddCourse(new("JavaScript", "Reda Islam")));

            Console.WriteLine("\n============ All Students =============\n");
            Console.WriteLine(school.DisplayAllStudensts());

            Console.WriteLine("\n============ All Courses =============\n");
            Console.WriteLine(school.DisplayAllCourses());

            Console.WriteLine("\n============ Update Courses =============");
            school.EnrollStudentInCourse(4200420, new("JavaScript", "Reda Islam"));
            Console.WriteLine();
            Console.WriteLine(school.DisplayAllStudensts());

            Console.ReadKey();
        }
    }
}
