using System;
using System.Text.RegularExpressions;

namespace RegExLab
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = ValidName("Joshua");
            Console.WriteLine(name);
            Console.WriteLine();
            
            string email = ValidEmail("fornerjos@gmail.com");
            Console.WriteLine(email);
            Console.WriteLine();

            string phone = ValidPhone("616-862-2972");
            Console.WriteLine(phone);
            Console.WriteLine();

            string date = ValidDate("12/01/2000");
            Console.WriteLine(date);
        }

        public static string ValidName(string message)
        {
            string name = message;
            if (Regex.IsMatch(name, "^[A-Z][a-z]{1,29}$"))
            {
                name = message;
                return name;
            }
            else
            {
                name = "Not Valid";
                return name;
            }           
        }

        public static string ValidEmail(string message)
        {
            string email = message;
            if (Regex.IsMatch(message, @"^([a-zA-Z\d]{1,30}@[a-zA-Z\d]{5,10}.[a-zA-Z\d]{2,3})$"))
            {
                return email;
            }
            else
            {
                return "Not Valid";
            }
        }

        public static string ValidPhone(string number)
        {
            if(Regex.IsMatch(number, @"^\d{3}-\d{3}-\d{4}$"))
            {
                return number;
            }
            else
            {
                return "Not Valid";
            }
        }

        public static string ValidDate(string date)
        {
            if (Regex.IsMatch(date, @"^\d{2}/\d{2}/\d{4}$"))
            {
                return date;
            }
            else
            {
                return "Not Valid";
            }
        }
    }
}
