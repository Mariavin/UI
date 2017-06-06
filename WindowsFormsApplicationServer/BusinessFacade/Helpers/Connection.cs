using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplicationServer.BusinessFacade.Helpers
{
    public class Connection
    {
        private const string StrConnection = @"Data Source=LENOVO-PC\SQLEXPRESS;Initial Catalog=Semester;Integrated Security=True;";
        private static SqlConnection con = new SqlConnection(StrConnection);

        public Connection()
        {

        }

        public SqlConnection Open()
        {
            if (con.State != ConnectionState.Open)
                con.Open();
            return con;
        }

        public void Close()
        {

        }
    }
}
