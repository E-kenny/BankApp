
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

    }
}
