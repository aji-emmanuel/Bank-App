using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operations
{
    public class UserOperations
    {
        readonly Users users = new Users();
        public UserModel LogUser { get; set; }

        /// <summary>
        /// Retrieves User details during Registration and saves them to User Repository
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="email"></param>
        /// <param name="passWord"></param>
        /// <returns></returns>

        public UserModel UserRegistration(string firstName, string lastName, string email, string passWord)
        {
            UserModel userData = new UserModel(firstName, lastName, email, passWord);
            users.AddUser(userData);
            return userData;
        }

        /// <summary>
        /// Verifies if the inputed password is contained in User Repository.
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>

        public bool UserLogin(string email, string password)
        {
            UserModel user = users.GetLoginDetails(email, password);
            if (user == null)
            {
                Console.Clear();
                UserMessages.IncorrectPassword();
                return false;
            }
            else
                return true;
        }
    }
}

