﻿using BankApiService.Models;
using Microsoft.EntityFrameworkCore;
using System.Xml;

namespace BankApiService.Context
{
    public class BankContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=mydatabase.db");
        }
    }
}
