
namespace BankAppWinForm.Models
{
    public class Customer
    {
       
        public List<BankAccount> myAccount = new List<BankAccount>();
        
        public Customer(string firstName, string lastName, string email, string password)
        {
            Id = Guid.NewGuid().ToString();
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;           
        }

        public string Id { get; set; }
        public string FirstName
        {
            get; set;
        }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name
        {
            get { return $"{LastName} {FirstName}"; }

        }


        public string AccountDetails()
        {
            var report = new System.Text.StringBuilder();


            report.AppendLine($"ACCOUNT DETAILS");
            report.AppendLine($"|---------------|------------------------|---------------|---------------|");
            report.AppendLine($"|{"FULL NAME",-15}| {"ACCOUNT NUMBER",-23}| {"ACCOUNT TYPE",-15}| {"AMOUNT BALANCE",-15}");
            report.AppendLine($"|---------------|------------------------|---------------|---------------|");
            foreach (var item in myAccount)
            {

                report.AppendLine($"|{Name,-15}| {item.Number,-25}| {item.Type,-15}| {item.Balance,-15}|");
            }

            report.AppendLine($"|---------------|------------------------|---------------|---------------|");

            return report.ToString();
        }


    }
}
