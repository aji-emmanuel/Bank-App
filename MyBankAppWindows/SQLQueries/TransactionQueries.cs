using Models;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SQLQueries 
{
    public static class TransactionQueries
    {
        /// <summary>
        /// Saves a transaction to the Sql Database
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>

        public static bool AddTransaction(TransactionModel user)
        {
            bool result = false;
            try
            {
                SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["conString"].ToString());
                SqlCommand cmd = new SqlCommand("Add_Transactions", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                connection.Open();
                cmd.Parameters.AddWithValue("@Account_Number", user.AccountNumber);
                cmd.Parameters.AddWithValue("@Transaction_Date", DateTime.Now);
                cmd.Parameters.AddWithValue("@Transaction_Description", user.TransactionDescription);
                cmd.Parameters.AddWithValue("@Transaction_Amount", user.Amount);
                cmd.Parameters.AddWithValue("@Account_Balance", user.AccountBalance);
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
                SqlCommand cmd = new SqlCommand("Get_AccountType", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@Account_Number", accountNumber);

                connection.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    result = new Account(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), Convert.ToDecimal(dr[4]));
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
        /// Updates the Account balance in Sql database table
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>

        public static bool UpdateAccountBalance(TransactionModel user)
        {
            bool result = false;
            try
            {
                SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["conString"].ToString());
                SqlCommand cmd = new SqlCommand("Update_AccountBal", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                connection.Open();
                cmd.Parameters.AddWithValue("@Account_Number", user.AccountNumber);
                cmd.Parameters.AddWithValue("@Account_Balance", user.AccountBalance);
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
        /// Fetches the transactions of a particular account from the Transaction table in Sql database
        /// </summary>
        /// <param name="accountNumber"></param>
        /// <returns></returns>

        public static DataTable ShowTransactions(string accountNumber)
        {
            DataTable dataTable = new DataTable();
            try
            {
                SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["conString"].ToString());
                SqlCommand cmd = new SqlCommand("Print_Transactions", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                connection.Open();
                cmd.Parameters.AddWithValue("@Account_Number", accountNumber);
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                adapt.Fill(dataTable);
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dataTable;
        }
    }
}
