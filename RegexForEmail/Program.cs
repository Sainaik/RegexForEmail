using System;
using System.Text.RegularExpressions;

namespace RegexForEmail
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!! Welcome to Pattern Matching Problem for Email");


            //String Pattern = "^(abc.)[a-z0-9]*(@bridgelabz.co.)[a-z]+$";
            // pattern = @"^([a-z][a-z0-9.+_-]*@([a-z0-9]([a-z0-9-]*[a-z0-9])?\.)+[a-z0-9]([a-z0-9-]*[a-z0-9])?)$";
            // [a-z]+[-+*.]?[0-9a-z]*@[a-z0-9]+\.(\.?[a-z]{2,}){1,2}

            //String pattern = @"^[a-z]+[-+*.]?[0-9a-z]*@[a-z0-9]+\.(\.?[a-z]{2,}){1,2}$";

            String pattern = @"^[a-z]+([-+*.]?[0-9a-z])*@[a-z0-9]+\.(\.?[a-z]{2,}){1,2}$";

            Regex r = new Regex(pattern);

            Console.WriteLine("Enter the Email");

            String email = Console.ReadLine();

            if (r.IsMatch(email))
            {
                Console.WriteLine("Valid Email Address");

            }
            else
            {
                Console.WriteLine("Invalid Email Address");

            }

        }
    }
}
