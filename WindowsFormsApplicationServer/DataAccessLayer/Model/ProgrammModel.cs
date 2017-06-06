using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplicationServer.DataAccessLayer.Domains;

namespace WindowsFormsApplicationServer.DataAccessLayer.Model
{
    class ProgrammModel
    {
        public ProgrammModel(List<Programm> programm)
        {
            Programm = programm;
        }
        public List<Programm> Programm;
        public string test;
    }
}
