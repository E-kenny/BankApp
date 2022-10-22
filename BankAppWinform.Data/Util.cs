using System.Text.RegularExpressions;
using System.ComponentModel.DataAnnotations;
using BankAppWinForm.Models;

namespace BankAppWinForms.Utilities
{
    public class Validator
    {
        public static Regex reg = new Regex(@"^[A-Z]\w+$");
        public static Regex pass = new Regex(@"^[@#$%^&!]\w{5,}$");
        public static Regex hasNumber = new Regex(@"[0-9]+");
        //public static Regex hasUpperChar = new Regex(@"[A-Z]+");
        public static Regex hasMinimum8Chars = new Regex(@".{8,}");


        public bool IsValid(string str)
        {
            if (!reg.IsMatch(str))
            {
                Console.WriteLine($"Name must start with capital letter");
                return false;
            }
            return true;
        }

        public bool IsPassword(string str)
        {
            var isValidated = hasNumber.IsMatch(str) && hasMinimum8Chars.IsMatch(str);
            if (!isValidated)
            {
                return false;
            }
            return true;
        }

    }
}