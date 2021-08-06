using Models;
using MyBankAppWindows;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SQLQueries
{
    public static class AccountQueries
    {
        /// <summary>
        /// Adds a created Account of a user to Sql Database
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>

        public static bool AddUserAccount(Account user)
        {
            bool result = false;
            try
            {
                SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["conString"].ToString());
                SqlCommand cmd = new SqlCommand("Add_AcctDetails", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                connection.Open();
                cmd.Parameters.AddWithValue("@User_Id", SignInForm.LoggedUserId);
                cmd.Parameters.AddWithValue("@Account_Id", user.AccountId);
                cmd.Parameters.AddWithValue("@Account_Number", user.AccountNumber);
                cmd.Parameters.AddWithValue("@Account_Type", user.AccountType);
                cmd.Parameters.AddWithValue("@Account_Balance", user.AccountBalance);
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
        /// Gets the details of a specific Account using the Account Number.
        /// </summary>
        /// <param name="accountNumber"></param>
        /// <returns></returns>

        public static Account GetAccountDetails(string accountNumber)
        {
            Account result = null;
            try
            {
                SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["conString"].ToString());
                SqlCommand cmd= new SqlCommand("Get_AccountType", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@Account_Number", accountNumber);

                connection.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    result = new Account(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), Convert.ToDecimal(dr[4].ToString()));
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
        /// Gets all Accounts associated to a logged in User using the User Id
        /// </summary>
        /// <returns></returns>

        public static List<string> GetUserAccounts()
        {
            List<string> ComboAccounts = new List<string>();

            try
            {
                SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["conString"].ToString());
                SqlCommand cmd = new SqlCommand("Search_AcctByUserId", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@User_Id", SignInForm.LoggedUserId);

                connection.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ComboAccounts.Add(dr["Account_Number"].ToString());
                }
                dr.Close();
                connection.Close();
                return ComboAccounts;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        /// <summary>
        /// Generates Random Account numbers
        /// </summary>
        /// <returns></returns>

        public static string GenAccountNo()
        {
            var random = new Random();
            string accountNo = string.Empty;
            for (int i = 0; i < 10; i++)
                accountNo = String.Concat(accountNo, random.Next(10).ToString());
            return accountNo;
        }
    }
}
