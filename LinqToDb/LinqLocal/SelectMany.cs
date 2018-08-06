using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLocal
{
    public class SelectMany
    {
        public void Execute()
        {
            string[] fullNames = { "Robert Siwiak", "Mirosława Michalina Włodarczyk", "Mariusz Romańczyk" };

            var words = FluentWithTwoVariablesAttempt(fullNames);

            foreach (var word in words)
            {
                Console.WriteLine(word + "|");
            }
        }

        public IEnumerable<string> QueryLinq(string[] fullNames)
        {
            return fullNames.SelectMany(x => x.Split());
        }

        public IEnumerable<string> FluentLinq(string[] fullNames)
        {
            return from fname in fullNames from name in fname.Split() select name;
        }

        public IEnumerable<string> QueryWithTwoVariables(string[] fullNames)
        {
            return from fullName in fullNames
                   from name in fullName.Split()
                   orderby fullName, name
                   select name + " pochodzi z " + fullName;
        }

        public IEnumerable<string> FluentWithTwoVariables(string[] fullNames)
        {
            return fullNames.SelectMany(x => x.Split().Select(y => new { fname = x, name = y }).OrderBy(z => z.fname).ThenBy(z => z.name).Select(z => z.name + " pochodzi z " + z.fname));
        }

        public IEnumerable<string> FluentWithTwoVariablesAttempt(string[] fullNames)
        {
            return fullNames.SelectMany(x => x.Split().Select(y => x + " pochodzi z " + y));
        }
    }
}
