﻿using System.Text.Json.Serialization;

namespace BankApiService.Models
{
    public class Account : EntityBase
    {
        public DateTime OpenDate { get; set; } = DateTime.Now;
        public int Number { get; set; }
        public string Owner { get; set; }
        public int Balance { get; set; } = 0;

        // Navigation property
        public List<Transaction> Transactions { get; set; } = new List<Transaction>();
    }
}