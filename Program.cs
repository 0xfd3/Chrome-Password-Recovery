using System;
using System.Collections.Generic;
using System.Text;

namespace ChromeRecovery
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = Chromium.Grab();

            foreach (var b in a)
            {
                Console.WriteLine("Url: " + b.URL);
                Console.WriteLine("Username: " + b.UserName);
                Console.WriteLine("Password: " + b.Password);
                Console.WriteLine("Application: " + b.Application);
                Console.WriteLine("=============================");
            }

            Console.ReadKey();

        }
    }
}
