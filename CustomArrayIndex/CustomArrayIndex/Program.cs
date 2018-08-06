using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomArrayIndex
{
    public class Program
    {
        static void Main(string[] args)
        {
            var haha = new Sentence()[2, "razy"];
        }

        public class Sentence
        {
            string[] words = "Nosił wilk razy kilka".Split();

            public string this [int wordNum, string word]
            {
                get { return words[wordNum] == word ? words[wordNum] : null; }
                set { words[wordNum] = value; }
            }

            public string GetTheWord(int wordNum, string word)
            {
                return words[wordNum];
            }
        }
    }
}
