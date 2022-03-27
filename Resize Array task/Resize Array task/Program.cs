using System;

namespace Resize_Array_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Numbers = { 8, 11, 55, 34, 77, 18, 99 };
            int AddingNumber = 1234;
            AddingProcess(Numbers, AddingNumber);           
        }
        public static void AddingProcess(int[] Arr,int num)
        {

            Array.Resize(ref Arr, Arr.Length + 1);
            Arr[Arr.Length - 1] = num;
            foreach (var item in Arr)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}
