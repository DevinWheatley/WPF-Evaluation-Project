using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace WPF_Evaluation_Project
{
    [Serializable]
    internal class Account
    {
        // Attributes
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

        private readonly string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "accounts.bin");

        // Constructors
        public Account() { } 
        public Account(string username, string password, string name, string email)
        {
            Username = username ?? throw new ArgumentNullException(nameof(username));
            Password = password ?? throw new ArgumentNullException(nameof(password));
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Email = email ?? throw new ArgumentNullException(nameof(email));
        }

        // Methods

        // Check for accounts.bin file
        public void CheckAccountBinExist()
        {
            if (!File.Exists(filePath))
            {
                using (FileStream fs = new FileStream(filePath, FileMode.Create)) // Create the file if it does not exist
                {
                }
            }
        }

        // Loads Account objects from the accounts.bin file
        // Returns a list of Account objects
        public List<Account> LoadAccountBinFile()
        {
            var accounts = new List<Account>();

            if (!File.Exists(filePath))
            {
                return accounts; // Return empty list if the bin file doesn't exist
            }

            using (BinaryReader reader = new BinaryReader(File.Open(filePath, FileMode.Open)))
            {
                while (reader.BaseStream.Position != reader.BaseStream.Length)
                {
                    var username = reader.ReadString();
                    var password = reader.ReadString();
                    var name = reader.ReadString();
                    var email = reader.ReadString();

                    accounts.Add(new Account(username, password, name, email));
                }
            }

            return accounts;
        }

        // Create Account
        // Arguments = Account object
        // Loads List of Accounts from accounts.bin, adds Argument Account into the List and then creates a new accounts.bin file using that List
        public void AddAccount(Account account)
        {
            List<Account> accounts = LoadAccountBinFile();
            accounts.Add(account);
            
            // Check that the username is unique
            

            using (BinaryWriter writer = new BinaryWriter(File.Open(filePath, FileMode.Create)))
            {
                foreach (Account acc in accounts)
                {
                    writer.Write(acc.Username);
                    writer.Write(acc.Password);
                    writer.Write(acc.Name);
                    writer.Write(acc.Email);
                }
            }
        }

        // Check Username Unique
        // Arguements = Username
        // Return = True = Input Username & accounts.bin Username match
        //          False = Input Username & accounts.bin do NOT match
        // Loads List of Accounts from accounts.bin file, checks input Username against List Account objects usernames to make sure it's unique
        public bool CheckUsername(string username)
        {
            List<Account> accounts = LoadAccountBinFile();

            foreach (Account account in accounts)
            {
                if (username == account.Username)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
