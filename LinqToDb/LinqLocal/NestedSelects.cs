using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLocal
{
    public class NestedSelects
    {
        public void Execute()
        {
            var dirs = new DirectoryInfo(@"D:\").GetDirectories();

            var query = from d in dirs
                        where (d.Attributes & FileAttributes.System) == 0
                        select new
                        {
                            DirectoryName = d.Name,
                            Created = d.CreationTime,

                            Files = from f in d.GetFiles() where (f.Attributes & FileAttributes.Hidden) == 0 select new { Name = f.Name, f.Length }
                        };

            foreach (var dirFiles in query)
            {
                Console.WriteLine(Environment.NewLine + "W katalogu " + dirFiles.DirectoryName + " utworzonym w " + dirFiles.Created + " znajdują się pliki:");
                foreach (var file in dirFiles.Files)
                {
                    Console.WriteLine(file.Name + " o rozmiarze " + file.Length); 
                }
            }

            Console.ReadKey();
        }
    }
}
