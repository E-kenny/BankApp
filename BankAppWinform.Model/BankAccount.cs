
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
            get
            {
                decimal balance = 0;
                foreach (var item in allCustomerTransactions)
                {
                    balance += item.Amount;
                }
                return balance;
            }

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

           // this is where deposit go to
            //if (initialBalance > 0)
            //{
            //    MakeDeposit(initialBalance, DateTime.Now, "Initial balance");
            //}

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
