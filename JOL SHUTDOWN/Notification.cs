using JOL_SHUTDOWN.settingsControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JOL_SHUTDOWN
{
    public class Notification
    {
        Form1 fm;
        public Notification(Form1 f)
        {
            fm = f;
            loadTimer();
        }

        void loadTimer()
        {
            tm = new Timer();
            tm.Interval = 1000 * Settings1.Default.NotificationSeconds;
            tm.Tick += new EventHandler(tm_Tick);
            //tm.Enabled = true;
        }

        void tm_Tick(object sender, EventArgs e)
        {
            //MessageBox.Show("here");
            hideNotification();
            tm.Stop();
        }
        Timer tm;
        public void Show(string text)
        {
            try
            {
                tm.Interval = 1000 * Settings1.Default.NotificationSeconds;
            }
            catch { tm.Interval = 3000; }
            fm.NotificationLabel.Text = text;
            showNotification();
            tm.Start();
        }

        private void showNotification()
        {
            fm.notificationPanel.Visible = true;
        }
        private void hideNotification()
        {
            fm.notificationPanel.Visible = false;
        }

    }
}
