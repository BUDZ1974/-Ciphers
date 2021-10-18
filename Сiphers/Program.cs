using System;

namespace Сiphers
{
    class Program
    {
        static void Main(string[] args)
        {
            

        budz:
            Console.WriteLine("Выберите Шифр" +
                "              Виженер -- 1" +
                "              Цезарь  -- 2 ");

            string choice = Convert.ToString(Console.ReadLine());
            switch (choice)
            {
                case  "1" :
                    Console.WriteLine("Введите строку");
                    string Encryp = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Введите ключ");
                    string key = Convert.ToString(Console.ReadLine());
                    Console.WriteLine($"Шифр Виженера -- {Encryption.Encrypt(Encryp, key)}");
      
                    Console.WriteLine($"Decode Виженера -- {Encryption.Decrypt(Encryp, key)}");
                    Console.ReadLine();
                    Console.Clear();
                    goto budz;
                case "2":
                    Console.WriteLine("Введите строку");
                    string CeaserEncryp = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Введите ключ");
                    int CeaserKey = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Шифр Цезаря -- {Encryption.Caeser(CeaserEncryp, CeaserKey)}");
                    Console.WriteLine($"decode Цезаря -- {Encryption.DeCaeser(CeaserEncryp, CeaserKey)}");
                    Console.ReadLine();
                    Console.Clear();
                    goto budz;
                default:
                    Console.WriteLine("такой команды нет ошибка ");
                    goto budz;
            }

            
        }
    }
}
