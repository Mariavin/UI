using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplicationServer.DataAccessLayer.Domains
{
    public class User
    {
        public User(int id, string login, string passwod, int role)
        {
            Id = id;
            Login = login;
            Passwod = passwod;
            Role = role;
        }
        public User()
        {

        }

        public int Id;
        public string Login;
        public int Role;
        public string Passwod;
    }
}
