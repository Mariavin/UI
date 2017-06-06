using System;
using System.Windows;
using WindowsFormsApplicationServer.DataAccessLayer.Domains;
using WindowsFormsApplicationServer.DataAccessLayer.Model;
using WpfApplication1.BusinessFacade.Services;
using WpfApplication1.UI.Trener;

namespace WpfApplication1.UI
{
    /// <summary>
    /// Логика взаимодействия для AddingProgram.xaml
    /// </summary>
    public partial class AddingProgram : Window
    {
        CourseService courseService = new CourseService();
        ProgrammService ProgrammService = new ProgrammService();
        User trener;
        public AddingProgram(User user)
        {
            InitializeComponent();
            trener = user;
            var courses = new CourseModel(courseService.GetListOfCourse());

            foreach (var c in courses.Course)
            {
                comboBox.Items.Add(c.Name);
            }
        }
        private bool ExistStringOnlyLetter(string s)
        {
            bool flag = true;
            foreach (var c in s)
            {
                if (!Char.IsLetter(c))
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        private bool ExistStringOnlyNumber(string s)
        {
            bool flag = true;
            foreach (var c in s)
            {
                if (!Char.IsDigit(c))
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (ExistStringOnlyNumber(textBox2.Text) && !string.IsNullOrEmpty(textBox.Text) && !string.IsNullOrEmpty(textBox3.Text))
            {
                int id_course = courseService.GetCourseByName(comboBox.SelectedValue.ToString()).Id_course;

                var program = new Programm
                {
                    id_course = id_course,
                    Name = textBox.Text,
                    Price = Convert.ToDecimal(textBox2.Text),
                    Describe = textBox3.Text,
                    id_trener = trener.Id
                };
                ProgrammService.AddProgramm(program);
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            CreateProgram winTool = new CreateProgram(trener);
            winTool.Owner = this;
            winTool.Show();
            addd.Visibility = Visibility.Hidden;
        }
    }
}

