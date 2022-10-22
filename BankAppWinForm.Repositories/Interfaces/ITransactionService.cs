using BankAppWinForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAppWinForm.Services.Interfaces
{
    public interface ITransactionService
    {
        List<CustomerTransaction> MakeDeposit(BankAccount bankAccount, decimal amount, DateTime date, string note);
        List<CustomerTransaction> MakeWithdrawal(BankAccount bankAccount, decimal amount, DateTime date, string note);
        List<CustomerTransaction> Transfer(BankAccount bankAccount, decimal amount, BankAccount account, string note);
    }
}
