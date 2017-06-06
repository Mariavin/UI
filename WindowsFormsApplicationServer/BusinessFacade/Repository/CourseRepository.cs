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
    public class CourseRepository
    {
        Connection connection = new Connection();
        private static SqlConnection con;

        public CourseRepository()
        {
            con = connection.Open();
        }

        public List<WindowsFormsApplicationServer.DataAccessLayer.Domains.Course> GetListOfCourses()
        {
            string sql = "SELECT * FROM [Course]";
            return GetCoursesByRequest(sql);
        }

        private static List<Course> GetCoursesByRequest(string sql)
        {
            if (con.State != ConnectionState.Open) con.Open();

            var cmd = new SqlCommand(sql, con);

            var courses = new List<Course>();

            var sqlDataReader = cmd.ExecuteReader();
            if (sqlDataReader.HasRows)
            {
                while (sqlDataReader.Read())
                {
                    var course = new Course(
                        Convert.ToInt32(sqlDataReader["id_course"].ToString()),
                        sqlDataReader["Name"].ToString(),
                        sqlDataReader["Describe"].ToString());
                    courses.Add(course);
                }
            }
            con.Close();
            return courses;
        }



        public Course GetCourseByName(string name)
        {
            string sql = "SELECT * FROM [Course] where Name = '" + name + "'";
            if (con.State != ConnectionState.Open) con.Open();
            var cmd = new SqlCommand(sql, con);
            Course course = null;
            var sqlDataReader = cmd.ExecuteReader();
            if (sqlDataReader.HasRows && sqlDataReader.Read())
            {
                course = new Course(
                    Convert.ToInt32(sqlDataReader["id_course"].ToString()),
                    sqlDataReader["Name"].ToString(),
                    sqlDataReader["Describe"].ToString());
            }
            con.Close();
            return course;
        }
    }
}
