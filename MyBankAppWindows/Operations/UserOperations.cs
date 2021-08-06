using Models;
using SQLQueries;

namespace Operations
{
    public class UserOperations
    {
        /// <summary>
        /// Collects and saves details of a new user 
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="accountName"></param>
        /// <param name="email"></param>
        /// <param name="passWord"></param>
        /// <returns></returns>

        public bool UserRegistration(string userId, string accountName, string email, string passWord)
        {
            UserModel userData = new UserModel(userId, accountName, email, passWord);

            bool success = UserQueries.AddUser(userData);      // SQL DataBase
            if (success)
                return true;
            else
                return false;
        }
    }
}
