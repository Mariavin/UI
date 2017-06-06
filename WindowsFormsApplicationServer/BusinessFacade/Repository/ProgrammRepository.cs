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
    class ProgrammRepository
    {
        Connection connection = new Connection();
        private static SqlConnection con;

        public ProgrammRepository()
        {
            con = connection.Open();
        }
        public void AddProgramm(Programm programm)
        {
            if (con.State != ConnectionState.Open) con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO [Semester].[dbo].[Programms] (Name,id_course,Price,id_trener,Describe) VALUES(@Name,@id_course,@Price,@id_trener,@Describe)", con);
            cmd.Parameters.AddWithValue("@Name", programm.Name);
            cmd.Parameters.AddWithValue("@id_course", programm.id_course);
            cmd.Parameters.AddWithValue("@Price", programm.Price);
            cmd.Parameters.AddWithValue("@id_trener", programm.id_trener);
            cmd.Parameters.AddWithValue("@Describe", programm.Describe);
            var result = cmd.ExecuteNonQuery();
            con.Close();
        }

        public List<Programm> GetListOfProgramm()
        {
            string sql = "SELECT * FROM [Programms]";
            return GetProgrammByRequest(sql);
        }

        private static List<Programm> GetProgrammByRequest(string sql)
        {
            if (con.State != ConnectionState.Open) con.Open();

            var cmd = new SqlCommand(sql, con);

            var programms = new List<Programm>();

            var sqlDataReader = cmd.ExecuteReader();
            if (sqlDataReader.HasRows)
            {
                while (sqlDataReader.Read())
                {
                    var programm = new Programm(
                        Convert.ToInt32(sqlDataReader["id_programm"].ToString()),
                        sqlDataReader["Name"].ToString(),
                        Convert.ToInt32(sqlDataReader["id_course"].ToString()),
                        Convert.ToDecimal(sqlDataReader["Price"].ToString()),
                        Convert.ToInt32(sqlDataReader["id_trener"].ToString()),
                        sqlDataReader["Describe"].ToString());
                    programms.Add(programm);
                }
            }
            con.Close();
            return programms;
        }

        public Programm GetProgrammByName(string name)
        {
            string sql = "SELECT * FROM [Programms] where Name = '" + name + "'";
            if (con.State != ConnectionState.Open) con.Open();
            var cmd = new SqlCommand(sql, con);
            Programm programm = null;
            var sqlDataReader = cmd.ExecuteReader();
            if (sqlDataReader.HasRows && sqlDataReader.Read())
            {
                programm = new Programm(
                        Convert.ToInt32(sqlDataReader["id_programm"].ToString()),
                        sqlDataReader["Name"].ToString(),
                        Convert.ToInt32(sqlDataReader["id_course"].ToString()),
                        Convert.ToDecimal(sqlDataReader["Price"].ToString()),
                        Convert.ToInt32(sqlDataReader["id_trener"].ToString()),
                        sqlDataReader["Describe"].ToString());
            }
            con.Close();
            return programm;
        }

    }
}
