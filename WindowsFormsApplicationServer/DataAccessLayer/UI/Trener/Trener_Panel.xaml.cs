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
using WindowsFormsApplicationServer.DataAccessLayer.Domains;

namespace WpfApplication1.UI
{
    /// <summary>
    /// Логика взаимодействия для Trener_Panel.xaml
    /// </summary>
    public partial class Trener_Panel : Window
    {
        User user;
        public Trener_Panel(User user2)
        {
            user = user2;
            InitializeComponent();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            //Создание нового окна.
            AddingProgram winTool = new AddingProgram(user);
            // Назначение текущего окна владельцем.
            winTool.Owner = this;
            // Отображение окна, принадлежащего окну-владельцу.
            winTool.Show();

        }

    }
}