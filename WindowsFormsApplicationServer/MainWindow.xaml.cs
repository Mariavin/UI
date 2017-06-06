using System.Windows;
using WindowsFormsApplicationServer.DataAccessLayer.Enums;
using WindowsFormsApplicationServer.DataAccessLayer.UI.Admin;
using WpfApplication1.BusinessFacade.Services;
using WpfApplication1.UI;

namespace WpfApplication1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        AvtorizationControl avtorizationControl;
        public MainWindow()
        {
            avtorizationControl = new AvtorizationControl();
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var login = textbox2.Text;
            var pass = textbox1.Text;
            var user = avtorizationControl.Avtorize(login, pass);

            if (user.Role == (int)Role.trener)
            {
                Trener_Panel winTool = new Trener_Panel(user);
                winTool.Owner = this;
                winTool.Show();
                mainwindow.Visibility = Visibility.Hidden;

            }
            else if (user.Role == (int)Role.admin)
            {
                AdminPanel winTool = new AdminPanel(user);
                winTool.Owner = this;
                winTool.Show();
                mainwindow.Visibility = Visibility.Hidden;
            }
            else if (user.Role == (int)Role.client)
            {
                ClientPanel winTool = new ClientPanel(user);
                winTool.Owner = this;
                winTool.Show();
                mainwindow.Visibility = Visibility.Hidden;
            }
            else
            {
                label1.Visibility = Visibility.Visible;
                label1.Content = "ошибка";
            }
        }
    }
}
