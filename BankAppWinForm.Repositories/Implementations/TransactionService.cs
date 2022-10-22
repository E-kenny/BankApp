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


        public List<CustomerTransaction> MakeDeposit(string id, decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
            }
            var deposit = new CustomerTransaction(id, amount, date, note);
            allTransactionList = _transactionRepository.ReadAllTransactions();
            allTransactionList.Add(deposit);
            _transactionRepository.WriteAllTransactions(allTransactionList);

            return allTransactionList;
        }

        public List<CustomerTransaction> MakeWithdrawal(string id, decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                return null; ;
            }

            //if ( amount < bankAccount._minimumBalance)
            //{
            //    return "Insufficient Fund";
            //}

            var withdrawal = new CustomerTransaction(id, -amount, date, note);
            allTransactionList = _transactionRepository.ReadAllTransactions();
            allTransactionList.Add(withdrawal);
            _transactionRepository.WriteAllTransactions(allTransactionList);

            return allTransactionList;
        }

        public List<CustomerTransaction> Transfer(string id1, decimal amount, string id2, string note)
        {
            
            if (MakeWithdrawal(id1, amount, DateTime.Now, note) != null)
            {
                MakeDeposit(id2, amount, DateTime.Now, note);
            }
            else
            {
                return null;
            }
           

            return allTransactionList;
        }
    }
}
