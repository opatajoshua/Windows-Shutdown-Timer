using JOL_SHUTDOWN.settingsControls;
using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JOL_SHUTDOWN
{
    class WakeUP
    {
        [DllImport("kernel32.dll")]
        public static extern SafeWaitHandle CreateWaitableTimer(IntPtr lpTimerAttributes, bool bManualReset, string lpTimerName);

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetWaitableTimer(SafeWaitHandle hTimer, [In] ref long pDueTime, int lPeriod, IntPtr pfnCompletionRoutine, IntPtr lpArgToCompletionRoutine, bool fResume);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool CancelWaitableTimer(SafeWaitHandle hTimer);

        public static event EventHandler Woken;

        public static BackgroundWorker bgWorker = new BackgroundWorker();

        static SafeWaitHandle handle1;
        static WakeUP wakeUp;


        AlertMessage am;
        static void WakeUP_Woken(object sender, EventArgs e)
        {
           // MessageBox.Show(Settings1.Default.wokenMessage," Wake up time: "+DateTime.Now.ToString());
        }
        public static void SetWakeUpTime(DateTime time)
        {
            
            wakeUp = new WakeUP();
            bgWorker.DoWork += new DoWorkEventHandler(bgWorker_DoWork);
            bgWorker.RunWorkerCompleted +=
              new RunWorkerCompletedEventHandler(bgWorker_RunWorkerCompleted);
            Woken += WakeUP_Woken;
            bgWorker.RunWorkerAsync(time.ToFileTime());
        }

        public static void CancelWakeUp()
        {
            if(CancelWaitableTimer(handle1))
            {

            }
            else
            {
                throw new Win32Exception(Marshal.GetLastWin32Error());
            }
        }
        public static void bgWorker_RunWorkerCompleted(object sender, 
                      RunWorkerCompletedEventArgs e)
        {
            if (Woken != null)
            {
                Woken(wakeUp, new EventArgs());
            }
        }

        public static void bgWorker_DoWork(object sender, DoWorkEventArgs e) 
        {
            long waketime = (long)e.Argument;

            using (SafeWaitHandle handle = 
                      CreateWaitableTimer(IntPtr.Zero, true,
                      wakeUp.GetType().Assembly.GetName().Name.ToString() + "Timer"))
            {
                if (SetWaitableTimer(handle, ref waketime, 0, 
                                       IntPtr.Zero, IntPtr.Zero, true))
                {
                    using (EventWaitHandle wh = new EventWaitHandle(false, 
                                                           EventResetMode.AutoReset))
                    {
                        wh.SafeWaitHandle = handle;
                        wh.WaitOne();
                        handle1 = handle;
                    }
                }
                else
                {
                    throw new Win32Exception(Marshal.GetLastWin32Error());
                }
            }
        }

    }
}
