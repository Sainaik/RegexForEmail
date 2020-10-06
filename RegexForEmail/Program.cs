using System;
using System.Text.RegularExpressions;

namespace RegexForEmail
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!! Welcome to Pattern Matching Problem for Email");

            //Mandatory 1st part
            String pattern = @"^[a-z]+@[a-z0-9]+\.[a-z]{2,3}$";

            Regex r = new Regex(pattern);

            Console.WriteLine("Enter the 1st, 2nd  and 3rd mandatory Email parts and @ in between");

            String email = Console.ReadLine();

            while(!r.IsMatch(email))
            {
                Console.WriteLine("Mandatory parts are invalid of Email Address: " + email+"\nEnter again: ");
                email = Console.ReadLine();
            }
            Console.WriteLine(email + "  All mandatory parts are valid.");

        }
    }
}
