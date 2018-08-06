using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SpinLockSpinWait
{
    public class Program
    {
        static void Main(string[] args)
        {
            var t1 = new Thread(() => SpinLocker.SpinLockThread(() => { FakeOperationPerformer.MakeMassiveConsoleWrite(1000, "x", 1); }));
            var t2 = new Thread(() => SpinLocker.SpinLockThread(() => { FakeOperationPerformer.MakeMassiveConsoleWrite(1000, "y", 1); }));

            t1.Start();
            t2.Start();
            Thread.Join(t1);

            Console.ReadLine();
        }
    }
}
