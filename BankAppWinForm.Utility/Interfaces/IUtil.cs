using BankAppWinForms.Model.Entities;

namespace BankAppWinForm.Utility.Interfaces
{
    public interface IUtil
    {
        Customer logIn(string email, string password, List<Customer> allCustomer);
        bool IsValid(string str);

        bool IsPassword(string str);
    }
}