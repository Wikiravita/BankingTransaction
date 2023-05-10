using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace BankingTransaction.Models
{
    [Table("Transaction")]
    public class Transaction
    {
        [Key]
        public int transId { get; set; }
        public TransType transType { get; set; } // use enum 
        public string transDate { get; set; } = string.Empty;
        public float transAmount { get; set; }

    }

    public enum TransType
    {
        Diposit,
        Withdrawal,
        Transfer
    }

}
