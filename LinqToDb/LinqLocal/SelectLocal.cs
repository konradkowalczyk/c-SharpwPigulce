using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace LinqLocal
{
    public class SelectLocal
    {
        public void Execute()
        {
            string[] names = { "Tomek", "Zdzisław", "Grzegorz" };
            var objsWithNames = from n in names select new { name = n };

            var objsWithNames2 = names.Select(x => new { name = x });

            IEnumerable<string> query = names.Select((x, i) => i + "=" + x);

            foreach (var name in query)
                Console.WriteLine(name);
        }
    }
}
