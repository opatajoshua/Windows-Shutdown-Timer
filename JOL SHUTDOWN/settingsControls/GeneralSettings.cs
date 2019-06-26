using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using jcontrols;
using JOL_SHUTDOWN.settingsControls;

namespace JOL_SHUTDOWN.controls
{
    public partial class GeneralSettings : UserControl
    {
        public GeneralSettings()
        {
            InitializeComponent();
            loadAlertSettings();
            loadSecuritySettings();
            loadNotificationSettings();
        }
        Settings1 set = Settings1.Default;
        public Notification notification;
        

        #region Alert

        #region EventHadlers

        void loadAlertSettings()
        {
            cmbShowAlertMessage.Checked = set.showAlertMessage;
            txtAlertMessage.Text = set.alertMessage;
            cmbPlayAlertSound.Checked = set.playAlertSong;
            txtAlertSoundLocation.Text = set.alertSongLocation;
            txtAlertMinute.Text = set.alertMunite.ToString();
        }
        private void cmbShowAlertMessage_CheckedChanged(object sender, EventArgs e)
        {
            set.showAlertMessage = cmbShowAlertMessage.Checked;
            set.Save();
        }

        private void txtAlertMessage_TextChanged(object sender, EventArgs e)
        {
            set.alertMessage = txtAlertMessage.Text;
            set.Save();
        }

        private void cmbPlayAlertSound_CheckedChanged(object sender, EventArgs e)
        {
            set.playAlertSong = cmbPlayAlertSound.Checked;
            set.Save();
        }

        private void txtAlertSoundLocation_TextChanged(object sender, EventArgs e)
        {
            set.alertSongLocation = txtAlertSoundLocation.Text;
            set.Save();
        }
        private void browseSound_FileOk(object sender, CancelEventArgs e)
        {
            string location = browseSound.FileName;
            txtAlertSoundLocation.Text = location;
            set.alertSongLocation = location;
            set.Save();
        }
        private void btnBrowseSound_Click(object sender, EventArgs e)
        {
            browseSound.ShowDialog();
        }

        private void btnSetSoundDefault_Click(object sender, EventArgs e)
        {
            set.alertSongLocation = "Default";
            txtAlertSoundLocation.Text = "Default";
            set.Save();
        }

        private void txtAlertMinute_TextChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtAlertMinute.Text))
                {
                    notification.Show("Enter Minutes else the default minute (1) will be used");
                    txtAlertMinute.Text = "1";
                    set.alertMunite = 1;
                    set.Save();
                }
            else
            {
                try
                {

                    set.alertMunite = Convert.ToInt32(txtAlertMinute.Text);
                    set.Save();
                }
                catch (Exception ex)
                {
                    notification.Show(ex.Message);
                }
            }
            
        }
        #endregion

        private void txtAlertMinute_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion

        #region Security
        void loadSecuritySettings()
        {
            cbAskForPass.Checked = set.AskForPass;
        }
        private void cbAskForPass_CheckedChanged(object sender, EventArgs e)
        {
            set.AskForPass = cbAskForPass.Checked;
            set.Save();
        }

        private void txtNewPass_TextChanged(object sender, EventArgs e)
        {
            if (txtNewPass.Text == txtVeriPass.Text)
            {
                txtVeriPass.ForeColor = Color.LightSeaGreen;
            }
            else
            {
                txtVeriPass.ForeColor = Color.IndianRed;
            }
        }
        private void txtVeriPass_TextChanged(object sender, EventArgs e)
        {
            if(txtNewPass.Text == txtVeriPass.Text)
            {
                txtVeriPass.ForeColor = Color.LightSeaGreen;
            }
            else
            {
                txtVeriPass.ForeColor = Color.IndianRed;
            }
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            if(Properties.Settings.Default.isDefaultPass == true)
            {
                if (getHash(txtOldPass.Text) == getHash("unlock"))
                {
                    if (txtNewPass.Text == txtVeriPass.Text)
                    {
                        String hash = getHash(txtNewPass.Text);
                        Properties.Settings.Default.pass = hash;
                        Properties.Settings.Default.isDefaultPass = false;
                        Properties.Settings.Default.Save();
                        notification.Show("Password changed");
                    }
                    else
                    {
                        notification.Show("New password and verification pasword do not match");
                    }
                }
                else
                {
                    notification.Show("New password does not match with the existing password");
                }
            }
            else
            {
                if (getHash(txtOldPass.Text) == Properties.Settings.Default.pass)
                {
                    if (txtNewPass.Text == txtVeriPass.Text)
                    {
                        String hash = getHash(txtNewPass.Text);
                        Properties.Settings.Default.pass = hash;
                        Properties.Settings.Default.Save();
                        notification.Show("Password changed");
                    }
                    else
                    {
                        notification.Show("New password and verification pasword do not match");
                    }
                }
                else
                {
                    notification.Show("New password does not match with the existing password");
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
        #endregion

        #region Notification
        void loadNotificationSettings()
        {
            txtNotificationSeconds.Text = set.NotificationSeconds.ToString();
        }
        private void txtNotificationSeconds_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNotificationSeconds.Text))
            {
                notification.Show("Enter Seconds else the default seconds (4) will be used");
                txtNotificationSeconds.Text = "4";
                set.NotificationSeconds = 4;
                set.Save();
            }
            else
            {
                try
                {

                    set.NotificationSeconds = Convert.ToInt32(txtNotificationSeconds.Text);
                    set.Save();
                }
                catch (Exception ex)
                {
                    notification.Show(ex.Message);
                }
            }
        }

        private void txtNotificationSeconds_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            //String hash = getHash("unlock");
            //Properties.Settings.Default.pass = hash;
            //Properties.Settings.Default.Save();
            //textBox1.Text = hash;
            //Properties.Settings.Default.isDefaultPass = false;
            //Properties.Settings.Default.Save();
            //notification.Show("Your new password is 'unlock'");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //textBox1.Text = Properties.Settings.Default.pass;
        }

        private void GeneralSettings_Load(object sender, EventArgs e)
        {
            lbDefOldPas.Visible = Properties.Settings.Default.isDefaultPass;
        }

        

        




    }
}
