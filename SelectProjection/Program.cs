using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectProjection
{
    class Program
    {
        static void Main(string[] args)
        {

            var strings = new List<string>() { "haha1", "haha2", "haha3" };

            var newStrings = strings.Select((x, i) => i + "=" + x);
        }
    }
}
