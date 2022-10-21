using BankAppWinForms.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAppWinForms.Repositories.Interfaces
{
    public interface ICustomerRepository
    {
        void AddCustomer(Customer user);
        void UpdateCustomer(Customer user);
        void DeleteCustomer(Customer user);
        Customer GetCustomerById(int id);
    }
}
