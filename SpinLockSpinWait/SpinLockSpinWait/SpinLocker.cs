using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SpinLockSpinWait
{
    public static class SpinLocker
    {
        public static void SpinLockThread(Action workToDo)
        {
            var spinLock = new SpinLock();
            var lockTaken = false;
            try
            {
                spinLock.Enter(ref lockTaken);
                workToDo.Invoke();
            }
            finally
            {
                if (lockTaken)
                {
                    spinLock.Exit();
                }
            }
        }
    }
}
