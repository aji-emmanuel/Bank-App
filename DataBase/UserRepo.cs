using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    public class UserRepo
    {
        /// <summary>
        /// User Repository for saving of User's Details after Registration
        /// </summary>

        public List<UserModel> UserData { get; set; } = new List<UserModel>();

        /// <summary>
        /// Saves new User details to User Repository
        /// </summary>
        /// <param name="user"></param>

        public void AddUser(UserModel user)
        {
            UserData.Add(user);
        }

        /// <summary>
        /// Iterates through User Repository to verify password.
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>

        public UserModel GetLoginDetails(string email, string password)
        {
            return UserData.FirstOrDefault(user => user.PassWord == password && user.Email == email);
        }

    }
}
