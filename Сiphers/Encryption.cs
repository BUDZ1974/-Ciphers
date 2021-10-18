using System;
using System.Collections.Generic;
using System.Text;

namespace Сiphers
{
    class Encryption
    {
        const string alf = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        #region Caeser

      
        public static string Caeser(string input, int key)
        {
            var res = new StringBuilder();
            input = input.ToUpper();
          
            for (int i = 0; i < input.Length; i++)
                {
                   for (int j = 0; j < alf.Length; j++)
                   {
                    if (input[i] == alf[j])
                    {
                        res.Append(alf[(j + key) % alf.Length]);
                    }
                   }

                }
            return res.ToString();
        }
        public static string DeCaeser(string input, int key=0)
        {
            var res = new StringBuilder();
            input = input.ToUpper();

            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < alf.Length; j++)
                {
                    if (input[i] == alf[j])
                    {
                        res.Append(alf[(j - key + alf.Length) % alf.Length]);
                    }
                }

            }
            return res.ToString();
        }
#endregion

        #region Vigenère


        public static string Encrypt(string input, string key)
        {
            string EnglishAlph = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            input = input.ToUpper();
            key = key.ToUpper();
            var sb = new StringBuilder();
            int counter = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (!(char.IsLetter(input[i])))
                {
                    sb.Append(input[i]);
                    counter++;
                }
                else
                {
                    var inputCharIndex = EnglishAlph.IndexOf(input[i]);
                    var keyIndex = (i - counter) % key.Length;
                    var decryptedChar = EnglishAlph[(inputCharIndex + EnglishAlph.IndexOf(key[keyIndex]))
                    % EnglishAlph.Length];
                    sb.Append(decryptedChar);
                }
            }
            return sb.ToString(); ;

        }
        public static string Decrypt(string input, string key)
        {
            string EnglishAlph = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            input = input.ToUpper();
            key = key.ToUpper();
            var sb = new StringBuilder();
            int counter = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (!(char.IsLetter(input[i])))
                {
                    sb.Append(input[i]);
                    counter++;
                }
                else
                {
                    var inputCharIndex = EnglishAlph.IndexOf(input[i]);
                    var keyIndex = (i - counter) % key.Length;
                    var decryptedChar = EnglishAlph[(inputCharIndex + EnglishAlph.Length - EnglishAlph.IndexOf(key[keyIndex]))
                    % EnglishAlph.Length];
                    sb.Append(decryptedChar);
                }
            }
            return sb.ToString();
        }
 #endregion
    }
}
