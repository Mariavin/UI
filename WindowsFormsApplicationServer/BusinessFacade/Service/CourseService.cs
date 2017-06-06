using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplicationServer.DataAccessLayer.Domains;
using WpfApplication1.BusinessFacade.Repository;


namespace WpfApplication1.BusinessFacade.Services
{
    public class CourseService
    {
        CourseRepository courseRepository = new CourseRepository();
        public List<Course> GetListOfCourse()
        {
            List<Course> Courses = courseRepository.GetListOfCourses();

            return Courses;
        }

        public Course GetCourseByName(string name)
        {
            Course Courses = courseRepository.GetCourseByName(name);
            return Courses;
        }
    }
}
