
using BankAppWinforms.Repositories.Interfaces;
using BankAppWinForms.Model.Entities;

namespace BankAppWinForm.Services.Implementation
{
    public class BankAccontService
    {
        public IBankAccountRepository _bankAccountRepo;
  

        public BankAccontService(IBankAccountRepository bankAccountRepository)
        {
            _bankAccountRepo = bankAccountRepository;
        }


        public BankAccount OpenAccount(string type, decimal initialBalance)
        {
            if (type == "Saving")
            {
                var account = new BankAccount( type, initialBalance);

                myAccount.Add(account);
                return account;
            }
            else if (type == 2)
            {
                var account = new Current(Name, initialBalance);
                myAccount.Add(account);
                return account;
            }

            return null;
        }

        public string GetAccountStatement()
        {
            var report = new System.Text.StringBuilder();

            decimal balance = 0;
            report.AppendLine($"ACCOUNT STATEMENT ON ACCOUNT NO {Number}");
            report.AppendLine($"|---------------|------------------------|---------------|---------------|");
            report.AppendLine($"|{"Date",-15}| {"Description",-23}| {"Amount",-15}| {"Balance",-15}|");
            report.AppendLine($"|---------------|------------------------|---------------|---------------|");
            foreach (var item in allCustomerTransactions)
            {
                balance += item.Amount;
                report.AppendLine($"|{item.Date.ToShortDateString(),-15}| {item.Descriptions,-25}| {item.Amount,-15}| {balance,-15}|");
            }

            report.AppendLine($"|---------------|------------------------|---------------|---------------|");

            return report.ToString();
        }
    }
}
