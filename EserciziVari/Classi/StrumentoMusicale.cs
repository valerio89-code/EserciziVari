using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EserciziVari.Classi
{
    abstract class StrumentoMusicale : ISuonatore
    {
        public string Marca { get; set; }

        public abstract string Suona();
    }
}
