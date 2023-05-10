using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankingTransaction.Models
{
    [Table("Accounts")]
    public class Account
    {
        [Key]
        public int Id { get; set; }
        public string accountName { get; set; }
        public AccountType accountType { get; set; } // This is will be enum to show if the account to be created "Savings" or "Current"......
        public DateTime createdDate { get; set; }
        public string AccountNumberGenerated { get; set; } // we shall generate account number here!
    }

    public enum AccountType
    {
        Savings,
        Current,
        Corporate,
        Goverment
    }

    //public Account()
    //{
    //    string AccountNumberGenerated = Convert.ToString();
    //}
}
