using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Resources;
using WPF_Evaluation_Project.Properties;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.IO;

namespace WPF_Evaluation_Project
{
    public class Login
    {
        private readonly string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "accounts.bin");

        // Constructors
        public Login() { }


        // Check Credentials
        // Arguements = Username , Password
        // Return = True = Input Username & Password match
        //          False = Input Username & Password do NOT match
        // Loads List of Accounts from accounts.bin file, checks input User/Pass against all Account objects in the List, returns True or False
        public bool CheckCredentials(string Username, string Password)
        {
            Account accountManager = new Account();

            List<Account> accounts = accountManager.LoadAccountBinFile();

            foreach (Account account in accounts)
            {
                if (Username == account.Username && Password == account.Password)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
