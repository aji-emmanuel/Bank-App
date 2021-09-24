namespace Models
{
    /// <summary>
    /// Contains User's personal details
    /// </summary>

    public class UserModel
    {
        public string UserId { get; set; } 
        public string AccountName { get; set; }
        public string Email { get; set; }
        public string PassWord { get; set; }


        public UserModel(string userId, string accountName, string email, string passWord)
        {
            UserId = userId;
            AccountName = accountName;
            Email = email;
            PassWord = passWord;
        }
    }
}
