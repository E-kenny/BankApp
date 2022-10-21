namespace BankAppWinForm.Models
{
    public class Current : BankAccount
    {
        public override string Type { get; set; }
        public Current()
        {

        }
        public Current(string id, string name, decimal initialBalance) : base(id, name, initialBalance)
        {
            Type = "Current";
        }
    }
}
