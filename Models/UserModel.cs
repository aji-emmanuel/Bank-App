using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    /// <summary>
    /// Contains User's personal details
    /// </summary>

    public class UserModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }

        /// <summary>
        /// Retrieves User's details during registration
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="email"></param>
        /// <param name="passWord"></param>

        public UserModel(string firstName, string lastName, string email, string passWord)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PassWord = passWord;
        }
    }
}
