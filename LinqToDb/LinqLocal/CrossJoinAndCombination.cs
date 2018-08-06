using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLocal
{
    public class CrossJoinAndCombination
    {
        public void Execute()
        {
            var query = CombinationsOnSingleCollection();
            foreach (var combination in query)
            {
                Console.WriteLine(combination);
            }

        }

        public string[] CrossJoin()
        {
            string[] letters = { "a", "b" }; int[] numbers = { 1, 2, 3 };
            IEnumerable<string> query = from n in numbers
                                        from l in letters
                                        select n.ToString() + l;
            return query.ToArray();
        }

        public string[] CombinationsOnSingleCollection()
        {
            string[] players = { "Wojtek", "Tomek", "Maria", "Janusz" };
            IEnumerable<string> query = from playerOne in players
                                        from playerTwo in players
                                        where playerOne.CompareTo(playerTwo) < 0 // smart exclusion of duplicate pairs uses position in collection to consider following names
                                        select playerOne + " vs " + playerTwo;

            return query.ToArray();
        }
    }
}

