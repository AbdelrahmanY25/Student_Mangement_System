using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seation_6
{
    internal class Courses
    {
        public Courses(string name = "None", string instructor = "Unknown")
        {
            Name = name;
            Instructor = instructor;
        }

       public string Name {  get; set; }
       public string Instructor { get; set; }

        public void DesplayDetails()
        {
            Console.WriteLine($"Name: {Name}, Instructor: {Instructor}");
        }
    }
}
