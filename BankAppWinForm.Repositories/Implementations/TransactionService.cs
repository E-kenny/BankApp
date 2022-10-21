using BankAppWinForm.Models;
using BankAppWinForm.Repositories.Interfaces;
using BankAppWinForm.Services.Interfaces;

namespace BankAppWinForm.Services.Implementations
{
    public class TransactionService : ITransactionService
    {
        public List<CustomerTransaction> allTransactionList;
        public ITransactionRepository _transactionRepository;
        public TransactionService(ITransactionRepository transactionRepository)
        {
            _transactionRepository = transactionRepository;
        }


        public string MakeDeposit(BankAccount bankAccount, decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
            }
            var deposit = new CustomerTransaction(bankAccount.Id, amount, date, note);
            bankAccount.allCustomerTransactions.Add(deposit);
            allTransactionList= _transactionRepository.ReadAllTransactions();
            allTransactionList.Add(deposit);
            _transactionRepository.WriteAllTransactions(allTransactionList);

            return "Transaction Successful";
        }

        public string MakeWithdrawal(BankAccount bankAccount, decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                return "Insufficient Fund";
            }

            if (bankAccount.Balance - amount < bankAccount._minimumBalance)
            {
                return "Insufficient Fund";
            }

            var withdrawal = new CustomerTransaction(bankAccount.Id, -amount, date, note);
            bankAccount.allCustomerTransactions.Add(withdrawal);
            allTransactionList = _transactionRepository.ReadAllTransactions();
            allTransactionList.Add(withdrawal);
            _transactionRepository.WriteAllTransactions(allTransactionList);

            return "Successful withdrawal";
        }

        public string Transfer(BankAccount from, decimal amount, BankAccount to, string note)
        {
            
            if (MakeWithdrawal(from, amount, DateTime.Now, note) == "Successful withdrawal")
            {
                MakeDeposit(to, amount, DateTime.Now, note);
            }
            else
            {
                return "Unsuccessful";
            }
           

            return "Successful";
        }
    }
}
