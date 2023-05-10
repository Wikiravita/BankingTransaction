using System.ComponentModel.DataAnnotations;

namespace BankingTransaction
{
    public class UserRegDto
    {
        public int customerId { get; set; }
        public string customerName { get; set; } = string.Empty;
        public string customerEmail { get; set; } = string.Empty;
        public string customerPhone { get; set; } = string.Empty;
        public string customerNIC { get; set; } = string.Empty;
        public string DOB { get; set; } = string.Empty;
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; }
        //public byte[] PasswordHash { get; set; }
        //public byte[] PaswordSalt { get; set; }
    }
}
