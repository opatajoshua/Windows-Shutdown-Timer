namespace JOL_SHUTDOWN
{
    partial class SettingsPanel
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
            this.pnlGeneral = new System.Windows.Forms.Panel();
            this.menuBtnPanel = new System.Windows.Forms.Panel();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnSchedule = new System.Windows.Forms.Button();
            this.btnCountDown = new System.Windows.Forms.Button();
            this.btnCountUp = new System.Windows.Forms.Button();
            this.btnGeneral = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHelp = new System.Windows.Forms.Button();
            this.GeneralSettings1 = new JOL_SHUTDOWN.controls.GeneralSettings();
            this.help1 = new JOL_SHUTDOWN.Help();
            this.about1 = new JOL_SHUTDOWN.About();
            this.pnlGeneral.SuspendLayout();
            this.menuBtnPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlGeneral
            // 
            this.pnlGeneral.AutoScroll = true;
            this.pnlGeneral.Controls.Add(this.GeneralSettings1);
            this.pnlGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGeneral.Location = new System.Drawing.Point(0, 0);
            this.pnlGeneral.Name = "pnlGeneral";
            this.pnlGeneral.Size = new System.Drawing.Size(579, 318);
            this.pnlGeneral.TabIndex = 6;
            // 
            // menuBtnPanel
            // 
            this.menuBtnPanel.Controls.Add(this.btnAbout);
            this.menuBtnPanel.Controls.Add(this.btnHelp);
            this.menuBtnPanel.Controls.Add(this.btnSchedule);
            this.menuBtnPanel.Controls.Add(this.btnCountDown);
            this.menuBtnPanel.Controls.Add(this.btnCountUp);
            this.menuBtnPanel.Controls.Add(this.btnGeneral);
            this.menuBtnPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuBtnPanel.Location = new System.Drawing.Point(0, 0);
            this.menuBtnPanel.Name = "menuBtnPanel";
            this.menuBtnPanel.Size = new System.Drawing.Size(200, 318);
            this.menuBtnPanel.TabIndex = 6;
            // 
            // btnAbout
            // 
            this.btnAbout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAbout.FlatAppearance.BorderSize = 0;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAbout.Location = new System.Drawing.Point(0, 185);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Padding = new System.Windows.Forms.Padding(23, 0, 0, 0);
            this.btnAbout.Size = new System.Drawing.Size(200, 37);
            this.btnAbout.TabIndex = 4;
            this.btnAbout.Text = "About";
            this.btnAbout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnSchedule
            // 
            this.btnSchedule.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSchedule.FlatAppearance.BorderSize = 0;
            this.btnSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSchedule.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSchedule.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSchedule.Location = new System.Drawing.Point(0, 111);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Padding = new System.Windows.Forms.Padding(23, 0, 0, 0);
            this.btnSchedule.Size = new System.Drawing.Size(200, 37);
            this.btnSchedule.TabIndex = 3;
            this.btnSchedule.Text = "Schedule";
            this.btnSchedule.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSchedule.UseVisualStyleBackColor = true;
            this.btnSchedule.Visible = false;
            this.btnSchedule.Click += new System.EventHandler(this.btnSchedule_Click);
            // 
            // btnCountDown
            // 
            this.btnCountDown.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCountDown.FlatAppearance.BorderSize = 0;
            this.btnCountDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCountDown.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCountDown.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCountDown.Location = new System.Drawing.Point(0, 74);
            this.btnCountDown.Name = "btnCountDown";
            this.btnCountDown.Padding = new System.Windows.Forms.Padding(23, 0, 0, 0);
            this.btnCountDown.Size = new System.Drawing.Size(200, 37);
            this.btnCountDown.TabIndex = 2;
            this.btnCountDown.Text = "Count down";
            this.btnCountDown.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCountDown.UseVisualStyleBackColor = true;
            this.btnCountDown.Visible = false;
            this.btnCountDown.Click += new System.EventHandler(this.btnCountDown_Click);
            // 
            // btnCountUp
            // 
            this.btnCountUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCountUp.FlatAppearance.BorderSize = 0;
            this.btnCountUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCountUp.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCountUp.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCountUp.Location = new System.Drawing.Point(0, 37);
            this.btnCountUp.Name = "btnCountUp";
            this.btnCountUp.Padding = new System.Windows.Forms.Padding(23, 0, 0, 0);
            this.btnCountUp.Size = new System.Drawing.Size(200, 37);
            this.btnCountUp.TabIndex = 1;
            this.btnCountUp.Text = "Count up";
            this.btnCountUp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCountUp.UseVisualStyleBackColor = true;
            this.btnCountUp.Visible = false;
            this.btnCountUp.Click += new System.EventHandler(this.btnCountUp_Click);
            // 
            // btnGeneral
            // 
            this.btnGeneral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnGeneral.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGeneral.FlatAppearance.BorderSize = 0;
            this.btnGeneral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeneral.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeneral.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnGeneral.Location = new System.Drawing.Point(0, 0);
            this.btnGeneral.Name = "btnGeneral";
            this.btnGeneral.Padding = new System.Windows.Forms.Padding(23, 0, 0, 0);
            this.btnGeneral.Size = new System.Drawing.Size(200, 37);
            this.btnGeneral.TabIndex = 0;
            this.btnGeneral.Text = "General";
            this.btnGeneral.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGeneral.UseVisualStyleBackColor = false;
            this.btnGeneral.Click += new System.EventHandler(this.btnGeneral_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.panel1.Controls.Add(this.pnlGeneral);
            this.panel1.Controls.Add(this.help1);
            this.panel1.Controls.Add(this.about1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(200, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(579, 318);
            this.panel1.TabIndex = 4;
            // 
            // btnHelp
            // 
            this.btnHelp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnHelp.Location = new System.Drawing.Point(0, 148);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Padding = new System.Windows.Forms.Padding(23, 0, 0, 0);
            this.btnHelp.Size = new System.Drawing.Size(200, 37);
            this.btnHelp.TabIndex = 5;
            this.btnHelp.Text = "Help";
            this.btnHelp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // GeneralSettings1
            // 
            this.GeneralSettings1.AutoSize = true;
            this.GeneralSettings1.Dock = System.Windows.Forms.DockStyle.Top;
            this.GeneralSettings1.Location = new System.Drawing.Point(0, 0);
            this.GeneralSettings1.Name = "GeneralSettings1";
            this.GeneralSettings1.Size = new System.Drawing.Size(562, 624);
            this.GeneralSettings1.TabIndex = 5;
            // 
            // help1
            // 
            this.help1.AutoScroll = true;
            this.help1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.help1.Location = new System.Drawing.Point(0, 0);
            this.help1.Name = "help1";
            this.help1.Size = new System.Drawing.Size(579, 318);
            this.help1.TabIndex = 6;
            // 
            // about1
            // 
            this.about1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.about1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.about1.Location = new System.Drawing.Point(0, 0);
            this.about1.Name = "about1";
            this.about1.Size = new System.Drawing.Size(579, 318);
            this.about1.TabIndex = 6;
            // 
            // SettingsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuBtnPanel);
            this.Name = "SettingsPanel";
            this.Size = new System.Drawing.Size(779, 318);
            this.pnlGeneral.ResumeLayout(false);
            this.pnlGeneral.PerformLayout();
            this.menuBtnPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlGeneral;
        private System.Windows.Forms.Panel menuBtnPanel;
        private System.Windows.Forms.Button btnGeneral;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnSchedule;
        private System.Windows.Forms.Button btnCountDown;
        private System.Windows.Forms.Button btnCountUp;
        private System.Windows.Forms.Panel panel1;
        public controls.GeneralSettings GeneralSettings1;
        private About about1;
        private System.Windows.Forms.Button btnHelp;
        private Help help1;
    }
}
