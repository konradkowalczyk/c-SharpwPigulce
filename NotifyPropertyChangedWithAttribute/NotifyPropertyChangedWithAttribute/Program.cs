using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotifyPropertyChangedWithAttribute
{
    class Program
    {
        static void Main(string[] args)
        {
            var changesList = new List<string>();
            var foo = new Foo();
            foo.PropertyChanged += (x, y) => changesList.Add(x + " " + y.PropertyName); 

            foo.CustomerName = "Zbigniew";
            foo.CustomerName = "Zbigniew";
            foo.CustomerName = "Zbigniew2";
            foo.CustomerName = "Zbigniew3";
            foo.CustomerName = "Zbigniew4";
            foreach (var change in changesList)
            {
                Console.WriteLine(change);
            }
            Console.ReadKey();
        }
    }
}
