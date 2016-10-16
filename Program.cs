using System;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var cert = new X509Certificate2("hacks.pfx", "hacks");
            Console.WriteLine("Hello World!");
        }
    }
}
