using static EserciziVari.Classe1;

namespace EserciziVari
{
    class Program
    {
        static void Main(string[] args)
        {
            var c1 = new Classe1();
            var c2 = new Classe2();
        }       
    }

    public class Classe1
    {
        private Classe2 MyPropertyc1 { get; set; } = new Classe2();
        public class Classe2
        {
            public int MyPropertyc2 { get; set; }

        }
    }


}
