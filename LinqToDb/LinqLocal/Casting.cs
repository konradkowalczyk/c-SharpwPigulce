using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLocal
{
    public class Casting
    {
        public void Execute()
        {
            var intCollection = (new List<int>() { 1, 2, 3 }).AsEnumerable<int>();
            var decCollection = intCollection.Cast<decimal>().ToList(); // exception
            var decCollectionCorrect = intCollection.Select(x => (decimal)x);

        }
    }
}
