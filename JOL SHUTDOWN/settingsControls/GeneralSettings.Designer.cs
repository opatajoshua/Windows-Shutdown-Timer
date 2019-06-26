namespace JOL_SHUTDOWN.controls
{
    partial class GeneralSettings
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbPlayAlertSound = new System.Windows.Forms.CheckBox();
            this.cmbShowAlertMessage = new System.Windows.Forms.CheckBox();
            this.cbAskForPass = new System.Windows.Forms.CheckBox();
            this.btnSetSoundDefault = new System.Windows.Forms.Button();
            this.btnChangePass = new System.Windows.Forms.Button();
            this.btnBrowseSound = new System.Windows.Forms.Button();
            this.txtNotificationSeconds = new System.Windows.Forms.TextBox();
            this.txtAlertMinute = new System.Windows.Forms.TextBox();
            this.txtAlertSoundLocation = new System.Windows.Forms.TextBox();
            this.txtAlertMessage = new System.Windows.Forms.TextBox();
            this.txtVeriPass = new System.Windows.Forms.TextBox();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.txtOldPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.browseSound = new System.Windows.Forms.OpenFileDialog();
            this.lbDefOldPas = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.lbDefOldPas);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cmbPlayAlertSound);
            this.panel2.Controls.Add(this.cmbShowAlertMessage);
            this.panel2.Controls.Add(this.cbAskForPass);
            this.panel2.Controls.Add(this.btnSetSoundDefault);
            this.panel2.Controls.Add(this.btnChangePass);
            this.panel2.Controls.Add(this.btnBrowseSound);
            this.panel2.Controls.Add(this.txtNotificationSeconds);
            this.panel2.Controls.Add(this.txtAlertMinute);
            this.panel2.Controls.Add(this.txtAlertSoundLocation);
            this.panel2.Controls.Add(this.txtAlertMessage);
            this.panel2.Controls.Add(this.txtVeriPass);
            this.panel2.Controls.Add(this.txtNewPass);
            this.panel2.Controls.Add(this.txtOldPass);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(779, 666);
            this.panel2.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.label7.Location = new System.Drawing.Point(36, 433);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Verify Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.label6.Location = new System.Drawing.Point(36, 377);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "New Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.label5.Location = new System.Drawing.Point(36, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Old Password";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.label8.Location = new System.Drawing.Point(36, 577);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(196, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Notification Duration in Seconds";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.label2.Location = new System.Drawing.Point(36, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Minutes left to Alert";
            // 
            // cmbPlayAlertSound
            // 
            this.cmbPlayAlertSound.AutoSize = true;
            this.cmbPlayAlertSound.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cmbPlayAlertSound.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.cmbPlayAlertSound.Location = new System.Drawing.Point(39, 110);
            this.cmbPlayAlertSound.Name = "cmbPlayAlertSound";
            this.cmbPlayAlertSound.Size = new System.Drawing.Size(229, 21);
            this.cmbPlayAlertSound.TabIndex = 2;
            this.cmbPlayAlertSound.Text = "Play sound when the timer reaches";
            this.cmbPlayAlertSound.UseVisualStyleBackColor = true;
            this.cmbPlayAlertSound.CheckedChanged += new System.EventHandler(this.cmbPlayAlertSound_CheckedChanged);
            // 
            // cmbShowAlertMessage
            // 
            this.cmbShowAlertMessage.AutoSize = true;
            this.cmbShowAlertMessage.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cmbShowAlertMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.cmbShowAlertMessage.Location = new System.Drawing.Point(39, 49);
            this.cmbShowAlertMessage.Name = "cmbShowAlertMessage";
            this.cmbShowAlertMessage.Size = new System.Drawing.Size(253, 21);
            this.cmbShowAlertMessage.TabIndex = 0;
            this.cmbShowAlertMessage.Text = "Show message when the timer reaches";
            this.cmbShowAlertMessage.UseVisualStyleBackColor = true;
            this.cmbShowAlertMessage.CheckedChanged += new System.EventHandler(this.cmbShowAlertMessage_CheckedChanged);
            // 
            // cbAskForPass
            // 
            this.cbAskForPass.AutoSize = true;
            this.cbAskForPass.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cbAskForPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.cbAskForPass.Location = new System.Drawing.Point(39, 295);
            this.cbAskForPass.Name = "cbAskForPass";
            this.cbAskForPass.Size = new System.Drawing.Size(193, 21);
            this.cbAskForPass.TabIndex = 7;
            this.cbAskForPass.Text = "Ask for password on startup";
            this.cbAskForPass.UseVisualStyleBackColor = true;
            this.cbAskForPass.CheckedChanged += new System.EventHandler(this.cbAskForPass_CheckedChanged);
            // 
            // btnSetSoundDefault
            // 
            this.btnSetSoundDefault.BackColor = System.Drawing.Color.Silver;
            this.btnSetSoundDefault.FlatAppearance.BorderSize = 0;
            this.btnSetSoundDefault.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetSoundDefault.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F);
            this.btnSetSoundDefault.Location = new System.Drawing.Point(120, 165);
            this.btnSetSoundDefault.Name = "btnSetSoundDefault";
            this.btnSetSoundDefault.Size = new System.Drawing.Size(108, 25);
            this.btnSetSoundDefault.TabIndex = 5;
            this.btnSetSoundDefault.Text = "Default Sound";
            this.btnSetSoundDefault.UseVisualStyleBackColor = false;
            this.btnSetSoundDefault.Click += new System.EventHandler(this.btnSetSoundDefault_Click);
            // 
            // btnChangePass
            // 
            this.btnChangePass.BackColor = System.Drawing.Color.Silver;
            this.btnChangePass.FlatAppearance.BorderSize = 0;
            this.btnChangePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePass.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F);
            this.btnChangePass.Location = new System.Drawing.Point(39, 488);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Size = new System.Drawing.Size(129, 25);
            this.btnChangePass.TabIndex = 11;
            this.btnChangePass.Text = "Change Password";
            this.btnChangePass.UseVisualStyleBackColor = false;
            this.btnChangePass.Click += new System.EventHandler(this.btnChangePass_Click);
            // 
            // btnBrowseSound
            // 
            this.btnBrowseSound.BackColor = System.Drawing.Color.Silver;
            this.btnBrowseSound.FlatAppearance.BorderSize = 0;
            this.btnBrowseSound.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseSound.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F);
            this.btnBrowseSound.Location = new System.Drawing.Point(39, 165);
            this.btnBrowseSound.Name = "btnBrowseSound";
            this.btnBrowseSound.Size = new System.Drawing.Size(75, 25);
            this.btnBrowseSound.TabIndex = 4;
            this.btnBrowseSound.Text = "Browse";
            this.btnBrowseSound.UseVisualStyleBackColor = false;
            this.btnBrowseSound.Click += new System.EventHandler(this.btnBrowseSound_Click);
            // 
            // txtNotificationSeconds
            // 
            this.txtNotificationSeconds.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNotificationSeconds.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNotificationSeconds.Font = new System.Drawing.Font("Segoe UI Semilight", 9.5F);
            this.txtNotificationSeconds.ForeColor = System.Drawing.Color.Black;
            this.txtNotificationSeconds.Location = new System.Drawing.Point(39, 597);
            this.txtNotificationSeconds.Name = "txtNotificationSeconds";
            this.txtNotificationSeconds.Size = new System.Drawing.Size(94, 24);
            this.txtNotificationSeconds.TabIndex = 12;
            this.txtNotificationSeconds.TextChanged += new System.EventHandler(this.txtNotificationSeconds_TextChanged);
            this.txtNotificationSeconds.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNotificationSeconds_KeyPress);
            // 
            // txtAlertMinute
            // 
            this.txtAlertMinute.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtAlertMinute.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAlertMinute.Font = new System.Drawing.Font("Segoe UI Semilight", 9.5F);
            this.txtAlertMinute.ForeColor = System.Drawing.Color.Black;
            this.txtAlertMinute.Location = new System.Drawing.Point(39, 220);
            this.txtAlertMinute.Name = "txtAlertMinute";
            this.txtAlertMinute.Size = new System.Drawing.Size(94, 24);
            this.txtAlertMinute.TabIndex = 6;
            this.txtAlertMinute.TextChanged += new System.EventHandler(this.txtAlertMinute_TextChanged);
            this.txtAlertMinute.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAlertMinute_KeyPress);
            // 
            // txtAlertSoundLocation
            // 
            this.txtAlertSoundLocation.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtAlertSoundLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAlertSoundLocation.Font = new System.Drawing.Font("Segoe UI Semilight", 9.5F);
            this.txtAlertSoundLocation.ForeColor = System.Drawing.Color.Black;
            this.txtAlertSoundLocation.Location = new System.Drawing.Point(39, 133);
            this.txtAlertSoundLocation.Name = "txtAlertSoundLocation";
            this.txtAlertSoundLocation.Size = new System.Drawing.Size(409, 24);
            this.txtAlertSoundLocation.TabIndex = 3;
            this.txtAlertSoundLocation.TextChanged += new System.EventHandler(this.txtAlertSoundLocation_TextChanged);
            // 
            // txtAlertMessage
            // 
            this.txtAlertMessage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtAlertMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAlertMessage.Font = new System.Drawing.Font("Segoe UI Semilight", 9.5F);
            this.txtAlertMessage.ForeColor = System.Drawing.Color.Black;
            this.txtAlertMessage.Location = new System.Drawing.Point(39, 73);
            this.txtAlertMessage.Name = "txtAlertMessage";
            this.txtAlertMessage.Size = new System.Drawing.Size(409, 24);
            this.txtAlertMessage.TabIndex = 1;
            this.txtAlertMessage.TextChanged += new System.EventHandler(this.txtAlertMessage_TextChanged);
            // 
            // txtVeriPass
            // 
            this.txtVeriPass.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtVeriPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVeriPass.Font = new System.Drawing.Font("Segoe UI Semilight", 9.5F);
            this.txtVeriPass.ForeColor = System.Drawing.Color.Black;
            this.txtVeriPass.Location = new System.Drawing.Point(39, 454);
            this.txtVeriPass.Name = "txtVeriPass";
            this.txtVeriPass.Size = new System.Drawing.Size(235, 24);
            this.txtVeriPass.TabIndex = 10;
            this.txtVeriPass.UseSystemPasswordChar = true;
            this.txtVeriPass.TextChanged += new System.EventHandler(this.txtVeriPass_TextChanged);
            // 
            // txtNewPass
            // 
            this.txtNewPass.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNewPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNewPass.Font = new System.Drawing.Font("Segoe UI Semilight", 9.5F);
            this.txtNewPass.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.txtNewPass.Location = new System.Drawing.Point(39, 398);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Size = new System.Drawing.Size(235, 24);
            this.txtNewPass.TabIndex = 9;
            this.txtNewPass.UseSystemPasswordChar = true;
            this.txtNewPass.TextChanged += new System.EventHandler(this.txtNewPass_TextChanged);
            // 
            // txtOldPass
            // 
            this.txtOldPass.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtOldPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOldPass.Font = new System.Drawing.Font("Segoe UI Semilight", 9.5F);
            this.txtOldPass.ForeColor = System.Drawing.Color.Black;
            this.txtOldPass.Location = new System.Drawing.Point(39, 345);
            this.txtOldPass.Name = "txtOldPass";
            this.txtOldPass.Size = new System.Drawing.Size(235, 24);
            this.txtOldPass.TabIndex = 8;
            this.txtOldPass.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(46)))), ((int)(((byte)(116)))));
            this.label1.Location = new System.Drawing.Point(36, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alert";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(46)))), ((int)(((byte)(116)))));
            this.label3.Location = new System.Drawing.Point(34, 541);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Notification";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(46)))), ((int)(((byte)(116)))));
            this.label4.Location = new System.Drawing.Point(34, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Security";
            // 
            // browseSound
            // 
            this.browseSound.FileName = "openFileDialog1";
            this.browseSound.FileOk += new System.ComponentModel.CancelEventHandler(this.browseSound_FileOk);
            // 
            // lbDefOldPas
            // 
            this.lbDefOldPas.AutoSize = true;
            this.lbDefOldPas.Location = new System.Drawing.Point(290, 349);
            this.lbDefOldPas.Name = "lbDefOldPas";
            this.lbDefOldPas.Size = new System.Drawing.Size(176, 15);
            this.lbDefOldPas.TabIndex = 13;
            this.lbDefOldPas.Text = "Default Old Password is : unlock";
            // 
            // GeneralSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Name = "GeneralSettings";
            this.Size = new System.Drawing.Size(779, 666);
            this.Load += new System.EventHandler(this.GeneralSettings_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox cmbPlayAlertSound;
        private System.Windows.Forms.CheckBox cmbShowAlertMessage;
        private System.Windows.Forms.CheckBox cbAskForPass;
        private System.Windows.Forms.Button btnBrowseSound;
        private System.Windows.Forms.TextBox txtAlertMinute;
        private System.Windows.Forms.TextBox txtAlertSoundLocation;
        private System.Windows.Forms.TextBox txtAlertMessage;
        private System.Windows.Forms.TextBox txtVeriPass;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.TextBox txtOldPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSetSoundDefault;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNotificationSeconds;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnChangePass;
        private System.Windows.Forms.OpenFileDialog browseSound;
        private System.Windows.Forms.Label lbDefOldPas;
    }
}
