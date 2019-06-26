namespace JOL_SHUTDOWN
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.settingsPanel1 = new JOL_SHUTDOWN.SettingsPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnLock = new jcontrols.NoFocusButton();
            this.btnMinToTray = new jcontrols.NoFocusButton();
            this.btnMin = new jcontrols.NoFocusButton();
            this.btnClose = new jcontrols.NoFocusButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.menuBtnPanel = new System.Windows.Forms.Panel();
            this.btnSettings = new jcontrols.NoFocusButton();
            this.btnSchedule = new jcontrols.NoFocusButton();
            this.btnCountDown = new jcontrols.NoFocusButton();
            this.btnCountUp = new jcontrols.NoFocusButton();
            this.panel8 = new System.Windows.Forms.Panel();
            this.notificationPanel = new System.Windows.Forms.Panel();
            this.NotificationLabel = new System.Windows.Forms.Label();
            this.tmCurTimer = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.LockPanel = new System.Windows.Forms.Panel();
            this.lockHolder = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.btnLockMin = new jcontrols.NoFocusButton();
            this.btnLockMinToTray = new jcontrols.NoFocusButton();
            this.txtLockPass = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.cmsTray = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.menuBtnPanel.SuspendLayout();
            this.notificationPanel.SuspendLayout();
            this.LockPanel.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel12.SuspendLayout();
            this.cmsTray.SuspendLayout();
            this.panel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.settingsPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(779, 318);
            this.panel1.TabIndex = 5;
            // 
            // settingsPanel1
            // 
            this.settingsPanel1.AutoScroll = true;
            this.settingsPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.settingsPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsPanel1.Location = new System.Drawing.Point(0, 0);
            this.settingsPanel1.Name = "settingsPanel1";
            this.settingsPanel1.Size = new System.Drawing.Size(779, 318);
            this.settingsPanel1.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.panel5.Controls.Add(this.panel9);
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(779, 39);
            this.panel5.TabIndex = 1;
            this.panel5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.pictureBox1);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(36, 39);
            this.panel9.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(604, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(175, 39);
            this.panel3.TabIndex = 6;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnLock);
            this.panel4.Controls.Add(this.btnMinToTray);
            this.panel4.Controls.Add(this.btnMin);
            this.panel4.Controls.Add(this.btnClose);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(175, 26);
            this.panel4.TabIndex = 8;
            // 
            // btnLock
            // 
            this.btnLock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLock.BackgroundImage")));
            this.btnLock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLock.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnLock.FlatAppearance.BorderSize = 0;
            this.btnLock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(112)))), ((int)(((byte)(182)))));
            this.btnLock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLock.ForeColor = System.Drawing.Color.White;
            this.btnLock.ImageKey = "lock.png";
            this.btnLock.Location = new System.Drawing.Point(79, 0);
            this.btnLock.Name = "btnLock";
            this.btnLock.Size = new System.Drawing.Size(24, 26);
            this.btnLock.TabIndex = 11;
            this.btnLock.UseVisualStyleBackColor = true;
            this.btnLock.Click += new System.EventHandler(this.btnLock_Click);
            // 
            // btnMinToTray
            // 
            this.btnMinToTray.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMinToTray.BackgroundImage")));
            this.btnMinToTray.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMinToTray.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinToTray.FlatAppearance.BorderSize = 0;
            this.btnMinToTray.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(112)))), ((int)(((byte)(182)))));
            this.btnMinToTray.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinToTray.ForeColor = System.Drawing.Color.White;
            this.btnMinToTray.ImageKey = "Minimize to tray.png";
            this.btnMinToTray.Location = new System.Drawing.Point(103, 0);
            this.btnMinToTray.Name = "btnMinToTray";
            this.btnMinToTray.Size = new System.Drawing.Size(24, 26);
            this.btnMinToTray.TabIndex = 10;
            this.btnMinToTray.UseVisualStyleBackColor = true;
            this.btnMinToTray.Click += new System.EventHandler(this.btnMinToTray_Click);
            // 
            // btnMin
            // 
            this.btnMin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMin.BackgroundImage")));
            this.btnMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMin.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(112)))), ((int)(((byte)(182)))));
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.ForeColor = System.Drawing.Color.White;
            this.btnMin.ImageKey = "Minimize.png";
            this.btnMin.Location = new System.Drawing.Point(127, 0);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(24, 26);
            this.btnMin.TabIndex = 9;
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnClose.ImageList = this.imageList1;
            this.btnClose.Location = new System.Drawing.Point(151, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(24, 26);
            this.btnClose.TabIndex = 8;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "lock.png");
            this.imageList1.Images.SetKeyName(1, "Minimize to tray.png");
            this.imageList1.Images.SetKeyName(2, "Minimize.png");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 10F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(168)))), ((int)(((byte)(236)))));
            this.label1.Location = new System.Drawing.Point(37, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "JOL Power Timer";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.panel6.Controls.Add(this.panel1);
            this.panel6.Controls.Add(this.panel2);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Controls.Add(this.panel5);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(779, 389);
            this.panel6.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(779, 2);
            this.panel2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.label3.Dock = System.Windows.Forms.DockStyle.Right;
            this.label3.Location = new System.Drawing.Point(712, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 2);
            this.label3.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 2);
            this.label2.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.panel7.Controls.Add(this.menuBtnPanel);
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 39);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(779, 30);
            this.panel7.TabIndex = 1;
            // 
            // menuBtnPanel
            // 
            this.menuBtnPanel.Controls.Add(this.btnSettings);
            this.menuBtnPanel.Controls.Add(this.btnSchedule);
            this.menuBtnPanel.Controls.Add(this.btnCountDown);
            this.menuBtnPanel.Controls.Add(this.btnCountUp);
            this.menuBtnPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuBtnPanel.Location = new System.Drawing.Point(118, 0);
            this.menuBtnPanel.Name = "menuBtnPanel";
            this.menuBtnPanel.Size = new System.Drawing.Size(649, 30);
            this.menuBtnPanel.TabIndex = 6;
            // 
            // btnSettings
            // 
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.Silver;
            this.btnSettings.Location = new System.Drawing.Point(378, 0);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(126, 30);
            this.btnSettings.TabIndex = 6;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnSchedule
            // 
            this.btnSchedule.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSchedule.FlatAppearance.BorderSize = 0;
            this.btnSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSchedule.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSchedule.ForeColor = System.Drawing.Color.Silver;
            this.btnSchedule.Location = new System.Drawing.Point(252, 0);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Size = new System.Drawing.Size(126, 30);
            this.btnSchedule.TabIndex = 7;
            this.btnSchedule.Text = "Schedule";
            this.btnSchedule.UseVisualStyleBackColor = true;
            this.btnSchedule.Click += new System.EventHandler(this.btnSchedule_Click);
            // 
            // btnCountDown
            // 
            this.btnCountDown.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCountDown.FlatAppearance.BorderSize = 0;
            this.btnCountDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCountDown.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCountDown.ForeColor = System.Drawing.Color.Silver;
            this.btnCountDown.Location = new System.Drawing.Point(126, 0);
            this.btnCountDown.Name = "btnCountDown";
            this.btnCountDown.Size = new System.Drawing.Size(126, 30);
            this.btnCountDown.TabIndex = 5;
            this.btnCountDown.Text = "Count down";
            this.btnCountDown.UseVisualStyleBackColor = true;
            this.btnCountDown.Click += new System.EventHandler(this.btnCountDown_Click);
            // 
            // btnCountUp
            // 
            this.btnCountUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.btnCountUp.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCountUp.FlatAppearance.BorderSize = 0;
            this.btnCountUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCountUp.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCountUp.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCountUp.Location = new System.Drawing.Point(0, 0);
            this.btnCountUp.Name = "btnCountUp";
            this.btnCountUp.Size = new System.Drawing.Size(126, 30);
            this.btnCountUp.TabIndex = 4;
            this.btnCountUp.Text = "Count up";
            this.btnCountUp.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCountUp.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnCountUp.UseVisualStyleBackColor = false;
            this.btnCountUp.Click += new System.EventHandler(this.btnCountUp_Click);
            // 
            // panel8
            // 
            this.panel8.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(118, 30);
            this.panel8.TabIndex = 1;
            // 
            // notificationPanel
            // 
            this.notificationPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.notificationPanel.Controls.Add(this.NotificationLabel);
            this.notificationPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.notificationPanel.Location = new System.Drawing.Point(1, 1);
            this.notificationPanel.Name = "notificationPanel";
            this.notificationPanel.Size = new System.Drawing.Size(777, 32);
            this.notificationPanel.TabIndex = 4;
            this.notificationPanel.Visible = false;
            // 
            // NotificationLabel
            // 
            this.NotificationLabel.AutoSize = true;
            this.NotificationLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotificationLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(168)))), ((int)(((byte)(236)))));
            this.NotificationLabel.Location = new System.Drawing.Point(12, 9);
            this.NotificationLabel.Name = "NotificationLabel";
            this.NotificationLabel.Size = new System.Drawing.Size(50, 20);
            this.NotificationLabel.TabIndex = 0;
            this.NotificationLabel.Text = "label4";
            // 
            // tmCurTimer
            // 
            this.tmCurTimer.Interval = 1000;
            this.tmCurTimer.Tick += new System.EventHandler(this.tmCurTimer_Tick);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(168)))), ((int)(((byte)(236)))));
            this.label5.Dock = System.Windows.Forms.DockStyle.Left;
            this.label5.Location = new System.Drawing.Point(0, 1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1, 387);
            this.label5.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(168)))), ((int)(((byte)(236)))));
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(779, 1);
            this.label6.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(168)))), ((int)(((byte)(236)))));
            this.label7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label7.Location = new System.Drawing.Point(0, 388);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(778, 1);
            this.label7.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(168)))), ((int)(((byte)(236)))));
            this.label8.Dock = System.Windows.Forms.DockStyle.Right;
            this.label8.Location = new System.Drawing.Point(778, 1);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(1, 388);
            this.label8.TabIndex = 7;
            // 
            // LockPanel
            // 
            this.LockPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.LockPanel.Controls.Add(this.lockHolder);
            this.LockPanel.Controls.Add(this.panel11);
            this.LockPanel.Location = new System.Drawing.Point(0, 0);
            this.LockPanel.Name = "LockPanel";
            this.LockPanel.Size = new System.Drawing.Size(779, 388);
            this.LockPanel.TabIndex = 3;
            // 
            // lockHolder
            // 
            this.lockHolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lockHolder.Location = new System.Drawing.Point(0, 71);
            this.lockHolder.Name = "lockHolder";
            this.lockHolder.Size = new System.Drawing.Size(779, 317);
            this.lockHolder.TabIndex = 2;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.panel12);
            this.panel11.Controls.Add(this.txtLockPass);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(0, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(779, 71);
            this.panel11.TabIndex = 1;
            this.panel11.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.btnLockMin);
            this.panel12.Controls.Add(this.btnLockMinToTray);
            this.panel12.Location = new System.Drawing.Point(217, 31);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(109, 26);
            this.panel12.TabIndex = 8;
            // 
            // btnLockMin
            // 
            this.btnLockMin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLockMin.BackgroundImage")));
            this.btnLockMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLockMin.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnLockMin.FlatAppearance.BorderSize = 0;
            this.btnLockMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLockMin.ForeColor = System.Drawing.Color.White;
            this.btnLockMin.Location = new System.Drawing.Point(31, 0);
            this.btnLockMin.Name = "btnLockMin";
            this.btnLockMin.Size = new System.Drawing.Size(31, 26);
            this.btnLockMin.TabIndex = 9;
            this.btnLockMin.Text = "-";
            this.toolTip1.SetToolTip(this.btnLockMin, "Minimize to taskbar ");
            this.btnLockMin.UseVisualStyleBackColor = true;
            this.btnLockMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnLockMinToTray
            // 
            this.btnLockMinToTray.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLockMinToTray.BackgroundImage")));
            this.btnLockMinToTray.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLockMinToTray.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnLockMinToTray.FlatAppearance.BorderSize = 0;
            this.btnLockMinToTray.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLockMinToTray.ForeColor = System.Drawing.Color.White;
            this.btnLockMinToTray.Location = new System.Drawing.Point(0, 0);
            this.btnLockMinToTray.Name = "btnLockMinToTray";
            this.btnLockMinToTray.Size = new System.Drawing.Size(31, 26);
            this.btnLockMinToTray.TabIndex = 10;
            this.btnLockMinToTray.Text = "--";
            this.toolTip1.SetToolTip(this.btnLockMinToTray, "Minimize to tray");
            this.btnLockMinToTray.UseVisualStyleBackColor = true;
            this.btnLockMinToTray.Click += new System.EventHandler(this.btnMinToTray_Click);
            // 
            // txtLockPass
            // 
            this.txtLockPass.BackColor = System.Drawing.Color.DimGray;
            this.txtLockPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLockPass.Font = new System.Drawing.Font("Segoe UI Semilight", 9.5F);
            this.txtLockPass.ForeColor = System.Drawing.Color.Black;
            this.txtLockPass.Location = new System.Drawing.Point(30, 33);
            this.txtLockPass.Name = "txtLockPass";
            this.txtLockPass.Size = new System.Drawing.Size(181, 24);
            this.txtLockPass.TabIndex = 2;
            this.txtLockPass.UseSystemPasswordChar = true;
            this.txtLockPass.TextChanged += new System.EventHandler(this.txtLockPass_TextChanged);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipText = "JOL Shutdown Timer";
            this.notifyIcon1.BalloonTipTitle = "JOL Shutdown Timer";
            this.notifyIcon1.ContextMenuStrip = this.cmsTray;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "JOL Shutdown Timer";
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // cmsTray
            // 
            this.cmsTray.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.cmsTray.Name = "cmsTray";
            this.cmsTray.Size = new System.Drawing.Size(108, 48);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.helpToolStripMenuItem.Text = "About";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.panel6);
            this.panel10.Controls.Add(this.LockPanel);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(779, 389);
            this.panel10.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(779, 389);
            this.Controls.Add(this.notificationPanel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel10);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "JOL Shutdown Timer";
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.menuBtnPanel.ResumeLayout(false);
            this.notificationPanel.ResumeLayout(false);
            this.notificationPanel.PerformLayout();
            this.LockPanel.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.cmsTray.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel menuBtnPanel;
        private jcontrols.NoFocusButton btnMin;
        private jcontrols.NoFocusButton btnClose;
        public System.Windows.Forms.Label NotificationLabel;
        private System.Windows.Forms.Timer tmCurTimer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.Panel notificationPanel;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel LockPanel;
        private jcontrols.NoFocusButton btnLock;
        private jcontrols.NoFocusButton btnMinToTray;
        private System.Windows.Forms.Panel lockHolder;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.TextBox txtLockPass;
        private System.Windows.Forms.Panel panel12;
        private jcontrols.NoFocusButton btnLockMin;
        private jcontrols.NoFocusButton btnLockMinToTray;
        private System.Windows.Forms.ToolTip toolTip1;
        //public CountUp countUp1;
        public SettingsPanel settingsPanel1;
        //public CountDown countDown1;
        public jcontrols.NoFocusButton btnCountUp;
        public jcontrols.NoFocusButton btnCountDown;
        public jcontrols.NoFocusButton btnSettings;
        public jcontrols.NoFocusButton btnSchedule;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip cmsTray;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Panel panel10;
    }
}

