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

namespace WPF_Evaluation_Project
{
    public partial class MainWindow : Window
    {
        private Login login;

        public MainWindow()
        {
            InitializeComponent();
            login = new Login();
        }

        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            string username = inputUsername.Text;
            string password = inputPassword.Password;

            if (login.CheckCredentials(username, password))
            {
                LoginSuccessWindow loginSuccess = new LoginSuccessWindow();
                loginSuccess.Show();
            }
            else
            {
                MessageBox.Show("Log-In Error: Invalid Username or Password");
            }
        }
    }
}
