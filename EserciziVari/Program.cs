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
            var p = new Persona("valdes");
            p.GetNettoGuadagnato();

        }
    }

    public class Persona
    {
        private readonly string cognome;
        public int Reddito { get; set; } = 5000;
        public Persona(string cognome)
        {
            this.cognome = cognome;
        }
        public double GetNettoGuadagnato()
        {
            return Reddito - TaxCalculator.GetTaxes(this);
        }
    }

    public class TaxCalculator
    {
        public static double GetTaxes(Persona pers)
        {
            return pers.Reddito * 0.27;
        }
    }
}
