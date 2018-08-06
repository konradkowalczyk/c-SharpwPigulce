using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunkyOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            Attr();
        }

        public static void Attr()
        {
            //string filePath = @"E:\temp\temp.txt";
            //FileAttributes fa = File.GetAttributes(filePath);

            //if ((fa & FileAttributes.ReadOnly) != 0)
            //{
            //    fa ^= FileAttributes.ReadOnly;
            //    File.SetAttributes(filePath, fa);
            //}

            //File.Delete(filePath);


            var number = 128;

            number ^= 32;
        }
    }
}
