using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using jcontrols;
using SuperContextMenu;
using JOL_SHUTDOWN.controls;
using JOL_SHUTDOWN.settingsControls;

namespace JOL_SHUTDOWN
{
    public partial class CountDown : UserControl
    {
        PoperContainer PLPPoperContainer1;
        PowerListPanel PowerListPanel1;

        public Notification notification;
        public Form1 form1;
        AlertMessage am;
        public CountDown()
        {
            //this.DoubleBuffered = true;
            InitializeComponent();
            PLPPoperContainer1 = new PoperContainer();
            PowerListPanel1 = new PowerListPanel();
            PLPPoperContainer1.PopedControl = PowerListPanel1;

            tmCurTimer.Start();
            domTT.Text = "AM";
            domTTWU.Text = "AM";
            lbStatus.Text = "not set";
            circularPBar_cust1.Value = 0;
            cmbWakeupStatus.SelectedIndex = 1;
            cmbFormat.Text = Properties.Settings.Default.CUformat.ToString();
            
            powerEvents();
        }

        #region power Events
        private void powerEvents()
        {
            PowerListPanel1.Alert.Click += Alert_Click;
            PowerListPanel1.Lock.Click += Lock_Click;
            PowerListPanel1.SignOut.Click += SignOut_Click;
            PowerListPanel1.Restart.Click += Restart_Click;
            PowerListPanel1.ShutDownForcibly.Click += ShutDownForcibly_Click;
            PowerListPanel1.ShutDownNormal.Click += ShutDownNormal_Click;
            PowerListPanel1.Hibernate.Click += Hibernate_Click;
            PowerListPanel1.Sleep.Click += Sleep_Click;
        }
        void Alert_Click(object sender, EventArgs e)
        {
            btnPower.Text = "Alert";
            selectedPower = alert;
            PLPPoperContainer1.Hide();
            btnPower.Size = new System.Drawing.Size();
            pnlWakeup.Enabled = false;
        }
        void Lock_Click(object sender, EventArgs e)
        {
            btnPower.Text = "Lock";
            selectedPower = lockpc;
            PLPPoperContainer1.Hide();
            btnPower.Size = new System.Drawing.Size();
            pnlWakeup.Enabled = false;
        }
        void SignOut_Click(object sender, EventArgs e)
        {
            btnPower.Text = "Sign Out";
            selectedPower = signout;
            PLPPoperContainer1.Hide();
            btnPower.Size = new System.Drawing.Size();
            pnlWakeup.Enabled = false;
        }
        void Sleep_Click(object sender, EventArgs e)
        {
            btnPower.Text = "Sleep";
            selectedPower = sleep;
            PLPPoperContainer1.Hide();
            btnPower.Size = new System.Drawing.Size();
            pnlWakeup.Enabled = true;
        }

        void Hibernate_Click(object sender, EventArgs e)
        {
            btnPower.Text = "Hibernate";
            selectedPower = hibernate;
            PLPPoperContainer1.Hide();
            btnPower.Size = new System.Drawing.Size();
            pnlWakeup.Enabled = true;
        }

        void ShutDownNormal_Click(object sender, EventArgs e)
        {
            btnPower.Text = "Normal Shutdown";
            selectedPower = shutdownNormal;
            PLPPoperContainer1.Hide();
            btnPower.Size = new System.Drawing.Size();
            pnlWakeup.Enabled = false;
        }

        void ShutDownForcibly_Click(object sender, EventArgs e)
        {
            btnPower.Text = "Force Shutdown";
            selectedPower = shutdownForcibly;
            PLPPoperContainer1.Hide();
            btnPower.Size = new System.Drawing.Size();
            pnlWakeup.Enabled = false;
        }

        void Restart_Click(object sender, EventArgs e)
        {
            btnPower.Text = "Restart";
            selectedPower = restart;
            PLPPoperContainer1.Hide();
            btnPower.Size = new System.Drawing.Size();
            pnlWakeup.Enabled = false;
        }
        #endregion

        DateTime setTimeRemaining; // the time remaining to shutdown
        DateTime setTime;
        bool isStart = false; //set to True is user starts the timer and false if user pauses or stops the timer
        bool isComplete = false; //set to True is timer ends and false if timer starts
        DateTime timeStarted; // the time at which the start operation occurs
        string timeFormat = "hh:mm:ss"; //specify the format to display (12 hrs by default)
        delegate bool powerDel();
        powerDel runPower;

        #region wakeup
        int _wakeupIndex = 0;
        int _wakeupPreSet = 1;
        int wakeupNull = 0;
        int wakeupNotSet = 1;
        int wakeupOn = 2;
        int wakeupOff = 3;
        DateTime _WakeupTime; //time set for wakeup
        CountTimerControl CountDownCountTimerControl;

        int wakeupIndex
        {
            get { return _wakeupIndex; }
            set
            {
                _wakeupIndex = value;
                if(_wakeupIndex == wakeupNull)
                {
                    lbWakeStatus.Visible = false;
                }
                if(_wakeupIndex == wakeupNotSet)
                {
                    lbWakeStatus.Text = "NOT SET";
                    lbWakeStatus.Visible = true;
                }
                if (_wakeupIndex == wakeupOn)
                {
                    if (currentPower == hibernate || currentPower == sleep)
                    {
                        lbWakeStatus.Text = WakeupTime.ToString(timeFormat + " tt");
                        lbWakeStatus.Visible = true;
                    }
                }
                if (_wakeupIndex == wakeupOff)
                {
                    if (currentPower == hibernate || currentPower == sleep)
                    {
                        lbWakeStatus.Text = "OFF";
                        lbWakeStatus.Visible = true;
                    }
                }
            }
        }
        int wakeupPreSet
        {
            get { return _wakeupPreSet; }
            set
            {
                _wakeupPreSet = value;
            }
        }
        DateTime WakeupTime
        {
            get { return _WakeupTime; }
            set
            {
                _WakeupTime = value;
            }
        }
        #endregion

        int selectedPower = 0;
        int currentPower = 0;
        int alert = 0;
        int lockpc = 1;
        int signout = 2;
        int sleep = 3;
        int hibernate = 4;
        int shutdownNormal = 5;
        int shutdownForcibly = 6;
        int restart = 7;

        Color Color_original = Properties.Settings.Default.Color_original;
        Color Color_timeUp = Properties.Settings.Default.Color_timeUp;

        /// </summary>

        /// <summary statuses>
        /// not set
        /// started
        /// paused
        /// stoped
        /// </summary>

        
        PowerManagerTest PowerManager1 = new PowerManagerTest();// remove Test from PowerManager to perform main operations

        private void btnSetTime_Click(object sender, EventArgs e)
        {
            if (isSetValid())
            {
                try
                {
                    setTimeRemaining = getSetTime();
                    setTime = setTimeRemaining;
                    lbShuTime.Text = setTimeRemaining.ToString(timeFormat);
                    lbShuTT.Text = setTimeRemaining.ToString("tt");

                    if (isWakeupble())
                    {
                        WakeupTime = getWakeupTime();
                        wakeupIndex = wakeupOn;
                        wakeupPreSet = wakeupOn;
                    }

                    panel1.Visible = true;
                    pnlSet.Visible = false;
                }
                catch (Exception ex)
                {
                    notification.Show(ex.Message);
                }

                formatChanged();

                powerTypeChanged();
            }
        }

        bool isWakeupble()
        {
            if (selectedPower == sleep || selectedPower == hibernate)
            {
                if (cmbWakeupStatus.SelectedIndex == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        private void powerTypeChanged()
        {
            //powerIndex = 0; // comment this
            if (selectedPower == alert)
            {
                lbPowerType.Text = "Alert";
                runPower = this.Alert;
                currentPower = alert;
                pnlWakeup.Enabled = false;
                wakeupIndex = wakeupNull;
            }
            else if(selectedPower == lockpc)
            {
                lbPowerType.Text = "Lock";
                runPower = PowerManager1.Lock;
                currentPower = lockpc;
                pnlWakeup.Enabled = false;
                wakeupIndex = wakeupNull;
            }
            else if (selectedPower == signout)
            {
                lbPowerType.Text = "Sign Out";
                runPower = PowerManager1.SignOut;
                currentPower = signout;
                pnlWakeup.Enabled = false;
                wakeupIndex = wakeupNull;
            }
            else if (selectedPower == sleep)
            {
                lbPowerType.Text = "Sleep";
                runPower = PowerManager1.Sleep;
                currentPower = sleep;
                pnlWakeup.Enabled = true;
                lbWakeStatus.Visible = true;
                if (cmbWakeupStatus.SelectedIndex == 0)
                {
                    if (wakeupPreSet == wakeupOff)
                    {
                        wakeupIndex = wakeupNotSet;
                    }
                    else
                        wakeupIndex = wakeupPreSet;
                }
                else
                {
                    wakeupIndex = wakeupOff;/////////
                }
            }
            else if (selectedPower == hibernate)
            {
                lbPowerType.Text = "Hibernate";
                runPower = PowerManager1.Hibernate;
                currentPower = hibernate;
                pnlWakeup.Enabled = true;
                lbWakeStatus.Visible = true;
                if (cmbWakeupStatus.SelectedIndex == 0)
                {
                    if (wakeupPreSet == wakeupOff)
                    {
                        wakeupIndex = wakeupNotSet;
                    }
                    else
                        wakeupIndex = wakeupPreSet;
                }
                else
                {
                    wakeupIndex = wakeupOff;/////////
                }
            }
            else if (selectedPower == shutdownNormal)
            {
                lbPowerType.Text = "Normal Shutdown";
                runPower = PowerManager1.ShutDownNormal;
                currentPower = shutdownNormal;
                pnlWakeup.Enabled = false;
                wakeupIndex = wakeupNull;
            }
            else if (selectedPower == shutdownForcibly)
            {
                lbPowerType.Text = "Force Shutdown";
                runPower = PowerManager1.ShutDownForcibly;
                currentPower = shutdownForcibly;
                pnlWakeup.Enabled = false;
                wakeupIndex = wakeupNull;
            }
            else if (selectedPower == restart)
            {
                lbPowerType.Text = "Restart";
                runPower = PowerManager1.Restart;
                currentPower = restart;
                pnlWakeup.Enabled = false;
                wakeupIndex = wakeupNull;
            }
            else
            {
                runPower = nullPower;
                currentPower = 0;
                notification.Show("Null power selected");
            }
            
        }

        private bool Alert()
        {
            notification.Show("Alert time is up");
            am = new AlertMessage(CountDownCountTimerControl);
            am.btnAbort.Visible = false;
            am.lbMessage.Text = "Alert time elapsed";
            am.ShowDialog();
            return true;
        }
        private bool nullPower()
        {
            notification.Show("Null power");
            return true;
            //throw new NotImplementedException();
        }

        public bool Start() // handles the start operation
        {
            if (lbStatus.Text != "started")
            {
                string currCounter = Properties.Settings.Default.currentCounter;
                if (currCounter == "null" || (lbStatus.Text == "paused" && currCounter == "cd"))
                {

                    try
                    {
                        timeStarted = DateTime.Now;
                        Convert.ToDateTime(lbShuTime.Text);
                        lbStartTime.Text = timeStarted.ToString("hh:mm:ss tt");
                        isStart = true;
                        isComplete = false;
                        lbStatus.Text = "started";
                        lbStatus.ForeColor = Color_original;
                        Properties.Settings.Default.currentCounter = "cd";
                        return true;
                    }
                    catch
                    {
                        notification.Show("Click set to set time");
                        return false;
                    }


                }
                else
                {
                    if (currCounter == "cu")
                    {
                        notification.Show("Count Up timer has already been started");
                    }
                    else if (currCounter == "cd")
                    {
                        notification.Show("Count Dowm timer has already been started");
                    }
                    else
                    {
                        notification.Show("a shutdown timer has already been started");
                    }
                    return false;
                }
            }
            return false;
        }

        public bool Pause()// handles the pause operation
        {
            if (lbStatus.Text == "started" && lbStatus.Text != "not set")
            {
                try
                {
                    Convert.ToDateTime(lbShuTime.Text);
                    isStart = false;
                    lbStatus.Text = "paused";
                    return true;
                }
                catch
                {
                    notification.Show("Click set to set time");
                    return false;
                }
            }
            return false;
            
        }

        public bool Stop() // handles the stop operation
        {
            if (lbStatus.Text != "stopped" && lbStatus.Text != "not set")
            {
                try
                {
                    Convert.ToDateTime(lbShuTime.Text);
                    isStart = false;
                    circularPBar_cust1.Value = 0;
                    lbShuTime.Text = "Not Set";
                    lbStatus.Text = "stopped";
                    lbStartTime.Text = "00:00:00";
                    lbTimeInterval.Text = "00:00:00";
                    lbTimeRemaining.Text = "00:00:00";
                    lbStatus.ForeColor = Color_original;
                    Properties.Settings.Default.currentCounter = "null";
                    PowerManager1.CancelShutdown();
                    return true;
                }
                catch
                {
                    notification.Show("Click set to set time");
                    return false;
                }
            }
            return false;
        }

        public bool Complete() // handles the stop operation
        {
            //if (lbStatus.Text != "stopped" && lbStatus.Text != "not set")
            //{
                try
                {
                    isStart = false;
                    //circularPBar_cust1.Value = 0;
                    lbShuTime.Text = "Not Set";
                    lbStatus.Text = "completed";
                    lbStartTime.Text = "00:00:00";
                    lbStatus.ForeColor = Color_original;
                    Properties.Settings.Default.currentCounter = "null";
                    try
                    {
                        if (am != null)
                        {
                            am.close();
                        }
                    }
                    catch { }
                    return true;
                }
                catch
                {
                    notification.Show("Click set to set time");
                    return false;
                }
            //}
            //return false;
        }

        public bool Set() // handles the set operation
        {
            if (panel1.Visible == true)
            {
                panel1.Visible = false;
                panel3.Visible = true;
            }
            else
            {
                panel1.Visible = true;
                panel3.Visible = false;
            }
            return true;
        }

        bool isSetValid() //validates set inputs
        {
            if(btnPower.Text == "")
            {
                notification.Show("Select Power type");
                return false;
            }

            return true;
        }

        private DateTime getSetTime()
        {
            string ST = "NOT SET";
            //if (cmbFormat.SelectedItem == "12")
            //{
            //    ST = numHour.Value.ToString() + ":" + numMin.Value.ToString() + ":" + numSec.Value.ToString() + " " + domTT.Text.ToString();
            //}
            //if (cmbFormat.SelectedItem == "24")
            //{
                ST = numHour.Value.ToString() + ":" + numMin.Value.ToString() + ":" + numSec.Value.ToString();
            //}
            return Convert.ToDateTime(ST);
        }

        DateTime cdt;
        int checkTimerSpeed = 0;
        private void tmCurTimer_Tick(object sender, EventArgs e)
        {
            lbCurTT.Text = DateTime.Now.ToString("tt");
            checkTimerSpeed += 1;
            //label2.Text = checkTimerSpeed.ToString();classify = (input > 0) ? "positive" : "negative";
            
            
            lbCurTime.Text = DateTime.Now.ToString(timeFormat);
            lbSetCurTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
            
            if(isStart)
            {
               // TimeSpan ts = SetTime - DateTime.Now;
                setTimeRemaining = setTimeRemaining.AddSeconds(-1);
                TimeSpan ts = setTimeRemaining.TimeOfDay;
                int secsRem = Convert.ToInt32(ts.TotalSeconds);
                secsRem = (secsRem > -1) ? secsRem : (secsRem + 86400);
                TimeSpan d2t = TimeSpan.FromSeconds(secsRem);
                setCircleProgress();
                lbShuTime.Text = d2t.ToString();
                lbTimeRemaining.Text = d2t.ToString();
                //if (n.Hour == s.Hour && n.Minute == s.Minute && n.Second == s.Second && n.ToString("tt") == s.ToString("tt"))
                if (secsRem <= 0)
                {
                    isComplete = true;
                    isStart = false;
                    Complete();
                    lbStatus.ForeColor = Color_original;
                    circularPBar_cust1.Value = 100;
                    setWakeUp();
                    if (runPower()) { }
                    else
                    {
                        notification.Show("Unable to perform '"+lbPowerType.Text+"' operation");
                    }
                }
            }
        }

        private void setCircleProgress()
        {
            if(!isComplete && isStart)
            {
                try
                {

                    //TimeSpan ts = setTimeRemaining - DateTime.Now;
                    //TimeSpan ts2 = setTimeRemaining - timeStarted;

                    double secsRem = Convert.ToInt32(setTimeRemaining.TimeOfDay.TotalSeconds);
                    //secsRem = (secsRem > -1) ? secsRem : (secsRem + 86400);
                    double secsSet = Convert.ToInt32(setTime.TimeOfDay.TotalSeconds);
                    //secsSet = (secsSet > -1) ? secsSet : (secsSet + 86400);
                    TimeSpan d2t = TimeSpan.FromSeconds(secsSet);
                    lbTimeInterval.Text = d2t.ToString();
                    double sub = secsSet - secsRem;
                    double div = sub / secsSet;
                    double value = div * 100;
                    label11.Text = secsRem.ToString() + " / " + secsSet.ToString();

                    label6.Text = div.ToString();
                    circularPBar_cust1.Value = Convert.ToInt32(value); ;
                    int alertMunite = (Settings1.Default.alertMunite* 60);
                    if (secsRem <= alertMunite)
                    {
                        changePanColor();
                    }
                    if(secsRem == alertMunite)
                    {
                        try
                        {
                            am = new AlertMessage(CountDownCountTimerControl);
                            am.ShowDialog();
                        }
                        catch (Exception ex) { MessageBox.Show(ex.Message); }
                    }
                }
                catch(Exception ex)
                {
                    isComplete = true;
                    notification.Show(ex.Message+" : Times are the same");
                }
            }

        }

        private void changePanColor()
        {
            if (checkTimerSpeed % 2 == 0)
                lbStatus.ForeColor = Color_original;
            else lbStatus.ForeColor = Color_timeUp;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFormat.Text == "12")
            {
                numHour.Maximum = 12;
                numHourWU.Maximum = 12;
                domTT.Enabled = true;
                domTTWU.Enabled = true;
            }
            if (cmbFormat.Text == "24")
            {
                numHour.Maximum = 24;
                numHourWU.Maximum = 24;
                domTT.Enabled = false;
                domTTWU.Enabled = false;
            }
        }

        void formatChanged()
        {
            if (cmbFormat.Text == "12")
            {
                timeFormat = "hh:mm:ss";
            }
            if (cmbFormat.Text == "24")
            { 
                timeFormat = "HH:mm:ss";
            }


        }

        void setWakeUp()
        {
            if (wakeupIndex == wakeupOn)
            {
                WakeUP.SetWakeUpTime(WakeupTime);
            }
        }

        #region Hover
        private void btnStart_MouseEnter(object sender, EventArgs e)
        {
            btnStart.Image = ((System.Drawing.Image)(Properties.Resources.shutdown_icons_start_glow));
        }

        private void btnStart_MouseLeave(object sender, EventArgs e)
        {
            btnStart.Image = ((System.Drawing.Image)(Properties.Resources.shutdown_icons_start));
        }

        private void btnStart_MouseDown(object sender, MouseEventArgs e)
        {
            btnStart.Image = ((System.Drawing.Image)(Properties.Resources.shutdown_icons_start_glow_d));
        }
        private void btnPause_MouseEnter(object sender, EventArgs e)
        {
            btnPause.Image = ((System.Drawing.Image)(Properties.Resources.shutdown_icons_pause_glow));
        }

        private void btnPause_MouseLeave(object sender, EventArgs e)
        {
            btnPause.Image = ((System.Drawing.Image)(Properties.Resources.shutdown_icons_pause));
        }

        private void btnPause_MouseDown(object sender, MouseEventArgs e)
        {
            btnPause.Image = ((System.Drawing.Image)(Properties.Resources.shutdown_icons_pause_glow_d));
        }
        private void btnStop_MouseEnter(object sender, EventArgs e)
        {
            btnStop.Image = ((System.Drawing.Image)(Properties.Resources.shutdown_icons_stop__glow));
        }

        private void btnStop_MouseLeave(object sender, EventArgs e)
        {
            btnStop.Image = ((System.Drawing.Image)(Properties.Resources.shutdown_icons_stop));
        }

        private void btnStop_MouseDown(object sender, MouseEventArgs e)
        {
            btnStop.Image = ((System.Drawing.Image)(Properties.Resources.shutdown_icons_stop__glow_d));
        }
        private void btnSet_MouseEnter(object sender, EventArgs e)
        {
            btnSet.Image = ((System.Drawing.Image)(Properties.Resources.shutdown_icons_set_glow));
        }

        private void btnSet_MouseLeave(object sender, EventArgs e)
        {
            btnSet.Image = ((System.Drawing.Image)(Properties.Resources.shutdown_icons_set));
        }

        private void btnSet_MouseDown(object sender, MouseEventArgs e)
        {
            btnSetTime.Image = ((System.Drawing.Image)(Properties.Resources.shutdown_icons_set_glow_d));
        }
        #endregion


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            PLPPoperContainer1.Show(btnPower);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            Set();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Start();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            Pause();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Stop();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            pnlSet.Visible = false;
        }
        private DateTime getWakeupTime()
        {
            string ST = "NOT SET";
            if (cmbFormat.SelectedItem == "12")
            {
                ST = numHourWU.Value.ToString() + ":" + numMinWU.Value.ToString() + ":" + numSecWU.Value.ToString() + " " + domTTWU.Text.ToString();
            }
            if (cmbFormat.SelectedItem == "24")
            {
                ST = numHourWU.Value.ToString() + ":" + numMinWU.Value.ToString() + ":" + numSecWU.Value.ToString();
            }
            return Convert.ToDateTime(ST);
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (selectedPower == sleep || selectedPower == hibernate)
            {
                if (cmbWakeupStatus.SelectedIndex == 0)
                {
                    if (wakeupPreSet == wakeupOn)
                    {
                        wakeupIndex = wakeupOn;
                    }
                    else
                    {
                        wakeupIndex = wakeupNotSet;
                    }
                }
                else
                {
                    wakeupIndex = wakeupOff;
                }
            }
            if (cmbWakeupStatus.SelectedIndex == 0)
                pnlWakeupSet.Enabled = true;
            else
                pnlWakeupSet.Enabled = false;
        }

        private void btnSetTimeWU_Click(object sender, EventArgs e)
        {

        }

        bool _lockMode = false;

        public bool lockMode
        {
            get { return _lockMode; }
            set 
            { 
                if(value == true)
                {
                    _lockMode = true;
                    panel4.Visible = false;
                }
                else
                {
                    _lockMode = false;
                    panel4.Visible = true;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lockMode = true;
        }

        private void CountDown_Load(object sender, EventArgs e)
        {
            CountDownCountTimerControl = new CountTimerControl("cd", form1);
        }
    }
}
