namespace JOL_SHUTDOWN
{
    partial class SchedulePanel
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SchedulePanel));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlWakeup = new System.Windows.Forms.Panel();
            this.pnlWakeupSet = new System.Windows.Forms.Panel();
            this.numHourWU = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.domTTWU = new System.Windows.Forms.DomainUpDown();
            this.numMinWU = new System.Windows.Forms.NumericUpDown();
            this.btnSetTimeWU = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.numSecWU = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbWakeupStatus = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.domTT = new System.Windows.Forms.DomainUpDown();
            this.btnSetTime = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbFormat = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.numSec = new System.Windows.Forms.NumericUpDown();
            this.tmCurTimer = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.label11 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lbStartTime = new System.Windows.Forms.Label();
            this.lbTimeInterval = new System.Windows.Forms.Label();
            this.lbWakeStatus = new System.Windows.Forms.Label();
            this.lbTimeRemaining = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnPower = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.numMin = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.lbSetCurTime = new System.Windows.Forms.Label();
            this.numHour = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lbCurTT = new System.Windows.Forms.Label();
            this.lbCurTime = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbShuTT = new System.Windows.Forms.Label();
            this.lbShuTime = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbPowerType = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.clnAction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnRepeat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnSet = new jcontrols.NoFocusButton();
            this.btnStop = new jcontrols.NoFocusButton();
            this.btnPause = new jcontrols.NoFocusButton();
            this.btnStart = new jcontrols.NoFocusButton();
            this.lbStatus = new System.Windows.Forms.Label();
            this.circularPBar_cust1 = new jcontrols.CircularPBar_cust();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.hhhhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlSet = new System.Windows.Forms.Panel();
            this.pnlWakeup.SuspendLayout();
            this.pnlWakeupSet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHourWU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinWU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSecWU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSec)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHour)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel4.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlWakeup
            // 
            this.pnlWakeup.Controls.Add(this.pnlWakeupSet);
            this.pnlWakeup.Controls.Add(this.label14);
            this.pnlWakeup.Controls.Add(this.label13);
            this.pnlWakeup.Controls.Add(this.cmbWakeupStatus);
            this.pnlWakeup.Enabled = false;
            this.pnlWakeup.Location = new System.Drawing.Point(78, 148);
            this.pnlWakeup.Name = "pnlWakeup";
            this.pnlWakeup.Size = new System.Drawing.Size(684, 169);
            this.pnlWakeup.TabIndex = 11;
            // 
            // pnlWakeupSet
            // 
            this.pnlWakeupSet.Controls.Add(this.numHourWU);
            this.pnlWakeupSet.Controls.Add(this.label1);
            this.pnlWakeupSet.Controls.Add(this.domTTWU);
            this.pnlWakeupSet.Controls.Add(this.numMinWU);
            this.pnlWakeupSet.Controls.Add(this.btnSetTimeWU);
            this.pnlWakeupSet.Controls.Add(this.label10);
            this.pnlWakeupSet.Controls.Add(this.numSecWU);
            this.pnlWakeupSet.Controls.Add(this.label12);
            this.pnlWakeupSet.Location = new System.Drawing.Point(195, 49);
            this.pnlWakeupSet.Name = "pnlWakeupSet";
            this.pnlWakeupSet.Size = new System.Drawing.Size(453, 81);
            this.pnlWakeupSet.TabIndex = 11;
            // 
            // numHourWU
            // 
            this.numHourWU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.numHourWU.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numHourWU.Font = new System.Drawing.Font("Segoe UI Light", 20F);
            this.numHourWU.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.numHourWU.InterceptArrowKeys = false;
            this.numHourWU.Location = new System.Drawing.Point(12, 23);
            this.numHourWU.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numHourWU.Name = "numHourWU";
            this.numHourWU.Size = new System.Drawing.Size(71, 43);
            this.numHourWU.TabIndex = 1;
            this.numHourWU.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(7, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "hour";
            // 
            // domTTWU
            // 
            this.domTTWU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.domTTWU.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.domTTWU.Font = new System.Drawing.Font("Segoe UI Light", 20F);
            this.domTTWU.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.domTTWU.Items.Add("AM");
            this.domTTWU.Items.Add("PM");
            this.domTTWU.Location = new System.Drawing.Point(263, 23);
            this.domTTWU.Name = "domTTWU";
            this.domTTWU.ReadOnly = true;
            this.domTTWU.Size = new System.Drawing.Size(71, 43);
            this.domTTWU.TabIndex = 4;
            this.domTTWU.Wrap = true;
            // 
            // numMinWU
            // 
            this.numMinWU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.numMinWU.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numMinWU.Font = new System.Drawing.Font("Segoe UI Light", 20F);
            this.numMinWU.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.numMinWU.Location = new System.Drawing.Point(97, 23);
            this.numMinWU.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numMinWU.Name = "numMinWU";
            this.numMinWU.Size = new System.Drawing.Size(71, 43);
            this.numMinWU.TabIndex = 2;
            this.numMinWU.Value = new decimal(new int[] {
            59,
            0,
            0,
            0});
            // 
            // btnSetTimeWU
            // 
            this.btnSetTimeWU.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSetTimeWU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetTimeWU.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetTimeWU.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnSetTimeWU.Location = new System.Drawing.Point(347, 23);
            this.btnSetTimeWU.Name = "btnSetTimeWU";
            this.btnSetTimeWU.Size = new System.Drawing.Size(71, 43);
            this.btnSetTimeWU.TabIndex = 6;
            this.btnSetTimeWU.Text = "Set";
            this.btnSetTimeWU.UseVisualStyleBackColor = true;
            this.btnSetTimeWU.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label10.Location = new System.Drawing.Point(92, 1);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 21);
            this.label10.TabIndex = 4;
            this.label10.Text = "min";
            // 
            // numSecWU
            // 
            this.numSecWU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.numSecWU.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numSecWU.Font = new System.Drawing.Font("Segoe UI Light", 20F);
            this.numSecWU.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.numSecWU.Location = new System.Drawing.Point(180, 23);
            this.numSecWU.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numSecWU.Name = "numSecWU";
            this.numSecWU.Size = new System.Drawing.Size(71, 43);
            this.numSecWU.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label12.Location = new System.Drawing.Point(175, 1);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 21);
            this.label12.TabIndex = 4;
            this.label12.Text = "sec";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Light", 17F);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(122)))), ((int)(((byte)(203)))));
            this.label14.Location = new System.Drawing.Point(44, 18);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(238, 31);
            this.label14.TabIndex = 10;
            this.label14.Text = "Wakeup time (optional)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label13.Location = new System.Drawing.Point(122, 49);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 21);
            this.label13.TabIndex = 4;
            this.label13.Text = "status";
            // 
            // cmbWakeupStatus
            // 
            this.cmbWakeupStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.cmbWakeupStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWakeupStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbWakeupStatus.Font = new System.Drawing.Font("Segoe UI Light", 20F);
            this.cmbWakeupStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.cmbWakeupStatus.FormattingEnabled = true;
            this.cmbWakeupStatus.Items.AddRange(new object[] {
            "ON",
            "OFF"});
            this.cmbWakeupStatus.Location = new System.Drawing.Point(124, 71);
            this.cmbWakeupStatus.Name = "cmbWakeupStatus";
            this.cmbWakeupStatus.Size = new System.Drawing.Size(71, 45);
            this.cmbWakeupStatus.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(48, 6);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(41, 41);
            this.btnBack.TabIndex = 10;
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // domTT
            // 
            this.domTT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.domTT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.domTT.Font = new System.Drawing.Font("Segoe UI Light", 20F);
            this.domTT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.domTT.Items.Add("AM");
            this.domTT.Items.Add("PM");
            this.domTT.Location = new System.Drawing.Point(530, 17);
            this.domTT.Name = "domTT";
            this.domTT.ReadOnly = true;
            this.domTT.Size = new System.Drawing.Size(71, 43);
            this.domTT.TabIndex = 4;
            this.domTT.Visible = false;
            this.domTT.Wrap = true;
            // 
            // btnSetTime
            // 
            this.btnSetTime.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSetTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetTime.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnSetTime.Location = new System.Drawing.Point(535, 84);
            this.btnSetTime.Name = "btnSetTime";
            this.btnSetTime.Size = new System.Drawing.Size(71, 43);
            this.btnSetTime.TabIndex = 6;
            this.btnSetTime.Text = "Set";
            this.btnSetTime.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Location = new System.Drawing.Point(200, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "format";
            // 
            // cmbFormat
            // 
            this.cmbFormat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.cmbFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFormat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbFormat.Font = new System.Drawing.Font("Segoe UI Light", 20F);
            this.cmbFormat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.cmbFormat.FormattingEnabled = true;
            this.cmbFormat.Items.AddRange(new object[] {
            "12",
            "24"});
            this.cmbFormat.Location = new System.Drawing.Point(202, 83);
            this.cmbFormat.Name = "cmbFormat";
            this.cmbFormat.Size = new System.Drawing.Size(71, 45);
            this.cmbFormat.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label9.Location = new System.Drawing.Point(448, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 21);
            this.label9.TabIndex = 4;
            this.label9.Text = "sec";
            // 
            // numSec
            // 
            this.numSec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.numSec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numSec.Font = new System.Drawing.Font("Segoe UI Light", 20F);
            this.numSec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.numSec.Location = new System.Drawing.Point(453, 84);
            this.numSec.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numSec.Name = "numSec";
            this.numSec.Size = new System.Drawing.Size(71, 43);
            this.numSec.TabIndex = 3;
            // 
            // tmCurTimer
            // 
            this.tmCurTimer.Interval = 1000;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.splitter1);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 318);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(779, 21);
            this.panel2.TabIndex = 10;
            this.panel2.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Left;
            this.label6.ForeColor = System.Drawing.Color.LightGray;
            this.label6.Location = new System.Drawing.Point(60, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "percentage calculation";
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.splitter1.Location = new System.Drawing.Point(57, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 21);
            this.splitter1.TabIndex = 6;
            this.splitter1.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Left;
            this.label11.ForeColor = System.Drawing.Color.LightGray;
            this.label11.Location = new System.Drawing.Point(0, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "time iterval";
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(67)))), ((int)(((byte)(100)))));
            this.toolTip1.ForeColor = System.Drawing.Color.White;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // lbStartTime
            // 
            this.lbStartTime.AutoSize = true;
            this.lbStartTime.BackColor = System.Drawing.Color.Transparent;
            this.lbStartTime.Font = new System.Drawing.Font("Segoe UI Light", 9F);
            this.lbStartTime.ForeColor = System.Drawing.Color.LightGray;
            this.lbStartTime.Location = new System.Drawing.Point(488, 190);
            this.lbStartTime.Name = "lbStartTime";
            this.lbStartTime.Size = new System.Drawing.Size(69, 15);
            this.lbStartTime.TabIndex = 5;
            this.lbStartTime.Text = "00:00:00 PM";
            this.toolTip1.SetToolTip(this.lbStartTime, "started time");
            // 
            // lbTimeInterval
            // 
            this.lbTimeInterval.AutoSize = true;
            this.lbTimeInterval.BackColor = System.Drawing.Color.Transparent;
            this.lbTimeInterval.Font = new System.Drawing.Font("Segoe UI Light", 9F);
            this.lbTimeInterval.ForeColor = System.Drawing.Color.LightGray;
            this.lbTimeInterval.Location = new System.Drawing.Point(571, 170);
            this.lbTimeInterval.Name = "lbTimeInterval";
            this.lbTimeInterval.Size = new System.Drawing.Size(49, 15);
            this.lbTimeInterval.TabIndex = 5;
            this.lbTimeInterval.Text = "00:00:00";
            this.toolTip1.SetToolTip(this.lbTimeInterval, "time iterval");
            // 
            // lbWakeStatus
            // 
            this.lbWakeStatus.AutoSize = true;
            this.lbWakeStatus.BackColor = System.Drawing.Color.Transparent;
            this.lbWakeStatus.Font = new System.Drawing.Font("Segoe UI Light", 9F);
            this.lbWakeStatus.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbWakeStatus.Location = new System.Drawing.Point(488, 210);
            this.lbWakeStatus.Name = "lbWakeStatus";
            this.lbWakeStatus.Size = new System.Drawing.Size(51, 15);
            this.lbWakeStatus.TabIndex = 4;
            this.lbWakeStatus.Text = "NOT SET";
            this.toolTip1.SetToolTip(this.lbWakeStatus, "wakeup status");
            this.lbWakeStatus.Visible = false;
            // 
            // lbTimeRemaining
            // 
            this.lbTimeRemaining.AutoSize = true;
            this.lbTimeRemaining.BackColor = System.Drawing.Color.Transparent;
            this.lbTimeRemaining.Font = new System.Drawing.Font("Segoe UI Light", 9F);
            this.lbTimeRemaining.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbTimeRemaining.Location = new System.Drawing.Point(488, 170);
            this.lbTimeRemaining.Name = "lbTimeRemaining";
            this.lbTimeRemaining.Size = new System.Drawing.Size(49, 15);
            this.lbTimeRemaining.TabIndex = 4;
            this.lbTimeRemaining.Text = "00:00:00";
            this.toolTip1.SetToolTip(this.lbTimeRemaining, "time remaining");
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.panel3.Controls.Add(this.pnlWakeup);
            this.panel3.Controls.Add(this.btnBack);
            this.panel3.Controls.Add(this.btnPower);
            this.panel3.Controls.Add(this.domTT);
            this.panel3.Controls.Add(this.btnSetTime);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.cmbFormat);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.numSec);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.numMin);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.lbSetCurTime);
            this.panel3.Controls.Add(this.numHour);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 339);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(779, 318);
            this.panel3.TabIndex = 11;
            this.panel3.Visible = false;
            // 
            // btnPower
            // 
            this.btnPower.AutoSize = true;
            this.btnPower.FlatAppearance.BorderSize = 0;
            this.btnPower.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPower.Font = new System.Drawing.Font("Segoe UI Light", 17F);
            this.btnPower.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(122)))), ((int)(((byte)(203)))));
            this.btnPower.Location = new System.Drawing.Point(118, 17);
            this.btnPower.Name = "btnPower";
            this.btnPower.Size = new System.Drawing.Size(71, 41);
            this.btnPower.TabIndex = 9;
            this.btnPower.Text = "Alert";
            this.btnPower.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPower.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label8.Location = new System.Drawing.Point(365, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 21);
            this.label8.TabIndex = 4;
            this.label8.Text = "min";
            // 
            // numMin
            // 
            this.numMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.numMin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numMin.Font = new System.Drawing.Font("Segoe UI Light", 20F);
            this.numMin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.numMin.Location = new System.Drawing.Point(370, 84);
            this.numMin.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numMin.Name = "numMin";
            this.numMin.Size = new System.Drawing.Size(71, 43);
            this.numMin.TabIndex = 2;
            this.numMin.Value = new decimal(new int[] {
            59,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label7.Location = new System.Drawing.Point(280, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 21);
            this.label7.TabIndex = 4;
            this.label7.Text = "hour";
            // 
            // lbSetCurTime
            // 
            this.lbSetCurTime.AutoSize = true;
            this.lbSetCurTime.BackColor = System.Drawing.Color.Transparent;
            this.lbSetCurTime.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.lbSetCurTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.lbSetCurTime.Location = new System.Drawing.Point(664, 22);
            this.lbSetCurTime.Name = "lbSetCurTime";
            this.lbSetCurTime.Size = new System.Drawing.Size(80, 25);
            this.lbSetCurTime.TabIndex = 0;
            this.lbSetCurTime.Text = "00:00:00";
            // 
            // numHour
            // 
            this.numHour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.numHour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numHour.Font = new System.Drawing.Font("Segoe UI Light", 20F);
            this.numHour.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.numHour.InterceptArrowKeys = false;
            this.numHour.Location = new System.Drawing.Point(285, 84);
            this.numHour.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numHour.Name = "numHour";
            this.numHour.Size = new System.Drawing.Size(71, 43);
            this.numHour.TabIndex = 1;
            this.numHour.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.lbStartTime);
            this.panel1.Controls.Add(this.lbTimeInterval);
            this.panel1.Controls.Add(this.lbWakeStatus);
            this.panel1.Controls.Add(this.lbTimeRemaining);
            this.panel1.Controls.Add(this.lbStatus);
            this.panel1.Controls.Add(this.circularPBar_cust1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(779, 318);
            this.panel1.TabIndex = 8;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.lbCurTT);
            this.panel6.Controls.Add(this.lbCurTime);
            this.panel6.Controls.Add(this.label17);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Location = new System.Drawing.Point(481, 33);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(295, 61);
            this.panel6.TabIndex = 14;
            // 
            // lbCurTT
            // 
            this.lbCurTT.AutoSize = true;
            this.lbCurTT.BackColor = System.Drawing.Color.Transparent;
            this.lbCurTT.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbCurTT.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCurTT.ForeColor = System.Drawing.Color.LightBlue;
            this.lbCurTT.Location = new System.Drawing.Point(161, 20);
            this.lbCurTT.Name = "lbCurTT";
            this.lbCurTT.Size = new System.Drawing.Size(25, 15);
            this.lbCurTT.TabIndex = 1;
            this.lbCurTT.Text = "AM";
            // 
            // lbCurTime
            // 
            this.lbCurTime.AutoSize = true;
            this.lbCurTime.BackColor = System.Drawing.Color.Transparent;
            this.lbCurTime.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbCurTime.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.lbCurTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.lbCurTime.Location = new System.Drawing.Point(81, 20);
            this.lbCurTime.Name = "lbCurTime";
            this.lbCurTime.Size = new System.Drawing.Size(80, 28);
            this.lbCurTime.TabIndex = 0;
            this.lbCurTime.Text = "00:00:00";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Dock = System.Windows.Forms.DockStyle.Left;
            this.label17.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.label17.Location = new System.Drawing.Point(0, 20);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(81, 28);
            this.label17.TabIndex = 3;
            this.label17.Text = "Monday";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Current time";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lbShuTT);
            this.panel5.Controls.Add(this.lbShuTime);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.lbPowerType);
            this.panel5.Location = new System.Drawing.Point(481, 97);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(295, 61);
            this.panel5.TabIndex = 13;
            // 
            // lbShuTT
            // 
            this.lbShuTT.AutoSize = true;
            this.lbShuTT.BackColor = System.Drawing.Color.Transparent;
            this.lbShuTT.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbShuTT.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShuTT.ForeColor = System.Drawing.Color.LightBlue;
            this.lbShuTT.Location = new System.Drawing.Point(134, 20);
            this.lbShuTT.Name = "lbShuTT";
            this.lbShuTT.Size = new System.Drawing.Size(24, 15);
            this.lbShuTT.TabIndex = 1;
            this.lbShuTT.Text = "PM";
            // 
            // lbShuTime
            // 
            this.lbShuTime.AutoSize = true;
            this.lbShuTime.BackColor = System.Drawing.Color.Transparent;
            this.lbShuTime.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbShuTime.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.lbShuTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.lbShuTime.Location = new System.Drawing.Point(60, 20);
            this.lbShuTime.Name = "lbShuTime";
            this.lbShuTime.Size = new System.Drawing.Size(74, 28);
            this.lbShuTime.TabIndex = 0;
            this.lbShuTime.Text = "Not Set";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.label4.Location = new System.Drawing.Point(0, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Today";
            // 
            // lbPowerType
            // 
            this.lbPowerType.AutoSize = true;
            this.lbPowerType.BackColor = System.Drawing.Color.Transparent;
            this.lbPowerType.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbPowerType.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.lbPowerType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbPowerType.Location = new System.Drawing.Point(0, 0);
            this.lbPowerType.Name = "lbPowerType";
            this.lbPowerType.Size = new System.Drawing.Size(39, 20);
            this.lbPowerType.TabIndex = 2;
            this.lbPowerType.Text = "Alert";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnAction,
            this.clnDate,
            this.clnTime,
            this.clnRepeat,
            this.Status});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.Location = new System.Drawing.Point(13, 48);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(1);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(16)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(46)))), ((int)(((byte)(97)))));
            this.dataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView2.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5);
            this.dataGridView2.RowTemplate.Height = 50;
            this.dataGridView2.RowTemplate.ReadOnly = true;
            this.dataGridView2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(448, 125);
            this.dataGridView2.TabIndex = 11;
            this.dataGridView2.TabStop = false;
            // 
            // clnAction
            // 
            this.clnAction.HeaderText = "Action";
            this.clnAction.Name = "clnAction";
            // 
            // clnDate
            // 
            this.clnDate.HeaderText = "Date/ Day";
            this.clnDate.Name = "clnDate";
            // 
            // clnTime
            // 
            this.clnTime.HeaderText = "Time";
            this.clnTime.Name = "clnTime";
            // 
            // clnRepeat
            // 
            this.clnRepeat.HeaderText = "Repeat Type";
            this.clnRepeat.Name = "clnRepeat";
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.Width = 50;
            // 
            // panel4
            // 
            this.panel4.AutoSize = true;
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.btnSet);
            this.panel4.Controls.Add(this.btnStop);
            this.panel4.Controls.Add(this.btnPause);
            this.panel4.Controls.Add(this.btnStart);
            this.panel4.Location = new System.Drawing.Point(484, 256);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(244, 56);
            this.panel4.TabIndex = 8;
            // 
            // btnSet
            // 
            this.btnSet.BackColor = System.Drawing.Color.Transparent;
            this.btnSet.FlatAppearance.BorderSize = 0;
            this.btnSet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSet.Image = ((System.Drawing.Image)(resources.GetObject("btnSet.Image")));
            this.btnSet.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSet.Location = new System.Drawing.Point(182, 3);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(52, 50);
            this.btnSet.TabIndex = 1;
            this.btnSet.TabStop = false;
            this.btnSet.UseVisualStyleBackColor = false;
            // 
            // btnStop
            // 
            this.btnStop.FlatAppearance.BorderSize = 0;
            this.btnStop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnStop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Image = ((System.Drawing.Image)(resources.GetObject("btnStop.Image")));
            this.btnStop.Location = new System.Drawing.Point(124, 3);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(52, 50);
            this.btnStop.TabIndex = 1;
            this.btnStop.TabStop = false;
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // btnPause
            // 
            this.btnPause.FlatAppearance.BorderSize = 0;
            this.btnPause.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPause.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPause.Image = ((System.Drawing.Image)(resources.GetObject("btnPause.Image")));
            this.btnPause.Location = new System.Drawing.Point(66, 3);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(52, 50);
            this.btnPause.TabIndex = 1;
            this.btnPause.TabStop = false;
            this.btnPause.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Image = ((System.Drawing.Image)(resources.GetObject("btnStart.Image")));
            this.btnStart.Location = new System.Drawing.Point(8, 3);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(52, 50);
            this.btnStart.TabIndex = 1;
            this.btnStart.TabStop = false;
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.BackColor = System.Drawing.Color.Transparent;
            this.lbStatus.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(122)))), ((int)(((byte)(203)))));
            this.lbStatus.Location = new System.Drawing.Point(479, 231);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(67, 25);
            this.lbStatus.TabIndex = 2;
            this.lbStatus.Text = "not set";
            // 
            // circularPBar_cust1
            // 
            this.circularPBar_cust1.BColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.circularPBar_cust1.circleWidth = -23;
            this.circularPBar_cust1.fontSizeForPercentage = 12F;
            this.circularPBar_cust1.IColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.circularPBar_cust1.Location = new System.Drawing.Point(642, 147);
            this.circularPBar_cust1.MaxValue = 100;
            this.circularPBar_cust1.MinValue = 0;
            this.circularPBar_cust1.Name = "circularPBar_cust1";
            this.circularPBar_cust1.PColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.circularPBar_cust1.pWidthB = 23;
            this.circularPBar_cust1.pWidthP = 5;
            this.circularPBar_cust1.Size = new System.Drawing.Size(120, 120);
            this.circularPBar_cust1.TabIndex = 15;
            this.circularPBar_cust1.Value = 45;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hhhhToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(103, 26);
            // 
            // hhhhToolStripMenuItem
            // 
            this.hhhhToolStripMenuItem.Name = "hhhhToolStripMenuItem";
            this.hhhhToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.hhhhToolStripMenuItem.Text = "hhhh";
            // 
            // pnlSet
            // 
            this.pnlSet.AutoSize = true;
            this.pnlSet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(84)))));
            this.pnlSet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSet.Location = new System.Drawing.Point(0, 0);
            this.pnlSet.Name = "pnlSet";
            this.pnlSet.Size = new System.Drawing.Size(779, 785);
            this.pnlSet.TabIndex = 9;
            this.pnlSet.Visible = false;
            // 
            // SchedulePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlSet);
            this.Name = "SchedulePanel";
            this.Size = new System.Drawing.Size(779, 785);
            this.pnlWakeup.ResumeLayout(false);
            this.pnlWakeup.PerformLayout();
            this.pnlWakeupSet.ResumeLayout(false);
            this.pnlWakeupSet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHourWU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinWU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSecWU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSec)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHour)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlWakeup;
        private System.Windows.Forms.Panel pnlWakeupSet;
        private System.Windows.Forms.NumericUpDown numHourWU;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DomainUpDown domTTWU;
        private System.Windows.Forms.NumericUpDown numMinWU;
        private System.Windows.Forms.Button btnSetTimeWU;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numSecWU;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbWakeupStatus;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DomainUpDown domTT;
        private System.Windows.Forms.Button btnSetTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbFormat;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numSec;
        private System.Windows.Forms.Timer tmCurTimer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lbStartTime;
        private System.Windows.Forms.Label lbTimeInterval;
        private System.Windows.Forms.Label lbWakeStatus;
        private System.Windows.Forms.Label lbTimeRemaining;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnPower;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numMin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbSetCurTime;
        private System.Windows.Forms.NumericUpDown numHour;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private jcontrols.NoFocusButton btnSet;
        private jcontrols.NoFocusButton btnStop;
        private jcontrols.NoFocusButton btnPause;
        private jcontrols.NoFocusButton btnStart;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label lbPowerType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbShuTT;
        private System.Windows.Forms.Label lbCurTT;
        private System.Windows.Forms.Label lbCurTime;
        private System.Windows.Forms.Label lbShuTime;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hhhhToolStripMenuItem;
        public System.Windows.Forms.Panel pnlSet;
        public System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnAction;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnRepeat;
        private System.Windows.Forms.DataGridViewImageColumn Status;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private jcontrols.CircularPBar_cust circularPBar_cust1;
    }
}
