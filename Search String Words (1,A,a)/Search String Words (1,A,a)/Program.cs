using System;

namespace Search_String_Words__1_A_a_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = "Az1";
            Console.WriteLine("1.  " + word + " - " + isTrueFormat(word));
            string word2 = "az1";
            Console.WriteLine("2.  " + word2 + " - " + isTrueFormat(word2));
            string word3 = "az";
            Console.WriteLine("3.  " + word3 + " - " + isTrueFormat(word3));
            string word4 = "AZ1";
            Console.WriteLine("4.  " + word4 + " - " + isTrueFormat(word4));

        }
        public static bool isTrueFormat(string word)
        {
            bool search = false;
            bool BigLetter = false;
            bool SmallLetter = false;
            bool NumLetter = false;
            for (int i = 0; i < word.Length; i++)
            {
                int NumberValueTC = (int)word[i];
                if (NumberValueTC >= 65 && NumberValueTC <= 90)
                {
                    BigLetter = true;
                }
                if (NumberValueTC >= 97 && NumberValueTC <= 122)
                {
                    SmallLetter = true;
                }
                if (NumberValueTC >= 48 && NumberValueTC <= 57)
                {
                    NumLetter = true;
                }

            }
            search = BigLetter && SmallLetter && NumLetter;

            return search;
        }
    }
}
