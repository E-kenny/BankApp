
using BankAppWinForm.Models;
using System.Text.Json;
using BankAppWinForm.Repositories.Interfaces;

namespace BankAppWinForm.Repositories.Implementations
{
    public class TransactionRepository : ITransactionRepository
    {
      
        string path = @"C:\Users\Decagon\Documents\Transaction.txt";
        public List<CustomerTransaction> ReadAllTransactions()
        {
            List<CustomerTransaction> x = JsonSerializer.Deserialize<List<CustomerTransaction>>(File.ReadAllText(path));
            
            return x;

        }



        public void WriteAllTransactions(List<CustomerTransaction> data)
        {
            string jsonString = JsonSerializer.Serialize<List<CustomerTransaction>>(data);
            File.WriteAllText(path, jsonString);
        }
    }
}
