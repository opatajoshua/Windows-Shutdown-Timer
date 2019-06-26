using JOL_SHUTDOWN.settingsControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JOL_SHUTDOWN
{
    public partial class Form1 : Form
    {

        #region instantiateTimers
        public CountUp countUp1;
        public CountDown countDown1;
        public SchedulePanel schedulePanel1;
        void InitializeTimers()
        {
            this.countUp1 = new JOL_SHUTDOWN.CountUp();
            this.countDown1 = new JOL_SHUTDOWN.CountDown();
            this.schedulePanel1 = new JOL_SHUTDOWN.SchedulePanel();

            this.panel1.Controls.Add(this.countUp1);
            this.panel1.Controls.Add(this.countDown1);
            this.panel1.Controls.Add(this.schedulePanel1);

            // countUp1
            // 
            this.countUp1.AutoSize = true;
            this.countUp1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.countUp1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.countUp1.Location = new System.Drawing.Point(0, 0);
            this.countUp1.lockMode = false;
            this.countUp1.Name = "countUp1";
            this.countUp1.Size = new System.Drawing.Size(779, 318);
            this.countUp1.TabIndex = 0;
            // 
            // countDown1
            // 
            this.countDown1.AutoSize = true;
            this.countDown1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.countDown1.Location = new System.Drawing.Point(0, 0);
            this.countDown1.lockMode = false;
            this.countDown1.Name = "countDown1";
            this.countDown1.Size = new System.Drawing.Size(779, 318);
            this.countDown1.TabIndex = 2;
            // 
            // S
            // 
            this.schedulePanel1.AutoSize = true;
            this.schedulePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.schedulePanel1.Location = new System.Drawing.Point(0, 0);
            this.schedulePanel1.lockMode = false;
            this.schedulePanel1.Name = "schedulePanel1";
            this.schedulePanel1.Size = new System.Drawing.Size(779, 318);
            this.schedulePanel1.TabIndex = 2;
            // 
        }
        #endregion
        public Form1()
        {
            InitializeComponent();
            InitializeTimers();
            countUp1.BringToFront();
            tmCurTimer.Start();
            ActiveCounter = new CountTimerControl("cu",this);
            visibleUControl = new CountTimerControl("cu", this);
            visibleCounter = new CountTimerControl("cu", this);
            
            notification = new Notification(this);
            countDown1.notification = notification;
            countUp1.notification = notification;
            schedulePanel1.notification = notification;
            countDown1.form1 = this;
            countUp1.form1 = this;
            schedulePanel1.form1 = this;
            settingsPanel1.GeneralSettings1.notification = notification;

            if (Settings1.Default.AskForPass == true)
            {
                LockApp();
            }
            
        }

        public Notification notification;
        CountTimerControl ActiveCounter;
        CountTimerControl visibleUControl; ///the visible user control
        CountTimerControl visibleCounter; /// the visible counter
        int checkTimerSpeed = 0;
        Color Color_original = Properties.Settings.Default.Color_original;
        Color Color_timeUp = Properties.Settings.Default.Color_timeUp;

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

        private void btnCountUp_Click(object sender, EventArgs e)
        {
            //btnCountUp.Enabled = false;
            //btnCountDown.Enabled = true;
            menuBtnChange(btnCountUp);
            countUp1.BringToFront();
            //ActiveCounter.setControl("cu",this);
            visibleUControl.setControl("cu", this);
            visibleCounter.setControl("cu", this);
        }

        private void btnCountDown_Click(object sender, EventArgs e)
        {
            //btnCountUp.Enabled = true;
            //btnCountDown.Enabled = false;
            menuBtnChange(btnCountDown);
            countDown1.BringToFront();
            //ActiveCounter.setControl("cd", this);
            visibleUControl.setControl("cd", this);
            visibleCounter.setControl("cd", this);
        }

        void menuBtnChange(Button btn)
        {
            foreach (Button b in menuBtnPanel.Controls)
            {
                if (b != btn)
                {
                    b.BackColor = Color.FromArgb(29, 29, 29);
                }
            }
            btn.BackColor = Color.FromArgb(0, 94, 94);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            menuBtnChange(btnSettings);
            settingsPanel1.BringToFront();
            visibleUControl.setControl("set", this);
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            menuBtnChange(btnSchedule);
            schedulePanel1.BringToFront();
            visibleUControl.setControl("sch", this);
        }

        private void tmCurTimer_Tick(object sender, EventArgs e)
        {
            checkTimerSpeed += 1;
            
            Properties.Settings sett  = Properties.Settings.Default;
            Button btnActiveCounterButton = ActiveCounter.button;
            Button CurrentActiveMainButton = visibleUControl.button;
            if(sett.currentCounter =="cu")
            {
                ActiveCounter.setControl("cu",this);
                btnActiveCounterButton = btnCountUp;
            }
            else if (sett.currentCounter == "cd")
            {
                ActiveCounter.setControl("cd", this);
                btnActiveCounterButton = btnCountDown;
            }


            if (sett.currentCounter != "null")
            {
                if (CurrentActiveMainButton != btnActiveCounterButton)
                {
                    if (checkTimerSpeed % 2 == 0)
                        btnActiveCounterButton.ForeColor = Color.Gainsboro;
                    else btnActiveCounterButton.ForeColor = Color_timeUp;
                }
                else
                {
                    btnActiveCounterButton.ForeColor = Color.Gainsboro;
                }
            }
            else
            {
                try 
                {
                    btnActiveCounterButton.ForeColor = Color.Gainsboro;
                }
                catch
                {

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            notificationPanel.Visible = true;
        }

        private void btnLock_Click(object sender, EventArgs e)
        {
            LockApp();
        }

        private void LockApp()
        {
            string cct = Properties.Settings.Default.currentCounter;
            if (cct == "null")
            {
                lockHolder.Controls.Clear();
                visibleCounter.lockMode = true;
                lockHolder.Controls.Add(visibleCounter.control);
            }
            else
            {
                ActiveCounter.lockMode = true;
                lockHolder.Controls.Add(ActiveCounter.control);
            }
            LockPanel.BringToFront();
            txtLockPass.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void minToTray()
        {
            //if (this.WindowState == FormWindowState.Minimized)
            //{
                this.WindowState = FormWindowState.Minimized;
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(3000);
                this.ShowInTaskbar = false;
            //}
            //this.Close();
        }

        private void btnMinToTray_Click(object sender, EventArgs e)
        {
            minToTray();
        }
        byte[] pdata;
        private void txtLockPass_TextChanged(object sender, EventArgs e)
        {
            String hash = getHash(txtLockPass.Text);
            if (Properties.Settings.Default.isDefaultPass == true)
            {
                if (hash == getHash("unlock"))
                {
                    txtLockPass.Text = "";
                    LockPanel.SendToBack();
                    unLockControl();
                }
            }
            else
            {
                if (hash == Properties.Settings.Default.pass)
                {
                    txtLockPass.Text = "";
                    LockPanel.SendToBack();
                    unLockControl();
                }
            }
            
        }

        private static string getHash(string newPass)
        {
            byte[] data = System.Text.Encoding.ASCII.GetBytes(newPass);
            data = new System.Security.Cryptography.SHA256Managed().ComputeHash(data);
            String hash = System.Text.Encoding.ASCII.GetString(data);
            return hash;
        }
        void unLockControl()
        {
            string cct = Properties.Settings.Default.currentCounter;
            if (cct == "null")
            {
                visibleCounter.lockMode = false;
                panel1.Controls.Add(visibleCounter.control);
                visibleUControl.control.BringToFront();
            }
            else
            {
                //lockHolder.Controls.Clear();
                ActiveCounter.lockMode = false;
                panel1.Controls.Add(ActiveCounter.control);
                ActiveCounter.control.BringToFront();
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Show();                                //A form is displayed
            this.WindowState = FormWindowState.Normal;  //Form state default size
            //this.Activate();
            this.ShowInTaskbar = true;
            notifyIcon1.Visible = false;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Show();                                //A form is displayed
            
            //this.Activate();
            this.btnSettings_Click(sender,e);
            this.settingsPanel1.btnAbout_Click(sender,e);
            this.WindowState = FormWindowState.Normal;  //Form state default size
            this.ShowInTaskbar = true;
            notifyIcon1.Visible = false;
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //this.Show();                                //A form is displayed
            this.ShowInTaskbar = true;
            this.WindowState = FormWindowState.Normal;  //Form state default size
            //this.Activate();
            //this.ShowInTaskbar = true;
            notifyIcon1.Visible = false;
        }
    }
}
