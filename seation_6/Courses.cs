using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seation_6
{
    internal class Courses
    {

        private readonly string _name;
        private readonly string _instructor;
        public string Name => _name;
        public string Instructor => Instructor;
        public Courses(string name = "None", string instructor = "Unknown")
        {
            _name = name;
            _instructor = instructor;
        }        
        public void DesplayDetails()
        {
            Console.WriteLine($"Name: {_name}, Instructor: {_instructor}");
        }
    }
}
