
using BankAppWinForm.Models;
using System.Text.Json;
using BankAppWinForm.Repositories.Interfaces;

namespace BankAppWinForm.Repositories.Implementations
{
    public class TransactionRepository : ITransactionRepository
    {
      
        string path = @"C:\Users\Decagon\source\repos\AllWinForm\BankAppWinForm\BankAppWinForm.Services\Db\Transaction.json";
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
