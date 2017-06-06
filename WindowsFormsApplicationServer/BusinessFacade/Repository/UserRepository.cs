using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplicationServer.BusinessFacade.Helpers;
using WindowsFormsApplicationServer.DataAccessLayer.Domains;


namespace WpfApplication1.BusinessFacade.Repository
{
    class UserRepository
    {

        Connection connection = new Connection();
        private static SqlConnection con;

        public UserRepository()
        {
            con = connection.Open();
        }

        public List<User> GetListOfUsers()
        {
            string sql = "SELECT * FROM [Users]";
            return GetUsersByRequest(sql);

        }
        private static List<User> GetUsersByRequest(string sql)
        {
            if (con.State != ConnectionState.Open) con.Open();

            var cmd = new SqlCommand(sql, con);

            var students = new List<User>();

            var sqlDataReader = cmd.ExecuteReader();
            if (sqlDataReader.HasRows)
            {
                while (sqlDataReader.Read())
                {
                    var student = new WindowsFormsApplicationServer.DataAccessLayer.Domains.User(
                        Convert.ToInt32(sqlDataReader["id_user"].ToString()),
                        sqlDataReader["Login"].ToString(),
                        sqlDataReader["Passwod"].ToString(),
                        Convert.ToInt32(sqlDataReader["Role"].ToString()));
                    students.Add(student);
                }
            }
            con.Close();
            return students;
        }
    }
}
