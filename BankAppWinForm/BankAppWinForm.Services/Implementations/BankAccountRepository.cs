using BankAppWinForm.Models;
using System.Text.Json;
using BankAppWinForm.Repositories.Interfaces;

namespace BankAppWinForm.Repositories.Implementations
{
    public class BankAccountRepository : IBankAccountRepository
    {
        string path = @"C:\Users\Decagon\source\repos\AllWinForm\BankAppWinForm\BankAppWinForm.Services\Db\Account.json";

        public List<BankAccount> ReadAllAccounts()
        {
            List<BankAccount> x = JsonSerializer.Deserialize<List<BankAccount>>(File.ReadAllText(path));
            ////foreach (var a in x)
            ////{
            ////    Console.WriteLine(a.Number); 
            ////}
            return x;
            //return new List<BankAccount>();
        }


        public void WriteAllAccounts(List<BankAccount> data)
        {
            string jsonString = JsonSerializer.Serialize<List<BankAccount>>(data);
            File.WriteAllText(path, jsonString);
        }

    }
}