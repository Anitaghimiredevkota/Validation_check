using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Lab_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName; string email; string phonenumber; string userdate;
            Console.WriteLine("Plesae enter your name :");
            userName = Console.ReadLine();
            Validator.GetName(userName);               
 
            Console.WriteLine("Plesae enter your email :");
            email = Console.ReadLine();
            Validator.GetEmail(email);
            
            Console.WriteLine("Plese enter a valid phone number : ");
            phonenumber = Console.ReadLine();
            Validator.GetPhoneNumber(phonenumber);
           
            Console.WriteLine("Plese enter a date : ");
            userdate = Console.ReadLine();
            Validator.GetDate(userdate);
            

        }
    }
}
