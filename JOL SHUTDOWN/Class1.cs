using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace JOL_SHUTDOWN
{
    class Class1
    {

        public delegate void TimerCompleteDelegate();

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern IntPtr CreateWaitableTimer(IntPtr lpTimerAttributes, bool bManualReset, string lpTimerName);

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool SetWaitableTimer(IntPtr hTimer, [In] ref long pDueTime, int lPeriod, TimerCompleteDelegate pfnCompletionRoutine, IntPtr pArgToCompletionRoutine, bool fResume);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool CancelWaitableTimer(IntPtr hTimer);


        public static IntPtr SetWakeAt(DateTime dt)
        {
            TimerCompleteDelegate timerComplete = null;

            // read the manual for SetWaitableTimer to understand how this number is interpreted.
            long interval = dt.ToFileTimeUtc();
            IntPtr handle = CreateWaitableTimer(IntPtr.Zero, true, "WaitableTimer");
            SetWaitableTimer(handle, ref interval, 0, timerComplete, IntPtr.Zero, true);
            return handle;
        }


        [DllImport("powrprof.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool SetSuspendState(bool hibernate, bool forceCritical, bool disableWakeEvent);

        public static bool Hibernate()
        {
            return SetSuspendState(true, false, false);
        }

        public static bool Sleep()
        {
            return SetSuspendState(false, false, false);
        }

        public static bool EnableHibernate()
        {
            Process p = new Process();
            p.StartInfo.FileName = "powercfg.exe";
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            p.StartInfo.Arguments = "/hibernate on"; // this might be different in other locales
            return p.Start();
        }


    }
}
