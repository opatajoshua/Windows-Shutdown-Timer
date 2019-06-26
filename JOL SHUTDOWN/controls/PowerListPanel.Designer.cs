namespace JOL_SHUTDOWN.controls
{
    partial class PowerListPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PowerListPanel));
            this.Lock = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SignOut = new System.Windows.Forms.Button();
            this.Sleep = new System.Windows.Forms.Button();
            this.Hibernate = new System.Windows.Forms.Button();
            this.ShutDownNormal = new System.Windows.Forms.Button();
            this.ShutDownForcibly = new System.Windows.Forms.Button();
            this.Restart = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Alert = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lock
            // 
            this.Lock.Dock = System.Windows.Forms.DockStyle.Top;
            this.Lock.FlatAppearance.BorderSize = 0;
            this.Lock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.Lock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lock.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lock.ForeColor = System.Drawing.Color.Gainsboro;
            this.Lock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lock.ImageKey = "(none)";
            this.Lock.ImageList = this.imageList1;
            this.Lock.Location = new System.Drawing.Point(0, 26);
            this.Lock.Name = "Lock";
            this.Lock.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.Lock.Size = new System.Drawing.Size(134, 26);
            this.Lock.TabIndex = 0;
            this.Lock.Text = "Lock";
            this.Lock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Lock.UseVisualStyleBackColor = true;
            this.Lock.Click += new System.EventHandler(this.button1_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "gen.png");
            this.imageList1.Images.SetKeyName(1, "enlarge3.ico");
            this.imageList1.Images.SetKeyName(2, "pause1.ico");
            this.imageList1.Images.SetKeyName(3, "play1.ico");
            this.imageList1.Images.SetKeyName(4, "stop.ico");
            // 
            // SignOut
            // 
            this.SignOut.Dock = System.Windows.Forms.DockStyle.Top;
            this.SignOut.FlatAppearance.BorderSize = 0;
            this.SignOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.SignOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignOut.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignOut.ForeColor = System.Drawing.Color.Gainsboro;
            this.SignOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SignOut.ImageKey = "(none)";
            this.SignOut.ImageList = this.imageList1;
            this.SignOut.Location = new System.Drawing.Point(0, 52);
            this.SignOut.Name = "SignOut";
            this.SignOut.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.SignOut.Size = new System.Drawing.Size(134, 26);
            this.SignOut.TabIndex = 1;
            this.SignOut.Text = "Sign out";
            this.SignOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SignOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SignOut.UseVisualStyleBackColor = true;
            this.SignOut.Click += new System.EventHandler(this.button1_Click);
            // 
            // Sleep
            // 
            this.Sleep.Dock = System.Windows.Forms.DockStyle.Top;
            this.Sleep.FlatAppearance.BorderSize = 0;
            this.Sleep.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.Sleep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sleep.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sleep.ForeColor = System.Drawing.Color.Gainsboro;
            this.Sleep.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Sleep.ImageKey = "(none)";
            this.Sleep.ImageList = this.imageList1;
            this.Sleep.Location = new System.Drawing.Point(0, 78);
            this.Sleep.Name = "Sleep";
            this.Sleep.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.Sleep.Size = new System.Drawing.Size(134, 26);
            this.Sleep.TabIndex = 2;
            this.Sleep.Text = "Sleep";
            this.Sleep.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Sleep.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Sleep.UseVisualStyleBackColor = true;
            this.Sleep.Click += new System.EventHandler(this.button1_Click);
            // 
            // Hibernate
            // 
            this.Hibernate.Dock = System.Windows.Forms.DockStyle.Top;
            this.Hibernate.FlatAppearance.BorderSize = 0;
            this.Hibernate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.Hibernate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Hibernate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hibernate.ForeColor = System.Drawing.Color.Gainsboro;
            this.Hibernate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Hibernate.ImageKey = "(none)";
            this.Hibernate.ImageList = this.imageList1;
            this.Hibernate.Location = new System.Drawing.Point(0, 104);
            this.Hibernate.Name = "Hibernate";
            this.Hibernate.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.Hibernate.Size = new System.Drawing.Size(134, 26);
            this.Hibernate.TabIndex = 3;
            this.Hibernate.Text = "Hibernate";
            this.Hibernate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Hibernate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Hibernate.UseVisualStyleBackColor = true;
            this.Hibernate.Click += new System.EventHandler(this.button1_Click);
            // 
            // ShutDownNormal
            // 
            this.ShutDownNormal.Dock = System.Windows.Forms.DockStyle.Top;
            this.ShutDownNormal.FlatAppearance.BorderSize = 0;
            this.ShutDownNormal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.ShutDownNormal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShutDownNormal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShutDownNormal.ForeColor = System.Drawing.Color.Gainsboro;
            this.ShutDownNormal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ShutDownNormal.ImageKey = "(none)";
            this.ShutDownNormal.ImageList = this.imageList1;
            this.ShutDownNormal.Location = new System.Drawing.Point(0, 130);
            this.ShutDownNormal.Name = "ShutDownNormal";
            this.ShutDownNormal.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.ShutDownNormal.Size = new System.Drawing.Size(134, 26);
            this.ShutDownNormal.TabIndex = 4;
            this.ShutDownNormal.Text = "Normal shutdown";
            this.ShutDownNormal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ShutDownNormal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ShutDownNormal.UseVisualStyleBackColor = true;
            this.ShutDownNormal.Click += new System.EventHandler(this.button1_Click);
            // 
            // ShutDownForcibly
            // 
            this.ShutDownForcibly.Dock = System.Windows.Forms.DockStyle.Top;
            this.ShutDownForcibly.FlatAppearance.BorderSize = 0;
            this.ShutDownForcibly.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.ShutDownForcibly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShutDownForcibly.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShutDownForcibly.ForeColor = System.Drawing.Color.Gainsboro;
            this.ShutDownForcibly.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ShutDownForcibly.ImageKey = "(none)";
            this.ShutDownForcibly.ImageList = this.imageList1;
            this.ShutDownForcibly.Location = new System.Drawing.Point(0, 156);
            this.ShutDownForcibly.Name = "ShutDownForcibly";
            this.ShutDownForcibly.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.ShutDownForcibly.Size = new System.Drawing.Size(134, 26);
            this.ShutDownForcibly.TabIndex = 5;
            this.ShutDownForcibly.Text = "Force Shutdown";
            this.ShutDownForcibly.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ShutDownForcibly.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ShutDownForcibly.UseVisualStyleBackColor = true;
            this.ShutDownForcibly.Click += new System.EventHandler(this.button1_Click);
            // 
            // Restart
            // 
            this.Restart.Dock = System.Windows.Forms.DockStyle.Top;
            this.Restart.FlatAppearance.BorderSize = 0;
            this.Restart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.Restart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Restart.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Restart.ForeColor = System.Drawing.Color.Gainsboro;
            this.Restart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Restart.ImageKey = "(none)";
            this.Restart.ImageList = this.imageList1;
            this.Restart.Location = new System.Drawing.Point(0, 182);
            this.Restart.Name = "Restart";
            this.Restart.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.Restart.Size = new System.Drawing.Size(134, 26);
            this.Restart.TabIndex = 6;
            this.Restart.Text = "Restart";
            this.Restart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Restart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Restart.UseVisualStyleBackColor = true;
            this.Restart.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.panel1.Controls.Add(this.Restart);
            this.panel1.Controls.Add(this.ShutDownForcibly);
            this.panel1.Controls.Add(this.ShutDownNormal);
            this.panel1.Controls.Add(this.Hibernate);
            this.panel1.Controls.Add(this.Sleep);
            this.panel1.Controls.Add(this.SignOut);
            this.panel1.Controls.Add(this.Lock);
            this.panel1.Controls.Add(this.Alert);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(134, 209);
            this.panel1.TabIndex = 7;
            // 
            // Alert
            // 
            this.Alert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(83)))), ((int)(((byte)(123)))));
            this.Alert.Dock = System.Windows.Forms.DockStyle.Top;
            this.Alert.FlatAppearance.BorderSize = 0;
            this.Alert.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.Alert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Alert.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Alert.ForeColor = System.Drawing.Color.Gainsboro;
            this.Alert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Alert.ImageKey = "(none)";
            this.Alert.ImageList = this.imageList1;
            this.Alert.Location = new System.Drawing.Point(0, 0);
            this.Alert.Name = "Alert";
            this.Alert.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.Alert.Size = new System.Drawing.Size(134, 26);
            this.Alert.TabIndex = 7;
            this.Alert.Text = "Alert";
            this.Alert.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Alert.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Alert.UseVisualStyleBackColor = false;
            this.Alert.Click += new System.EventHandler(this.button1_Click);
            // 
            // PowerListPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(122)))), ((int)(((byte)(203)))));
            this.Controls.Add(this.panel1);
            this.Name = "PowerListPanel";
            this.Size = new System.Drawing.Size(136, 211);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        public System.Windows.Forms.Button Lock;
        public System.Windows.Forms.Button SignOut;
        public System.Windows.Forms.Button Sleep;
        public System.Windows.Forms.Button Hibernate;
        public System.Windows.Forms.Button ShutDownNormal;
        public System.Windows.Forms.Button ShutDownForcibly;
        public System.Windows.Forms.Button Restart;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button Alert;
    }
}
