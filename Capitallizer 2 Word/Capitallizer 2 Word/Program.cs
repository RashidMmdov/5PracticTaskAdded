using System;

namespace Capitallizer_2_Word
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4.Verilmiş string dəyərin içərisində 2 söz olmasını və hər bir sözün böyük hərflə başlamasını
            //yoxlayan metod
            string Sentence = "Rashid Mammadov";
            Console.WriteLine(Sentence);
            Console.WriteLine("Sert Duzgundur?");
            Console.WriteLine(findWords(Sentence));
            string Sentence2 = "adsiz kitab";
            Console.WriteLine(Sentence2);
            Console.WriteLine("Sert Duzgundur?");
            Console.WriteLine(findWords(Sentence2));
        }
        public static bool findWords(string str)
        {
            bool Check = false;
            bool bigFirstWord = false;
            bool bigSecondWord = false;
            string[] strArr = str.Split();
            if (strArr.Length == 2)
            {
                string FirstWord = strArr[0];
                string SecondWord = strArr[1];
                if (FirstWord[0] == char.ToUpper(FirstWord[0]))
                {
                    bigFirstWord = true;
                }
                if (SecondWord[0] == char.ToUpper(SecondWord[0]))
                {
                    bigSecondWord = true;
                }
            }
            Check = bigFirstWord && bigSecondWord;
            return Check;
        }
    }
}
