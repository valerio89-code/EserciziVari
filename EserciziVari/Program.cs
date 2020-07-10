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
            var p = new Persona();
            Console.WriteLine(p.Counter);
            Console.WriteLine(p.Counter);
            Console.WriteLine(p.Counter);
            var p2 = new Persona();
            Console.WriteLine(p2.MyProperty);
            Console.WriteLine(p2.MyProperty);
            Console.WriteLine(p2.MyProperty);
            Persona.counter++;
            Console.WriteLine(p.Counter);
            Console.WriteLine(p2.MyProperty);
        }
    }

    public class Persona
    {
        public static int counter;

        //ExpressionBody
        public int Counter => counter++;

        //Auto-implemented property
        public int MyProperty { get; } = counter++;

        public Persona()
        {

        }


    }
}
