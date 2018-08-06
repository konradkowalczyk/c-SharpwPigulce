using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethodHideAndOverride
{
    class Program
    {
        static void Main(string[] args)
        {
            var over = new Overrider();
            BaseClass b1 = over;
            over.Foo();
            b1.Foo();

            var h = new Hider();
            BaseClass b2 = h;
            h.Foo();
            b2.Foo();

            Console.ReadKey();

        }

        public class BaseClass
        {
            public virtual void Foo() => Console.WriteLine("BaseClass.Foo");
        }

        public class Overrider : BaseClass
        {
            public override void Foo() => Console.WriteLine("Overrider.Foo");
        }

        public class Hider : BaseClass
        {
            public new void Foo() => Console.WriteLine("Hider.Foo"); 
        }


    }
}
