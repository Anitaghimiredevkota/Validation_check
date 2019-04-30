using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace Lab_7
{
    class Validator
    {     
        public static string GetName(string input)
        {
            bool regexValidatorName;
            
            regexValidatorName = Regex.IsMatch(input, @"^[a-zA-Z][a-zA-Z\\s]+$");

            if (regexValidatorName)
            {               
                Console.WriteLine("valid name");
            }
            else
            {
                Console.WriteLine("Sorry, name is not valid!");
            }
                return input;
        }        
        public static string GetEmail(string useremail)
        {
            bool regexValidatorEmail;
            regexValidatorEmail = Regex.IsMatch(useremail, @"([a-zA-Z0-9]){5,30}(@)([a-zA-Z0-9]){5,10}\.([a-zA-Z0-9]){2,3}");
            if (regexValidatorEmail)
            {
                Console.WriteLine("Email is valid!");
            }
            else
            {
                Console.WriteLine("Please enter a valid email:");
            }

            return useremail;
        }
        public static string GetPhoneNumber(string phonenumber)
        {
            
            bool regexValidatorPhone;
            regexValidatorPhone = Regex.IsMatch(phonenumber , @"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$"); 
            if (regexValidatorPhone)
            {
                Console.WriteLine("Valid phonenumber");
            }
            else
            {
                Console.WriteLine("Sorry, phone number is not valid!");
            }        
            return phonenumber;
        }
        public static string GetDate(string date)
        {
           
            bool regexValidatordate;
            regexValidatordate = Regex.IsMatch(date, @"^([0]?[1-9]|[1][0-2])[./-]([0]?[1-9]|[1|2][0-9]|[3][0|1])[./-]([0-9]{4}|[0-9]{2})$");
            if (regexValidatordate)
            {
                Console.WriteLine("Valid date");
            }
            else
            {
                Console.WriteLine("Sorry, date is not valod!");
            }
            return date;
        }
    }
}
