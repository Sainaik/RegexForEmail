using System;
using System.Text.RegularExpressions;

namespace RegexForEmail
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!! Welcome to Pattern Matching Problem for Email");

            //Pattern For Mandatory 1st part --->  ^[a-z]+
            //Pattern For Mandatory 2st part --->  @[a-z0-9]+
            //Pattern For Mandatory 3st part --->  \.[a-z]{2,3}
            //Pattern For optional 1st part  --->  ([-+*.]?[0-9a-z])*
           

            String pattern = @"^[a-z]+([-+*.]?[0-9a-z])*@[a-z0-9]+\.[a-z]{2,3}$";

            Regex r = new Regex(pattern);

            Console.WriteLine("Enter email");

            String email = Console.ReadLine();

            while(!r.IsMatch(email))
            {
                Console.WriteLine("Invalid of Email Address: " + email+"\nEnter again: ");
                email = Console.ReadLine();
            }
            Console.WriteLine(email + " is valid.");

        }
    }
}
