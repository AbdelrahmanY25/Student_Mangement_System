using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seation_6
{
    internal class Students
    {
        public Students(string name = "Unknown", int id = 0, List<Courses>? courses = null)
        {
            _name = name;
            _id = id <= 0 ? 0 : id;
            _courses = courses;
        }

        private readonly string _name;
        private readonly int _id;
        private readonly List<Courses> _courses;
        public string Name => _name;    
        public int Id => _id;
        public List<Courses> Courses => _courses;

        public void DesplayDetails()
        {
            Console.Write($"Name: {_name}, Id: {_id}, Courses ");
            Console.Write("[");
            foreach(var course in _courses)
            {
                Console.Write($" {course.Name} ");
            }
            Console.Write("]");
            Console.WriteLine();
        }
    }
}
