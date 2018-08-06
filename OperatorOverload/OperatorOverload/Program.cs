using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverload
{
    public class Program
    {
        static void Main(string[] args)
        {
            Note B = new Note(2);
            Note CSharp = B + 2;
            Console.Write(CSharp.value);
            Console.ReadKey();
        }

        public struct Note
        {
            public int value;
            public Note(int semitonesFromA) { value = semitonesFromA; }
            public static Note operator + (Note x, int semitones)
            {
                return new Note(x.value + semitones);
            }
        }

    }
}
