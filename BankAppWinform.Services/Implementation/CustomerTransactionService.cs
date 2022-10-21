using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAppWinForm.Services.Implementation
{
    public class CustomerTransactionService
    {
        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
            }
            var deposit = new CustomerTransaction(amount, date, note);
            allCustomerTransactions.Add(deposit);
        }

        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");
            }

            if (Balance - amount < _minimumBalance)
            {
                throw new InvalidOperationException("Insufficient fund for this operation");
            }

            var withdrawal = new CustomerTransaction(-amount, date, note);
            allCustomerTransactions.Add(withdrawal);
        }

        public string Transfer(decimal amount, BankAccount account, string note)
        {
            MakeWithdrawal(amount, DateTime.Now, note);
            account.MakeDeposit(amount, DateTime.Now, note);
            return "Successful";
        }

    }
}
