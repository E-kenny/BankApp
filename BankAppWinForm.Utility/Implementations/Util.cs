﻿using System.Text.RegularExpressions;

using BankAppWinForms.Model.Entities;

namespace BankApp
{
    public static class Validator
    {
        public static Regex  reg = new Regex(@"^[A-Z]\w+$");
        public static Regex pass = new Regex(@"^[@#$%^&!]\w{5,}$");
        public static Regex hasNumber = new Regex(@"[0-9]+");
        //public static Regex hasUpperChar = new Regex(@"[A-Z]+");
        public static Regex hasMinimum8Chars = new Regex(@".{8,}");

        public static Customer  logIn(string email, string password, List<Customer> allCustomer)
        {  
            Customer customer = null;
           

            foreach (var single in allCustomer)
            {
                
                if(single.Email == email && single.Password == password) { customer = single; break; }
            }
           return customer;
        }


        public static bool IsValid(string str)
        {
            if (!reg.IsMatch(str))
            {
                Console.WriteLine($"Name must start with capital letter");
                return false;
            }
            return true;
        }

        public static bool IsPassword(string str)
        {
            var isValidated = hasNumber.IsMatch(str)  && hasMinimum8Chars.IsMatch(str);
            if (!isValidated) 
            {
                return false;
            } 
            return true;
        }

     }

 }