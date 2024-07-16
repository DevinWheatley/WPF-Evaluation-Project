using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Resources;
using WPF_Evaluation_Project.Properties;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WPF_Evaluation_Project.code
{
    public class Login
    {
        // Constructors
        public Login() { }
        
        public bool CheckCredentials(string Username, string Password)
        {
            string text = Resources.userpass;
            string[] lines = text.Split('\n');
            for (int i = 1; i < lines.Length - 1; i++) // Start on the second line, ignoring "Username:Password"
            {
                string line = lines[i];

                string[] parts = line.Split(":");
                string username = parts[0];
                string password = parts[1];

                if (Username == username && Password == password)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
