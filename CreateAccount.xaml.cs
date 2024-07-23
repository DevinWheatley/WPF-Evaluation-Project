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

namespace WPF_Evaluation_Project
{
    public partial class CreateAccount : Window
    {
        public CreateAccount()
        {
            InitializeComponent();
        }


        // CreateNewAccount Button
        // Creates an Account object using CreateAccount Window input fields
        // Uses account.AddAccount to add the created Account object into the accounts.bin file
        // Shows success message at the top of the screen
        private void CreateNewAccount(object sender, RoutedEventArgs e)
        {
            string username = inputUsername.Text;
            string password = inputPassword.Password;
            string name = inputName.Text;
            string email = inputEmail.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) ||
                string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email))
            {
                DisplayTextBlock.Text = "Error : Invalid Input";
                return;
            }

            Account account = new Account(username, password, name, email);

            // Checks username against accounts.bin usernames, error message if it's already in use
            if (account.CheckUsername(username))
            {
                DisplayTextBlock.Text = $"Username: {username} Already In Use";
                return;
            }

            account.AddAccount(account); // Adds account to the accounts.bin file
            DisplayTextBlock.Text = $"Account {username} Created";
        }
    }
}
