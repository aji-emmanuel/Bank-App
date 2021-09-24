using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;
using Models;

namespace SQLQueries
{
    public static class UserQueries
    {
        /// <summary>
        /// Adds a new registered User to User Database. Returns a bool if successful.
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>

        public static bool AddUser(UserModel user)
        {
            bool result = false;
            try
            {
                SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["conString"].ToString());
                SqlCommand cmd = new SqlCommand("Add_RegDetails", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                connection.Open();
                cmd.Parameters.AddWithValue("@User_Id", user.UserId);
                cmd.Parameters.AddWithValue("@Account_Name", user.AccountName);
                cmd.Parameters.AddWithValue("@Email", user.Email);
                cmd.Parameters.AddWithValue("@Password", user.PassWord);
                cmd.Parameters.AddWithValue("@Date_Created", DateTime.Now);
                cmd.ExecuteNonQuery();
                connection.Close();
                result = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return result;
        }

        /// <summary>
        /// Returns a User if the inputed password is contained in Customer SQL Database. Returns a User model
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns></returns>

        public static UserModel GetSignInDetails(string email, string password)
        {
            UserModel result = null;
            try
            {
                SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["conString"].ToString());
                SqlCommand cmd = new SqlCommand("Search_LoginDetails", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Password", password);

                connection.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    result = new UserModel(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString());
                }
                dr.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return result;
        }

        /// <summary>
        /// Checks for existing users with same email
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>

        public static string ValidateRegEmail(string email)
        {
            string result = null;
            try
            {
                SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["conString"].ToString());
                SqlCommand cmd = new SqlCommand("Validate_RegEmail", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@Email", email);

                connection.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    result = dr.GetString(2);
                }
                dr.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return result;
        }
    }
}
