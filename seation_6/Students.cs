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

        public Courses this[int course] 
        {
            get
            {
                return _courses[course];
            }
            set
            {
                _courses[course] = value;
            }
        }

        public Courses this[string inst] 
        {
            get 
            {
                var cours = _courses.Find((c) => c.Instructor == inst);
                return cours != null ? cours : null;
            } 
            set
            {
                for (int i = 0; i < _courses.Count; i++) 
                {
                    if (_courses[i].Instructor == inst)
                    {
                        _courses[i] = value;
                        return;
                    }
                }
            }
        } 

        private readonly string _name;
        private readonly int _id;
        private readonly List<Courses> _courses = new List<Courses>();
        public string Name => _name;    
        public int Id => _id;
        public List<Courses> Courses => _courses;
        public string DesplayDetails()
        {
            var details = $"Name: {_name}, Id: {_id}, Courses [";
            foreach (var course in _courses)
            {
                details += $" {course.Name} ";
            }
            details += "]";
            return details;
        }

    }
}
