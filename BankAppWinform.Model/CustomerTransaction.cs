﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAppWinForm.Models
{
    public class CustomerTransaction
    {
        public string AccountId { get; set; }
        public decimal Amount { get; }
        public DateTime Date { get; }
        public string Descriptions { get; }

        public CustomerTransaction(string accountId, decimal amount, DateTime date, string Description)
        {   AccountId=accountId;
            Amount = amount;
            Date = date;
            Descriptions = Description;
        }
    }
}
