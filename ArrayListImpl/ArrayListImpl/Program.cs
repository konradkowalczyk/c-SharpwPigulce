using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListImpl
{
    public class Program
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.AddRange(new[] { 1, 5, 9 });
            List<int> list = al.Cast<int>().ToList();
        }
    }
}
