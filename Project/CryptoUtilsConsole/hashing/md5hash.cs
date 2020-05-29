using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace ConsoleApplication2
{
    class Program
    {
      
        static void Main(string[] args)
        {
            Console.WriteLine("INPUT HERE : ");
            string password = Console.ReadLine();
            Console.WriteLine("");
            // byte array representation of that string
            byte[] encodedPassword = new UTF8Encoding().GetBytes(password);

            // need MD5 to calculate the hash
            byte[] hash = ((HashAlgorithm)CryptoConfig.CreateFromName("MD5")).ComputeHash(encodedPassword);

            // string representation (similar to UNIX format)
            string encoded = BitConverter.ToString(hash).Replace("-", string.Empty).ToLower();
            Console.WriteLine("YOUR HASH : ");
            Console.WriteLine(encoded);
            Console.WriteLine("");

        }
    }
}
