using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zd6
{
    class Encrypter
    {
        public static string Encrypt(string text)
        {
            string encryptedText = "";
            foreach (char c in text)
            {
                char encryptedChar = (char)(c + 1);
                encryptedText += encryptedChar;
            }
            return encryptedText;
        }
    }
    class Decryptor
    {
        public static string Decrypt(string text)
        {
            string decryptedText = "";
            foreach (char c in text)
            {
                char decryptedChar = (char)(c - 1);
                decryptedText += decryptedChar;
            }
            return decryptedText;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string enc = Encrypter.Encrypt(Convert.ToString(Console.ReadLine()));
            Console.WriteLine(enc);

            Console.WriteLine($"Расшифровка {enc}: " + Decryptor.Decrypt(enc));
            Console.ReadLine();

        }
    }
}

