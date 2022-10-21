using BankAppWinForm.Models;
using BankAppWinForm.Repositories.Interfaces;
using BankAppWinForm.Services.Interfaces;

namespace BankAppWinForm.Services.Implementations
{
    public class BankAccountService:IBankAccountService
    {
        public IBankAccountRepository _bankAccountRepository;
        public List<BankAccount> allBankAccounts;

       
        public BankAccountService(IBankAccountRepository bankAccountRepository)
        {
            _bankAccountRepository = bankAccountRepository;
        }

        public BankAccount OpenAccount(Customer customer, int type, decimal initialBalance)
        {
            if (type == 1)
            {
                Savings account = new Savings(customer.Id, customer.Name, initialBalance);
                allBankAccounts = _bankAccountRepository.ReadAllAccounts();
                customer.myAccount.Add(account);
                allBankAccounts.Add(account);
                _bankAccountRepository.WriteAllAccounts(allBankAccounts);
                return account;
            }
            else if (type == 2)
            {
                Current account = new Current(customer.Id, customer.Name, initialBalance);
                allBankAccounts = _bankAccountRepository.ReadAllAccounts();
                customer.myAccount.Add(account);
                allBankAccounts.Add(account);
                _bankAccountRepository.WriteAllAccounts(allBankAccounts);

                return account;
            }

            return null;
        }



    }
}
 