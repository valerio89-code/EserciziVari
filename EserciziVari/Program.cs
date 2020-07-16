using EserciziVari.Classi;
using System;
using System.Collections;
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
            var a = new A();
            double myMediaOut;
            var str2 = a.MediaConOut(out myMediaOut, 6, 7, 8, 9);

            double myMediaRef = 10;
            var str = a.MediaConRef(ref myMediaRef, 6, 7, 8, 9);

            var b = new B() { Nome = "gianlupo" };
            a.ValorizzaClasse(ref b);
            Console.WriteLine(b.Nome);
        }
    }

    public class A
    {
        public string Media(double media, params int[] values)
        {
            //var media = valore chhe gli ho passato
            var somma = 0;
            foreach (var intero in values)
            {
                somma += intero;
            }
            media = (double)somma / values.Length;
            return "media calcolata";
        }

        public string MediaConOut(out double media, params int[] values)
        {
            var somma = 0;
            foreach (var intero in values)
            {
                somma += intero;
            }
            //myMediaConOut
            media = (double)somma / values.Length;
            return "media calcolata";
        }
        public string MediaConRef(ref double media, params int[] values)
        {
            var somma = 0;
            foreach (var intero in values)
            {
                somma += intero;
            }
            //myMediaConOut
            media = (double)somma / values.Length;
            return "media calcolata";
        }

        public bool ValorizzaClasse(ref B cl)
        {
            cl = new B();
            cl.Nome = "luca";
            return true;
        }
    }

    public class B
    {
        public string Nome { get; set; }


    }




}
