
namespace BankAppWinForm.Models
{
    public class BankAccount
    {
        public string Id { get; set; }
        public string CustomerId { get; set; }  
        public string Number { get; set; }
        public string Owner { get; set; }

        public virtual string Type { get; set; }

        public List<CustomerTransaction> allCustomerTransactions = new List<CustomerTransaction>();

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

            Random rnd = new Random();
            Number = Convert.ToString(rnd.Next());
        }

    }
}
