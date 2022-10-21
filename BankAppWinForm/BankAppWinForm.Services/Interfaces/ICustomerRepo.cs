
using BankAppWinForm.Models;

namespace BankAppWinForm.Repositories.Interfaces
{
    
    public interface ICustomerRepo
    {
        List<Customer> ReadAllCustomers();
        void WriteAllCustomers(List<Customer> data);
    }
}
