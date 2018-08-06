using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            if (2.Chain() < 4)
            {
                Console.WriteLine("Yay!");
            }
        }
    }

    public class Chainable<T> where T : IComparable<T>
    {
        public Chainable(T value)
        {
            Value = value;
            Failed = false;
        }

        public Chainable()
        {
            Failed = true;
        }

        public readonly T Value;
        public readonly bool Failed;

        public static Chainable<T> Fail { get { return new Chainable<T>(); } }

        public static Chainable<T> operator <(Chainable<T> me, T other)
        {
            if (me.Failed)
                return Fail;

            var dummy = me.Value.CompareTo(other) == -1
                       ? new Chainable<T>(other)
                       : Fail; 
            return me.Value.CompareTo(other) == -1
                       ? new Chainable<T>(other)
                       : Fail;
        }

        public static Chainable<T> operator >(Chainable<T> me, T other)
        {
            if (me.Failed)
                return Fail;

            return me.Value.CompareTo(other) == 1
                       ? new Chainable<T>(other)
                       : Fail;
        }

        public static Chainable<T> operator ==(Chainable<T> me, T other)
        {
            if (me.Failed)
                return Fail;

            return me.Value.CompareTo(other) == 0
                       ? new Chainable<T>(other)
                       : Fail;
        }

        public static Chainable<T> operator !=(Chainable<T> me, T other)
        {
            if (me.Failed)
                return Fail;

            return me.Value.CompareTo(other) != 0
                       ? new Chainable<T>(other)
                       : Fail;
        }

        public static bool operator true(Chainable<T> me)
        {
            return !me.Failed;
        }

        public static bool operator false(Chainable<T> me)
        {
            return me.Failed;
        }

        public override bool Equals(object obj)
        {
            return Value.Equals(obj);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
    }

    public static class ChainExt
    {
        public static Chainable<T> Chain<T>(this T value) where T : IComparable<T>
        {
            return new Chainable<T>(value);
        }
    }

    public static class HaHaExt
    {
        public static HaHaAble<T> Haha<T>(this T value) where T : IComparable<T>
        {
            return new HaHaAble<T>(value);
        }
    }

    public class HaHaAble<T> where T : IComparable<T>
    {
        public HaHaAble(T value)
        {
            Console.WriteLine("Yep this is hahable");
        }
    }
}
