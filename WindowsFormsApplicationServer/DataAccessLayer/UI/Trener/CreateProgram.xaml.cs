using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WindowsFormsApplicationServer.BusinessFacade.Service;
using WindowsFormsApplicationServer.DataAccessLayer.Domains;
using WindowsFormsApplicationServer.DataAccessLayer.Model;
using WpfApplication1.BusinessFacade.Services;


namespace WpfApplication1.UI.Trener
{
    /// <summary>
    /// Логика взаимодействия для CreateProgram.xaml
    /// </summary>
    public partial class CreateProgram : Window
    {
        ProgrammService programmService = new ProgrammService();
        TrenService trenService = new TrenService();
        User trener;
        public CreateProgram(User user)
        {
            InitializeComponent();
            trener = user;
            var programms = new ProgrammModel(programmService.GetListOfProgramm());

            foreach (var c in programms.Programm)
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


        private void button_Click(object sender, RoutedEventArgs e)
        {

            //if (!string.IsNullOrEmpty(textBox.Text) && !string.IsNullOrEmpty(textBox.Text))
            //{
            //    int Id_programm = programmService.GetProgrammByName(comboBox.SelectedValue.ToString()).id_programm;

            //    var tren = new Trenirovka
            //    {
            //        Id_training = id_training;
            //        Id_trener = id_trener;
            //        Id_programm = id_programm;
            //        time = time;
            //        name = Name;
            //};
            //TrenService.AddTren(tren);
        }
    }
}
