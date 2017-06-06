using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplicationServer.DataAccessLayer.Domains
{
    class Trenirovka
    {
        public Trenirovka(int id_training, int id_trener, int id_programm, DateTime Time, string Name)
        {
            Id_training = id_training;
            Id_trener = id_trener;
            Id_programm = id_programm;
            time = Time;
            name = Name;
        }

        public int Id_training;
        public int Id_trener;
        public int Id_programm;
        public DateTime time;
        public string name;
    }
}
