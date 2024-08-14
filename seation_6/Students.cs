using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seation_6
{
    internal class Students
    {
        public Students(string name = "Unknown", int id = 0, List<Courses> courses = null)
        {
            Name = name;
            Id = id;
            Courses = new List<Courses>();
        }

        public string Name { get; set; }
        public int Id { get; set; }
        public List<Courses> Courses { get; set; }

        public void DesplayDetails()
        {
            Console.Write($"Name: {Name}, Id: {Id}, Courses ");
            Console.Write("[");
            foreach(var course in Courses)
            {
                Console.Write($" {course.Name} ");
            }
            Console.Write("]");
            Console.WriteLine();

        }
    }
}
