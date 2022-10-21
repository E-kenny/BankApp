
namespace BankAppWinForm.Models
{
    public class BankAccount
    {
        private static int accountNumberSeed = 0987654321;

        public string Id { get; set; }
        public string CustomerId { get; set; }  
        public string Number { get; set; }
        public string Owner { get; set; }

        public virtual string Type { get; set; }

        public List<CustomerTransaction> allCustomerTransactions = new List<CustomerTransaction>();
        public decimal Balance
        {
            get ;
        }

        public decimal _minimumBalance;

        public BankAccount()
        {

        }

        public BankAccount(string id, string name, decimal initialBalance) : this(id, name, initialBalance, 0) { }
        public BankAccount(string id, string name, decimal initialBalance, decimal minimumBalance)
        {
            Id = Guid.NewGuid().ToString();
            CustomerId = id;
            Owner = name;
            _minimumBalance = minimumBalance;
            Number = accountNumberSeed.ToString();
            accountNumberSeed++;

        }

    }
}
