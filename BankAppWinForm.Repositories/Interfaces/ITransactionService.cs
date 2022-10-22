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
        List<CustomerTransaction> MakeDeposit(string bankAccount, decimal amount, DateTime date, string note);
        List<CustomerTransaction> MakeWithdrawal(string bankAccount, decimal amount, DateTime date, string note);
        List<CustomerTransaction> Transfer(string bankAccount, decimal amount, string account, string note);
    }
}
