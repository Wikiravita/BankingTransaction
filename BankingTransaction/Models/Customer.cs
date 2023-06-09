﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace BankingTransaction.Models
{
    [Table("Customer")]
    public class Customer
    {
        [Key]
        public int customerId { get; set; }
        public string customerName { get; set; } = string.Empty;
        [Required]
        public string customerEmail { get; set; } = string.Empty;
        public string customerPhone { get; set; } = string.Empty;
        [Required]
        public string customerNIC { get; set; } = string.Empty;
        [Required]
        public string DOB { get; set; } = string.Empty;
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; }
        //public byte[] PasswordHash { get; set; }
        //public byte[] PaswordSalt { get; set; }
        [JsonIgnore]
        public Account Account { get; set; }
        public Transaction Transaction { get; set; }
      
    }
}