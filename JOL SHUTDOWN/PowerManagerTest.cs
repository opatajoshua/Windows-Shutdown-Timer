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
    class PowerManagerTest
    {
        public PowerManagerTest()
        {

        }

        [DllImport("user32", SetLastError = true)]
        public static extern bool LockWorkStation(); // For Lock
        [DllImport("user32")]
        public static extern bool ExitWindowsEx(uint Flag, uint Reason); //For signout

        [DllImport("PowrProf.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        public static extern bool SetSuspendState(bool hiberate, bool forceCritical, bool disableWakeEvent);

        static IntPtr handle;
     
        public bool Lock()
        {
            try
            {
                LockWorkStation();
                bool result = LockWorkStation();
                if (result == false)
                {
                    // An error occured
                    throw new Win32Exception(Marshal.GetLastWin32Error());
                }
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool SignOut()
        {
            try
            {
                ExitWindowsEx(0, 0); // Or ExecuteCommand("shutdown", "/l");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool Sleep()
        {
            try
            {
                SetSuspendState(false, true, true);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool Hibernate()
        {
            try
            {
                ExecuteCommand("shutdown", "/h"); // Or SetSuspendState(true, true, true);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public bool ShutDownNormal()
        {
            try
            {
                ExecuteCommand("shutdown", "/s");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool ShutDownForcibly()
        {
            try
            {
                ExecuteCommand("shutdown", "/s /f");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool Restart()
        {
            try
            {
                ExecuteCommand("shutdown", "/r");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool CancelShutdown()
        {
            try
            {
                ExecuteCommand("shutdown", "/a");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool ExecuteCommand(string FileName, string Arguments)
        {
            try
            {
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                startInfo.FileName = FileName;
                startInfo.Arguments = Arguments;
                process.StartInfo = startInfo;
                process.Start();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
