using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EserciziVari.Classi
{
    class Complesso
    {
        public List<ISuonatore> Suonatori { get; set; } = new List<ISuonatore>();

        public void EmettiSuoni()
        {
            foreach (var suonatore in Suonatori)
            {
                suonatore.Suona();
            }
        }
    }
}
