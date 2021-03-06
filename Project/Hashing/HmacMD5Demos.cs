﻿using System;
using System.Security.Cryptography;
using System.Text;

namespace CryptoUtilsConsole.hashing
{
    class HmacMD5Demos
    {
        public static byte[] getHMACMD5(string message)
        {
            using (var randonNumberGenerator = new RNGCryptoServiceProvider())
            {
                byte[] key = new byte[32];
                randonNumberGenerator.GetBytes(key);
                using (var hmacmd5 = new HMACMD5(key))
                {
                    byte[] hashmeHashed = hmacmd5.ComputeHash(Encoding.UTF8.GetBytes(message));
                    return hashmeHashed;
                }
            }
        }

        public static void LaunchDemo()
        {
            Console.WriteLine(" Hmac MD5 HASH RUNNING ");

            Console.WriteLine("_________________________");

            Console.WriteLine("INPUT HERE :");

            Console.WriteLine("");

            string message = Console.ReadLine();

            byte[] hashmeHashed = getHMACMD5(message);
            string result = BitConverter.ToString(hashmeHashed).Replace("-", "");

            Console.WriteLine("HMACMD5 : " + result);
            Console.WriteLine("------------------");
            
        }
    }
}