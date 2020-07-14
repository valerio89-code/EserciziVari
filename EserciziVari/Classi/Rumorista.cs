using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EserciziVari.Classi
{
    class Rumorista: Persona, ISuonatore
    {
        public string Suona()
        {
            return "grrgrrgr";
        }
    }
}
