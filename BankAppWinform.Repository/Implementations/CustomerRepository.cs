using System.Text.Json;
using BankAppWinForms.Data.Interface;
using BankAppWinForms.Model.Entities;
using BankAppWinForms.Repositories.Interfaces;
using Microsoft.VisualBasic;

namespace BankAppWinForms.Repositories.Implementations
{
    public class CustomerRepository: ICustomerRepository
    {
        private readonly IDatabase _database;
        public CustomerRepository(IDatabase database)
        {
            _database = database;
        }

        public void AddCustomer(Customer customer)
        {
            var customerCount = _database.Customers.Count;
            customer.Id = customerCount + 1;

            _database.Customers.Add(customer);
        }

        public void DeleteCustomer(Customer customer)
        {
            _database.Customers.Remove(customer);
        }

        public Customer GetCustomerById(int id)
        {
            return _database.Customers.Where(x => x.Id == id).FirstOrDefault();
        }

        public void UpdateCustomer(Customer customer)
        {
            var userFromDb = _database.Customers.Where(x => x.Id == customer.Id).FirstOrDefault();
            if (userFromDb is null)
                return;

            userFromDb.FirstName = customer.FirstName;
            userFromDb.LastName = customer.LastName;
        }
    }
}
