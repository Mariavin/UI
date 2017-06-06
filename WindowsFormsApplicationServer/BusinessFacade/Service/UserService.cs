using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplicationServer.DataAccessLayer.Domains;

namespace WindowsFormsApplicationServer.BusinessFacade.Service
{
    public class UserService
    {
        private static SqlConnection Con;

        public UserService(SqlConnection con)
        {
            Con = con;
        }

        public IEnumerable<User> GetUsers()
        {
            Con.Open();

            IEnumerable<User> u = new LinkedList<User>();
            return u;
        }
    }
}
