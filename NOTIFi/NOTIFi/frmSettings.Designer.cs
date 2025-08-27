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
            this.Personalize = new MetroFramework.Controls.MetroTabPage();
            this.DatabaseSettings = new MetroFramework.Controls.MetroTabPage();
            this.lblStatus = new MetroFramework.Controls.MetroLabel();
            this.btnTest = new System.Windows.Forms.Button();
            this.metroTabControl1.SuspendLayout();
            this.DatabaseSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtServerName
            // 
            this.txtServerName.BackColor = System.Drawing.Color.White;
            this.txtServerName.CustomBackground = true;
            this.txtServerName.CustomForeColor = true;
            this.txtServerName.Location = new System.Drawing.Point(162, 32);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Size = new System.Drawing.Size(287, 23);
            this.txtServerName.TabIndex = 0;
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.White;
            this.txtUsername.CustomBackground = true;
            this.txtUsername.CustomForeColor = true;
            this.txtUsername.Location = new System.Drawing.Point(162, 61);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(287, 23);
            this.txtUsername.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.CustomBackground = true;
            this.txtPassword.CustomForeColor = true;
            this.txtPassword.Location = new System.Drawing.Point(162, 90);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(287, 23);
            this.txtPassword.TabIndex = 2;
            // 
            // txtDatabaseName
            // 
            this.txtDatabaseName.BackColor = System.Drawing.Color.White;
            this.txtDatabaseName.CustomBackground = true;
            this.txtDatabaseName.CustomForeColor = true;
            this.txtDatabaseName.Location = new System.Drawing.Point(162, 119);
            this.txtDatabaseName.Name = "txtDatabaseName";
            this.txtDatabaseName.Size = new System.Drawing.Size(287, 23);
            this.txtDatabaseName.TabIndex = 3;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(22, 36);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(87, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Server Name";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(20, 65);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(68, 19);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "Username";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(22, 94);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(63, 19);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "Password";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(22, 123);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(103, 19);
            this.metroLabel4.TabIndex = 7;
            this.metroLabel4.Text = "Database Name";
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.Personalize);
            this.metroTabControl1.Controls.Add(this.DatabaseSettings);
            this.metroTabControl1.Location = new System.Drawing.Point(12, 12);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(492, 265);
            this.metroTabControl1.TabIndex = 8;
            // 
            // Personalize
            // 
            this.Personalize.HorizontalScrollbarBarColor = true;
            this.Personalize.Location = new System.Drawing.Point(4, 35);
            this.Personalize.Name = "Personalize";
            this.Personalize.Size = new System.Drawing.Size(484, 226);
            this.Personalize.TabIndex = 0;
            this.Personalize.Text = "Personalize";
            this.Personalize.VerticalScrollbarBarColor = true;
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
            this.DatabaseSettings.Size = new System.Drawing.Size(484, 226);
            this.DatabaseSettings.TabIndex = 1;
            this.DatabaseSettings.Text = "Database Settings";
            this.DatabaseSettings.VerticalScrollbarBarColor = true;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.White;
            this.lblStatus.CustomBackground = true;
            this.lblStatus.CustomForeColor = true;
            this.lblStatus.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.lblStatus.Location = new System.Drawing.Point(162, 145);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(148, 19);
            this.lblStatus.TabIndex = 8;
            this.lblStatus.Text = "Connection Successful!";
            this.lblStatus.Visible = false;
            // 
            // btnTest
            // 
            this.btnTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.btnTest.FlatAppearance.BorderSize = 0;
            this.btnTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTest.ForeColor = System.Drawing.Color.White;
            this.btnTest.Location = new System.Drawing.Point(326, 167);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(123, 31);
            this.btnTest.TabIndex = 9;
            this.btnTest.Text = "Save";
            this.btnTest.UseVisualStyleBackColor = false;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(519, 287);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "frmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.metroTabControl1.ResumeLayout(false);
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
        private MetroFramework.Controls.MetroTabPage Personalize;
        private MetroFramework.Controls.MetroTabPage DatabaseSettings;
        private System.Windows.Forms.Button btnTest;
        private MetroFramework.Controls.MetroLabel lblStatus;
    }
}