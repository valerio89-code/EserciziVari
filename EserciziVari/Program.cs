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
            var complesso = new Complesso();
            complesso.Suonatori.Add(new Batteria());
            //verificare differenza tra setter e utilizzo property; inizializzazione vs expression body
            complesso.Suonatori = new List<ISuonatore>();
        }
    }
}
