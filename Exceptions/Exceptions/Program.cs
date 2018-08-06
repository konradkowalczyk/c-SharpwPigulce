using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Display(null);
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
            finally
            {
                Console.ReadKey();
            }
        }

        static void Display(string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            Console.WriteLine(name);
        }
    }
}
