using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EserciziVari
{
    public static class Extensions
    {
        public static void StampaValori(this A istanzaAAmiuscolo)
        {
            foreach (var item in istanzaAAmiuscolo.ultimiValoriUsatiNelCalcoloMedia)
            {
                Console.WriteLine(item);
            }
        }

        public static void StampaValoriLista<T>(this List<T> listaDiInteri)
        {
            foreach (var item in listaDiInteri)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public static void StampaValoriArray<T>(this T[] array)
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int> { 1, 2, 3, 4, 6, 7, 42 };
            Extensions.StampaValoriLista(list);
            list.StampaValoriLista();
            list.Average();
            list.Add(19);



            A a = new A();
            Console.WriteLine(a.Media(2, 1, 2, 3));
            foreach (var valore in a.ultimiValoriUsatiNelCalcoloMedia)
            {
                Console.WriteLine(valore);
            }
            Console.WriteLine(a.Media(2, 1, 2, 4, 5, 8, 9, 10, 25));
            foreach (var valore in a.ultimiValoriUsatiNelCalcoloMedia)
            {
                Console.WriteLine(valore);
            }
            a.StampaValori();

            Extensions.StampaValori(a);
            a.StampaValori();



        }
    }

    public class A
    {
        public int[] ultimiValoriUsatiNelCalcoloMedia;

        public string Media(params int[] values)
        {
            ultimiValoriUsatiNelCalcoloMedia = values;
            var somma = 0;
            foreach (var intero in values)
            {
                somma += intero;
            }
            var media = (double)somma / values.Length;
            return $"media calcolata {media}";
        }
    }
}
