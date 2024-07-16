using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPF_Evaluation_Project.code;

namespace WPF_Evaluation_Project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Login login;

        public MainWindow()
        {
            InitializeComponent();
            login = new Login();
        }

        private void ButtonClick(object sender, TextChangedEventArgs e)
        {
            string username = inputUsername.Text;
            string password = inputPassword.Password;

            if (login.CheckCredentials(username, password))
            {

            }

            
        }
    }
}