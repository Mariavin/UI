using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplicationServer.DataAccessLayer.Domains;
using WpfApplication1.BusinessFacade.Repository;

namespace WpfApplication1.BusinessFacade.Services
{
    public class ProgrammService
    {
        ProgrammRepository programmRepository = new ProgrammRepository();

        public void AddProgramm(Programm programm)
        {
            programmRepository.AddProgramm(programm);
        }

        public List<Programm> GetListOfProgramm()
        {
            List<Programm> Programm = programmRepository.GetListOfProgramm();

            return Programm;
        }

        public Programm GetProgrammByName(string name)
        {
            Programm Programm = programmRepository.GetProgrammByName(name);
            return Programm;
        }
    }
}

