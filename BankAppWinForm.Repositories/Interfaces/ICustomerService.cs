using BankAppWinForm.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAppWinForm.Services.Interfaces
{
    public interface ICustomerService
    {
        Response Register(string firstName, string lastName, string email, string password);
        Response logIn(string email, string password);
    }
}
