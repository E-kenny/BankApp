using System;
using System.IO;
using System.Text;
using System.Text.Json;
using BankAppWinForm.Models;
using BankAppWinForm.Repositories.Interfaces;

namespace BankAppWinForm.Repositories.Implementations
{
    public class CustomerRepo:ICustomerRepo
    {
        string path = @"C:\Users\Decagon\source\repos\AllWinForm\BankAppWinForm\BankAppWinForm.Services\Db\Customer.json";

        public List<Customer> ReadAllCustomers()
        {
            var x = JsonSerializer.Deserialize<List<Customer>>(File.ReadAllText(path));
            foreach (var a in x)
            {
                Console.WriteLine(a.Name);
            }

            return x;
             
        }



        public void WriteAllCustomers(List<Customer> data)
        {
                    string jsonString = JsonSerializer.Serialize<List<Customer>>(data);
                    File.WriteAllText(path, jsonString);
        }


}

}

    
