using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SpinLockSpinWait
{
    public static class FakeOperationPerformer
    {
        public static void MakeMassiveConsoleWrite(int numberOfIterations, string stringToPrint, int waitTime)
        {
            
            for (int i = 0; i < numberOfIterations; i++)
            {
               
                Console.Write(stringToPrint);
            }
        }
    }
}
