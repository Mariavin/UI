using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplicationServer.DataAccessLayer.Domains
{
    public class Course
    {
        public Course(int id_course, string name, string describe)
        {
            Id_course = id_course;
            Name = name;
            Describe = describe;
        }
        public int Id_course;

        public string Name;

        public string Describe;
    }
}
