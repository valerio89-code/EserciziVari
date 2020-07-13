using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EserciziVari
{
    class Program
    {
        static void Main(string[] args)
        {
            var numeriFibonacci = new List<int> { 0, 1 };
            Console.WriteLine("Inserisci il numero di elementi di fibonacci");
            var numeroIterazioni = int.Parse(Console.ReadLine());
            while(numeriFibonacci.Count < numeroIterazioni)
            {
                var f1 = numeriFibonacci[numeriFibonacci.Count - 1];
                var f2 = numeriFibonacci[numeriFibonacci.Count - 2];
                numeriFibonacci.Add(f1 + f2);
            }
            foreach (var fib in numeriFibonacci)
            {
                Console.WriteLine(fib);
            }
            var numeriDispariFibonacci = numeriFibonacci.Where(n => n % 2 != 0).ToList();
            numeriDispariFibonacci.ForEach(i => Console.WriteLine(i));
            

        }
    }

}
