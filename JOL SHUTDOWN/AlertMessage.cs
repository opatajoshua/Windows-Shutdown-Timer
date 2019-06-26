
using JOL_SHUTDOWN.Properties;
using JOL_SHUTDOWN.settingsControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JOL_SHUTDOWN
{
    public partial class AlertMessage : Form
    {
        WMPLib.WindowsMediaPlayer axWindowsMediaPlayer1 = new WMPLib.WindowsMediaPlayer();
        CountTimerControl timerCon;
        public AlertMessage(CountTimerControl ctc)
        {
            
            InitializeComponent();
            this.Tag = "null";
            timerCon = ctc;
            message();
            sound();
        }

        Settings1 sett = Settings1.Default;

        #region Drag form
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        #endregion

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.close();
            axWindowsMediaPlayer1.controls.stop();
        }
        Settings1 set = Settings1.Default;
        void sound()
        {
            if(set.playAlertSong)
            {
                btnStop.Visible = true;
                string url = sett.alertSongLocation;
                if (url == "Default")
                {
                    //MessageBox.Show("here");
                    axWindowsMediaPlayer1.URL = "files/unknown_artist-bells.mp3";
                }
                else
                axWindowsMediaPlayer1.URL = sett.alertSongLocation;
            }
        }

        void message()
        {
            if(set.showAlertMessage)
            {
                lbMessage.Text = set.alertMessage;
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            this.Tag = "stop";
            axWindowsMediaPlayer1.controls.stop();
        }

        private void noFocusButton1_Click(object sender, EventArgs e)
        {
            this.Tag = "abort";
            timerCon.Stop();
            this.Close();
            axWindowsMediaPlayer1.controls.stop();
        }

        internal void close()
        {
            this.Close();
            axWindowsMediaPlayer1.controls.stop();
        }
    }
}
