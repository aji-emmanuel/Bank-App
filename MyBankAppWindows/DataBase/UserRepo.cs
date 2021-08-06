using Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    public class UserRepo
    {
        public static List<UserModel> UserData { get; set; } = new List<UserModel>();
        static readonly string FileLocation = "user-details.txt";

        /// <summary>
        /// Saves new User details to User Repository
        /// </summary>
        /// <param name="user"></param>

        public void AddUser(string accountName, string email, string passWord)
        {
            UserModel user = new UserModel(accountName, email, passWord);
            UserData.Add(user);
            SaveUsers(user);
        }
       
        /// <summary>
        /// Copies User details from file Database to User Repo list
        /// </summary>

        public static void LoadUsers()
        {
                                                 // Check if file exists and read the content if it exists
            if (File.Exists(FileLocation))
            {
                string[] lines = File.ReadAllLines(FileLocation);
                
                foreach (string line in lines)
                {
                    string accountName = line.Substring(0).Split(',')[0];
                    string email = line.Substring(0).Split(',')[1];
                    string password = line.Substring(0).Split(',')[2];

                    UserModel user = new UserModel(accountName, email, password);
                    UserData.Add(user);
                }
            }
        }

        /*public UserRepo()
        {
            LoadUsers();
        }*/

        /// <summary>
        /// Saves the details of a registered user to file DataBase
        /// </summary>
        /// <param name="user"></param>

        void SaveUsers(UserModel user)
        {
            List<string> allUsers = new List<string>
            {
                $"{user.AccountName},{user.Email},{user.PassWord}"
            };
            File.AppendAllLines(FileLocation, allUsers);
        }

        /// <summary>
        /// Iterates through User Repository to verify login email and password.
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns></returns>

        public UserModel GetLoginDetails(string email, string password)
        {
            return UserData.FirstOrDefault(user => user.PassWord == password && user.Email == email);
        }

        /// <summary>
        /// Verirfies if User email exists
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>

        public bool GetUserEmail(string email)
        {
            if (UserData.FirstOrDefault(user => user.Email == email) == null)
            {
                return true;
            }
            else
                return false;
        }
    }
}
