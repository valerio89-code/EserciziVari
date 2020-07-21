
using System;

namespace EserciziVari
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 1, 5, 6, 7, 5, 1 };
            StampaArrayDaIndice(arr, 2);
        }

        public static void StampaArrayDaIndice(int[] array, int index)
        {
            Console.WriteLine(array[index]);
            if (index == array.Length - 1) return;
            StampaArrayDaIndice(array, index + 1);
            Console.WriteLine($"chiamata di indice {index}");
        }
    }
}
