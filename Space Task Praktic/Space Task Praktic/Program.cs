using System;

namespace Space_Task_Praktic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string Sentence = "Salam,           Dunya";
            Console.WriteLine($"Old Sentence: {Sentence}");
            Console.Write("New Sentence: ");
            findSpace(Sentence);


        }
        public static void findSpace(string sentence)
        {
            string Str = "";
           
            int StartIndex = 0;
            int EndIndex = 0;
            for (int i = 0; i < sentence.Length; i++)
            {
                int typeC = (int)sentence[i];

                if (typeC == 32)
                {
                    StartIndex = sentence.IndexOf(" ");
                    EndIndex = sentence.LastIndexOf(" ");
                    int tempValue = EndIndex - StartIndex;
                    Str= sentence.Remove(StartIndex,tempValue);
                }
            }
            Console.WriteLine(Str);
        }
    }
}
