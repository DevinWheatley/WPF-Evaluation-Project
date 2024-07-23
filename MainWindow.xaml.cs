using System.Security.Principal;
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
            Account account = new Account();
            account.CheckAccountBinExist(); // Creates accounts.bin if it doesn't exit
        }


        // LogIn Button
        // Opens LoginSuccessWindow if CheckCredentials returns True
        // Shows Error Message if CheckCredentials returns False
        private void LogIn(object sender, RoutedEventArgs e)
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

        // ShowCreateAccount Button
        // Opens CreateAccount Window
        private void ShowCreateAccount(object sender, RoutedEventArgs e)
        {
            CreateAccount createAccount = new CreateAccount();
            createAccount.Show();
        }
    }
}
