namespace BankAppWinForm.Models
{
    public class Savings : BankAccount
    {
        public override string Type { get; set; }

        public Savings()
        {
            
        }
        public Savings(string id, string name, decimal initialBalance) : base(id, name, initialBalance, 1000)
        {
            Type = "Savings";
        }

    }
}
