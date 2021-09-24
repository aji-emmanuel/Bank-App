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
        /// Saves a transaction to the Sql Database. Returns a bool if successful.
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
        /// Updates the Account balance in Sql database table. Returns a bool if successful
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>

        public static  bool UpdateAccountBalance(TransactionModel user)
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
