using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralEquatableTupleArray
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] a1 = { 1, 2, 3 };
            int[] a2 = { 1, 2, 3 };

            IStructuralEquatable se1 = a1;
            Console.WriteLine(a1.Equals(a2));
            Console.WriteLine(se1.Equals(a2, EqualityComparer<int>.Default));
            Console.ReadKey();
        }



    }
}
