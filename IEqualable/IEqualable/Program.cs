using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEqualable
{
    public class Program
    {
        static void Main(string[] args)
        {
            var n1 = new NestedEqalable() { firstValue = 2, secondValue = 4 };
            var n2 = new NestedEqalable() { firstValue = 3, secondValue = 4 };
            Console.WriteLine(n1.Equals(n2));
            Console.ReadKey();
        }
    }

    public class NestedEqalable : IEquatable<NestedEqalable>
    {
        public int firstValue { get; set; }

        public int secondValue { get; set; }

        public override bool Equals(object other)
        {
            if (!(other is NestedEqalable)) return false;
            return Equals(other);
        }

        public bool Equals(NestedEqalable other)
        {
            return (this.firstValue == other.firstValue && this.secondValue == other.secondValue);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
