using System;
using System.Text.RegularExpressions;

namespace EmailValidation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a email");
            string emailInput = Console.ReadLine();
            // string emailInput = "sks.kris810@gmail.com";
            bool email = IsValidEmail(emailInput);
            //OR Console.WriteLine(IsValidEmail(emailInput)); commit
            Console.WriteLine("The typed email is {0}", email);

        }

        public static bool IsValidEmail(string emailInput)
        {
            Regex re = new Regex(@"([a-z][a-z0-9.]*[@][a-z]{5,}[.][a-z]{3,})", RegexOptions.IgnoreCase);
            return re.IsMatch(emailInput);
        }

       
    }
}
