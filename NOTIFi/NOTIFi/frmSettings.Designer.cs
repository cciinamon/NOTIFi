namespace NOTIFi
{
    partial class frmSettings
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
            this.txtServerName = new MetroFramework.Controls.MetroTextBox();
            this.txtUsername = new MetroFramework.Controls.MetroTextBox();
            this.txtPassword = new MetroFramework.Controls.MetroTextBox();
            this.txtDatabaseName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.SystemSetting = new MetroFramework.Controls.MetroTabPage();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.metroTabControl2 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.chkEnableCountdown = new System.Windows.Forms.CheckBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.chkRemindEveryHours = new System.Windows.Forms.CheckBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.txtRemindEveryHours = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.chkDaysBeforeEndDate = new System.Windows.Forms.CheckBox();
            this.metroCheckBox1 = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtDaysBeforeEndDate = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.metroCheckBox2 = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.DatabaseSettings = new MetroFramework.Controls.MetroTabPage();
            this.btnTest = new System.Windows.Forms.Button();
            this.lblStatus = new MetroFramework.Controls.MetroLabel();
            this.metroTabControl1.SuspendLayout();
            this.SystemSetting.SuspendLayout();
            this.metroTabControl2.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.DatabaseSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtServerName
            // 
            this.txtServerName.BackColor = System.Drawing.Color.White;
            this.txtServerName.CustomBackground = true;
            this.txtServerName.CustomForeColor = true;
            this.txtServerName.Location = new System.Drawing.Point(210, 36);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Size = new System.Drawing.Size(287, 23);
            this.txtServerName.TabIndex = 0;
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.White;
            this.txtUsername.CustomBackground = true;
            this.txtUsername.CustomForeColor = true;
            this.txtUsername.Location = new System.Drawing.Point(210, 65);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(287, 23);
            this.txtUsername.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.CustomBackground = true;
            this.txtPassword.CustomForeColor = true;
            this.txtPassword.Location = new System.Drawing.Point(210, 94);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(287, 23);
            this.txtPassword.TabIndex = 2;
            // 
            // txtDatabaseName
            // 
            this.txtDatabaseName.BackColor = System.Drawing.Color.White;
            this.txtDatabaseName.CustomBackground = true;
            this.txtDatabaseName.CustomForeColor = true;
            this.txtDatabaseName.Location = new System.Drawing.Point(210, 123);
            this.txtDatabaseName.Name = "txtDatabaseName";
            this.txtDatabaseName.Size = new System.Drawing.Size(287, 23);
            this.txtDatabaseName.TabIndex = 3;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(70, 40);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(87, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Server Name";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(68, 69);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(68, 19);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "Username";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(70, 98);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(63, 19);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "Password";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(70, 127);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(103, 19);
            this.metroLabel4.TabIndex = 7;
            this.metroLabel4.Text = "Database Name";
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.SystemSetting);
            this.metroTabControl1.Controls.Add(this.DatabaseSettings);
            this.metroTabControl1.Location = new System.Drawing.Point(12, 12);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(582, 365);
            this.metroTabControl1.TabIndex = 8;
            // 
            // SystemSetting
            // 
            this.SystemSetting.Controls.Add(this.btnApply);
            this.SystemSetting.Controls.Add(this.btnSave);
            this.SystemSetting.Controls.Add(this.metroTabControl2);
            this.SystemSetting.HorizontalScrollbarBarColor = true;
            this.SystemSetting.Location = new System.Drawing.Point(4, 35);
            this.SystemSetting.Name = "SystemSetting";
            this.SystemSetting.Size = new System.Drawing.Size(574, 326);
            this.SystemSetting.TabIndex = 0;
            this.SystemSetting.Text = "System Setting";
            this.SystemSetting.VerticalScrollbarBarColor = true;
            // 
            // btnApply
            // 
            this.btnApply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.btnApply.FlatAppearance.BorderSize = 0;
            this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApply.ForeColor = System.Drawing.Color.White;
            this.btnApply.Location = new System.Drawing.Point(326, 292);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(123, 31);
            this.btnApply.TabIndex = 11;
            this.btnApply.Text = "Apply Changes";
            this.btnApply.UseVisualStyleBackColor = false;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(455, 292);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(123, 31);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // metroTabControl2
            // 
            this.metroTabControl2.Controls.Add(this.metroTabPage1);
            this.metroTabControl2.Controls.Add(this.metroTabPage2);
            this.metroTabControl2.Location = new System.Drawing.Point(3, 13);
            this.metroTabControl2.Name = "metroTabControl2";
            this.metroTabControl2.SelectedIndex = 0;
            this.metroTabControl2.Size = new System.Drawing.Size(575, 273);
            this.metroTabControl2.TabIndex = 2;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.metroLabel9);
            this.metroTabPage1.Controls.Add(this.chkEnableCountdown);
            this.metroTabPage1.Controls.Add(this.metroLabel11);
            this.metroTabPage1.Controls.Add(this.chkRemindEveryHours);
            this.metroTabPage1.Controls.Add(this.metroLabel8);
            this.metroTabPage1.Controls.Add(this.txtRemindEveryHours);
            this.metroTabPage1.Controls.Add(this.chkDaysBeforeEndDate);
            this.metroTabPage1.Controls.Add(this.metroCheckBox1);
            this.metroTabPage1.Controls.Add(this.metroLabel6);
            this.metroTabPage1.Controls.Add(this.txtDaysBeforeEndDate);
            this.metroTabPage1.Controls.Add(this.metroLabel5);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(567, 234);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Time";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            // 
            // chkEnableCountdown
            // 
            this.chkEnableCountdown.AutoSize = true;
            this.chkEnableCountdown.Location = new System.Drawing.Point(46, 72);
            this.chkEnableCountdown.Name = "chkEnableCountdown";
            this.chkEnableCountdown.Size = new System.Drawing.Size(15, 14);
            this.chkEnableCountdown.TabIndex = 17;
            this.chkEnableCountdown.UseVisualStyleBackColor = true;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(61, 68);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(225, 19);
            this.metroLabel11.TabIndex = 15;
            this.metroLabel11.Text = "Enable countdown in on-going task/s";
            // 
            // chkRemindEveryHours
            // 
            this.chkRemindEveryHours.AutoSize = true;
            this.chkRemindEveryHours.BackColor = System.Drawing.Color.White;
            this.chkRemindEveryHours.Location = new System.Drawing.Point(46, 47);
            this.chkRemindEveryHours.Name = "chkRemindEveryHours";
            this.chkRemindEveryHours.Size = new System.Drawing.Size(29, 17);
            this.chkRemindEveryHours.TabIndex = 13;
            this.chkRemindEveryHours.Text = " ";
            this.chkRemindEveryHours.UseVisualStyleBackColor = false;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(363, 43);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(46, 19);
            this.metroLabel8.TabIndex = 12;
            this.metroLabel8.Text = "hour/s";
            // 
            // txtRemindEveryHours
            // 
            this.txtRemindEveryHours.BackColor = System.Drawing.Color.White;
            this.txtRemindEveryHours.CustomBackground = true;
            this.txtRemindEveryHours.CustomForeColor = true;
            this.txtRemindEveryHours.Location = new System.Drawing.Point(295, 39);
            this.txtRemindEveryHours.Name = "txtRemindEveryHours";
            this.txtRemindEveryHours.Size = new System.Drawing.Size(66, 23);
            this.txtRemindEveryHours.TabIndex = 10;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(61, 43);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(233, 19);
            this.metroLabel9.TabIndex = 11;
            this.metroLabel9.Text = "If task in on-going remind task/s every";
            // 
            // chkDaysBeforeEndDate
            // 
            this.chkDaysBeforeEndDate.AutoSize = true;
            this.chkDaysBeforeEndDate.Location = new System.Drawing.Point(46, 21);
            this.chkDaysBeforeEndDate.Name = "chkDaysBeforeEndDate";
            this.chkDaysBeforeEndDate.Size = new System.Drawing.Size(15, 14);
            this.chkDaysBeforeEndDate.TabIndex = 9;
            this.chkDaysBeforeEndDate.UseVisualStyleBackColor = true;
            // 
            // metroCheckBox1
            // 
            this.metroCheckBox1.AutoSize = true;
            this.metroCheckBox1.Location = new System.Drawing.Point(43, 21);
            this.metroCheckBox1.Name = "metroCheckBox1";
            this.metroCheckBox1.Size = new System.Drawing.Size(16, 0);
            this.metroCheckBox1.TabIndex = 8;
            this.metroCheckBox1.UseVisualStyleBackColor = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(287, 17);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(139, 19);
            this.metroLabel6.TabIndex = 7;
            this.metroLabel6.Text = "day/s before end date";
            // 
            // txtDaysBeforeEndDate
            // 
            this.txtDaysBeforeEndDate.BackColor = System.Drawing.Color.White;
            this.txtDaysBeforeEndDate.CustomBackground = true;
            this.txtDaysBeforeEndDate.CustomForeColor = true;
            this.txtDaysBeforeEndDate.Location = new System.Drawing.Point(221, 13);
            this.txtDaysBeforeEndDate.Name = "txtDaysBeforeEndDate";
            this.txtDaysBeforeEndDate.Size = new System.Drawing.Size(66, 23);
            this.txtDaysBeforeEndDate.TabIndex = 5;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(61, 17);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(159, 19);
            this.metroLabel5.TabIndex = 6;
            this.metroLabel5.Text = "If task is on-going remind";
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.checkBox2);
            this.metroTabPage2.Controls.Add(this.metroCheckBox2);
            this.metroTabPage2.Controls.Add(this.metroLabel7);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(567, 234);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Personalize";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(17, 32);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 12;
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // metroCheckBox2
            // 
            this.metroCheckBox2.AutoSize = true;
            this.metroCheckBox2.Location = new System.Drawing.Point(14, 32);
            this.metroCheckBox2.Name = "metroCheckBox2";
            this.metroCheckBox2.Size = new System.Drawing.Size(16, 0);
            this.metroCheckBox2.TabIndex = 11;
            this.metroCheckBox2.UseVisualStyleBackColor = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(32, 28);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(113, 19);
            this.metroLabel7.TabIndex = 10;
            this.metroLabel7.Text = "Set to Dark Mode";
            // 
            // DatabaseSettings
            // 
            this.DatabaseSettings.Controls.Add(this.btnTest);
            this.DatabaseSettings.Controls.Add(this.lblStatus);
            this.DatabaseSettings.Controls.Add(this.metroLabel4);
            this.DatabaseSettings.Controls.Add(this.metroLabel3);
            this.DatabaseSettings.Controls.Add(this.txtServerName);
            this.DatabaseSettings.Controls.Add(this.metroLabel2);
            this.DatabaseSettings.Controls.Add(this.txtUsername);
            this.DatabaseSettings.Controls.Add(this.metroLabel1);
            this.DatabaseSettings.Controls.Add(this.txtPassword);
            this.DatabaseSettings.Controls.Add(this.txtDatabaseName);
            this.DatabaseSettings.HorizontalScrollbarBarColor = true;
            this.DatabaseSettings.Location = new System.Drawing.Point(4, 35);
            this.DatabaseSettings.Name = "DatabaseSettings";
            this.DatabaseSettings.Size = new System.Drawing.Size(574, 326);
            this.DatabaseSettings.TabIndex = 1;
            this.DatabaseSettings.Text = "Database Settings";
            this.DatabaseSettings.VerticalScrollbarBarColor = true;
            // 
            // btnTest
            // 
            this.btnTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.btnTest.FlatAppearance.BorderSize = 0;
            this.btnTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTest.ForeColor = System.Drawing.Color.White;
            this.btnTest.Location = new System.Drawing.Point(372, 180);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(125, 31);
            this.btnTest.TabIndex = 9;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = false;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.White;
            this.lblStatus.CustomBackground = true;
            this.lblStatus.CustomForeColor = true;
            this.lblStatus.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.lblStatus.Location = new System.Drawing.Point(210, 149);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(148, 19);
            this.lblStatus.TabIndex = 8;
            this.lblStatus.Text = "Connection Successful!";
            this.lblStatus.Visible = false;
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(606, 389);
            this.Controls.Add(this.metroTabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.metroTabControl1.ResumeLayout(false);
            this.SystemSetting.ResumeLayout(false);
            this.metroTabControl2.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            this.DatabaseSettings.ResumeLayout(false);
            this.DatabaseSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtServerName;
        private MetroFramework.Controls.MetroTextBox txtUsername;
        private MetroFramework.Controls.MetroTextBox txtPassword;
        private MetroFramework.Controls.MetroTextBox txtDatabaseName;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage SystemSetting;
        private MetroFramework.Controls.MetroTabPage DatabaseSettings;
        private System.Windows.Forms.Button btnTest;
        private MetroFramework.Controls.MetroLabel lblStatus;
        private System.Windows.Forms.Button btnSave;
        private MetroFramework.Controls.MetroTabControl metroTabControl2;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTextBox txtDaysBeforeEndDate;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private System.Windows.Forms.CheckBox chkDaysBeforeEndDate;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox1;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.CheckBox checkBox2;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox2;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private System.Windows.Forms.CheckBox chkRemindEveryHours;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox txtRemindEveryHours;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private System.Windows.Forms.CheckBox chkEnableCountdown;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private System.Windows.Forms.Button btnApply;
    }
}