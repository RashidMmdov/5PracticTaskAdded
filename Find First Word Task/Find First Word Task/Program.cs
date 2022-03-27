using System;

namespace Find_First_Word_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Sentence = "Dersler Eladir!";
            Console.WriteLine($"Cumle: {Sentence}");
            Console.Write("Ilk soz: ");
            Console.WriteLine(FindFirstWord(Sentence));
        }
        public static string FindFirstWord(string sentence)
        {
            string[] word = sentence.Split();
            return word[0];
            // Bu taski 2 yontemle yazdim 2 yontem de duzgundur;
            #region 2ci yontem
            //for (int i = 0; i < sentence.Length; i++)
            //{
            //    int temp = (int)sentence[i];
            //    if (temp == 32)
            //    {
            //        sentence = sentence.Remove(i);
            //        break;
            //    }
            //}
            //return sentence;
            #endregion

        }
    }
}
