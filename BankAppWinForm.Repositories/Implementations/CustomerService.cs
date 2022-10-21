using BankAppWinForm.Models;
using BankAppWinForm.Repositories;
using BankAppWinForm.Repositories.Interfaces;
using BankAppWinForm.Services.Interfaces;

namespace BankAppWinForm.Services.Implementations
{
    public class CustomerService:ICustomerService
    {
        List<Customer> customers = new List<Customer>();

        public ICustomerRepo _customerRepo;
        public IBankAccountRepository _bankAccountRepository;
        public CustomerService(ICustomerRepo customerRepo, IBankAccountRepository bankAccount)
        {
            _customerRepo = customerRepo;
            _bankAccountRepository = bankAccount;
        }
        
        public Response Register(string firstName, string lastName, string email, string password)
        {
            var customer = new Customer(firstName, lastName, email, password);
            customers = _customerRepo.ReadAllCustomers();
            customers.Add(customer);
            _customerRepo.WriteAllCustomers(customers);
            return new Response() { status = "Successful", message = "Customer has been added", 
            customer = customer};
        }

       
        public  Response logIn(string email, string password)
        {
                Customer customer = null;
                List<BankAccount> bankAccount = new List<BankAccount>();
                
                customers = _customerRepo.ReadAllCustomers();
                             

                foreach (var customer1 in customers)
                {

                    if (customer1.Email == email && customer1.Password == password) { customer = customer1 ; break; }
                }

                if(customer == null)
                {
                    return new Response() { status = "Unsuccessful", message = "Unauthenticated", customer = customer };
                }


                return new Response() { status = "Successful", message="Authenticated", customer = customer };
        }


           



    }
}
