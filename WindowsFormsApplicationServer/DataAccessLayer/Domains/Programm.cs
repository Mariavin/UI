using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplicationServer.DataAccessLayer.Domains
{
    public class Programm
    {
        public Programm(int Id_programm, string name, int Id_course, decimal price, int Id_trener, string describe)
        {
            id_programm = Id_programm;
            Name = name;
            id_course = Id_course;
            Price = price;
            id_trener = Id_trener;
            Describe = describe;
        }

        public Programm()
        {

        }

        public int id_programm;
        public string Name;
        public int id_course;
        public decimal Price;
        public int id_trener;
        public string Describe;
    }
}
