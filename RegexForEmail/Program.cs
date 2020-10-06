﻿using System;
using System.Text.RegularExpressions;

namespace RegexForEmail
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!! Welcome to Pattern Matching Problem for Email");

            //Mandatory 1st part
            String pattern = @"^[a-z]+([-+.]?[0-9a-z])*@[a-z0-9]+\.(\.?[a-z]{2,}){1,2}$";

            Regex r = new Regex(pattern);

            Console.WriteLine("Enter the 1st, 2nd, 3rd Mandatory and Optional Email parts and @ in between");

            String email = Console.ReadLine();

            while(!r.IsMatch(email))
            {
                Console.WriteLine("1st Mandatory part is Invalid of Email Address: " + email+"\nEnter again: ");
                email = Console.ReadLine();
            }
            Console.WriteLine(email + " 1st, 2nd, 3rd Mandatory and Optional parts are valid.");

        }
    }
}
