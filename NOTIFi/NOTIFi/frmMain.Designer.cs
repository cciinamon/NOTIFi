namespace NOTIFi
{
    partial class frmMain
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
            this.grpNew = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addATaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addTodoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personalizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closedToDoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.grpOnGoing = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.grpOnHold = new System.Windows.Forms.GroupBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.grpFinished = new System.Windows.Forms.GroupBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSearch = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.cbLevelPriority = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.btnClear = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpNew
            // 
            this.grpNew.ForeColor = System.Drawing.Color.Black;
            this.grpNew.Location = new System.Drawing.Point(8, 3);
            this.grpNew.Name = "grpNew";
            this.grpNew.Size = new System.Drawing.Size(260, 506);
            this.grpNew.TabIndex = 0;
            this.grpNew.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addATaskToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.signOutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1133, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addATaskToolStripMenuItem
            // 
            this.addATaskToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTodoToolStripMenuItem});
            this.addATaskToolStripMenuItem.Name = "addATaskToolStripMenuItem";
            this.addATaskToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.addATaskToolStripMenuItem.Text = "Add a Task";
            // 
            // addTodoToolStripMenuItem
            // 
            this.addTodoToolStripMenuItem.Name = "addTodoToolStripMenuItem";
            this.addTodoToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.addTodoToolStripMenuItem.Text = "Add to-do";
            this.addTodoToolStripMenuItem.Click += new System.EventHandler(this.addTodoToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personalizeToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // personalizeToolStripMenuItem
            // 
            this.personalizeToolStripMenuItem.Name = "personalizeToolStripMenuItem";
            this.personalizeToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.personalizeToolStripMenuItem.Text = "System Setting";
            this.personalizeToolStripMenuItem.Click += new System.EventHandler(this.personalizeToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closedToDoToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // closedToDoToolStripMenuItem
            // 
            this.closedToDoToolStripMenuItem.Name = "closedToDoToolStripMenuItem";
            this.closedToDoToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.closedToDoToolStripMenuItem.Text = "To-Do List";
            this.closedToDoToolStripMenuItem.Click += new System.EventHandler(this.closedToDoToolStripMenuItem_Click);
            // 
            // signOutToolStripMenuItem
            // 
            this.signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            this.signOutToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.signOutToolStripMenuItem.Text = "Log Out";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(112)))), ((int)(((byte)(147)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(277, 37);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "To-Do | New";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.grpNew);
            this.panel2.Location = new System.Drawing.Point(1, 106);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(277, 519);
            this.panel2.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.grpOnGoing);
            this.panel3.Location = new System.Drawing.Point(284, 106);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(277, 519);
            this.panel3.TabIndex = 8;
            // 
            // grpOnGoing
            // 
            this.grpOnGoing.ForeColor = System.Drawing.Color.Black;
            this.grpOnGoing.Location = new System.Drawing.Point(8, 3);
            this.grpOnGoing.Name = "grpOnGoing";
            this.grpOnGoing.Size = new System.Drawing.Size(260, 506);
            this.grpOnGoing.TabIndex = 0;
            this.grpOnGoing.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(140)))), ((int)(((byte)(116)))));
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(284, 63);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(277, 37);
            this.panel4.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "On-going";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Control;
            this.panel5.Controls.Add(this.grpOnHold);
            this.panel5.Location = new System.Drawing.Point(567, 106);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(277, 519);
            this.panel5.TabIndex = 10;
            // 
            // grpOnHold
            // 
            this.grpOnHold.ForeColor = System.Drawing.Color.Black;
            this.grpOnHold.Location = new System.Drawing.Point(8, 3);
            this.grpOnHold.Name = "grpOnHold";
            this.grpOnHold.Size = new System.Drawing.Size(260, 506);
            this.grpOnHold.TabIndex = 0;
            this.grpOnHold.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.panel6.Controls.Add(this.label3);
            this.panel6.Location = new System.Drawing.Point(567, 63);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(277, 37);
            this.panel6.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "On-hold";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.Control;
            this.panel7.Controls.Add(this.grpFinished);
            this.panel7.Location = new System.Drawing.Point(850, 106);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(277, 519);
            this.panel7.TabIndex = 12;
            // 
            // grpFinished
            // 
            this.grpFinished.ForeColor = System.Drawing.Color.Black;
            this.grpFinished.Location = new System.Drawing.Point(8, 3);
            this.grpFinished.Name = "grpFinished";
            this.grpFinished.Size = new System.Drawing.Size(260, 506);
            this.grpFinished.TabIndex = 0;
            this.grpFinished.TabStop = false;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.panel8.Controls.Add(this.label4);
            this.panel8.Location = new System.Drawing.Point(850, 63);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(277, 37);
            this.panel8.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Finished";
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.CustomBackground = true;
            this.txtSearch.CustomForeColor = true;
            this.txtSearch.Location = new System.Drawing.Point(132, 34);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(311, 23);
            this.txtSearch.TabIndex = 13;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged_1);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(10, 36);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(121, 19);
            this.metroLabel1.TabIndex = 14;
            this.metroLabel1.Text = "Search Task | To-do";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(469, 36);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(100, 19);
            this.metroLabel4.TabIndex = 19;
            this.metroLabel4.Text = "Level of Priority";
            // 
            // cbLevelPriority
            // 
            this.cbLevelPriority.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbLevelPriority.FontSize = MetroFramework.MetroLinkSize.Small;
            this.cbLevelPriority.FormattingEnabled = true;
            this.cbLevelPriority.ItemHeight = 19;
            this.cbLevelPriority.Items.AddRange(new object[] {
            "Critical ",
            "High ",
            "Low"});
            this.cbLevelPriority.Location = new System.Drawing.Point(575, 32);
            this.cbLevelPriority.Name = "cbLevelPriority";
            this.cbLevelPriority.Size = new System.Drawing.Size(163, 25);
            this.cbLevelPriority.TabIndex = 20;
            this.cbLevelPriority.SelectedIndexChanged += new System.EventHandler(this.cbStatus_SelectedIndexChanged);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(965, 36);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(47, 19);
            this.metroLabel5.TabIndex = 21;
            this.metroLabel5.Text = "Notify:";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(1014, 36);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(40, 19);
            this.metroLabel6.TabIndex = 22;
            this.metroLabel6.Text = "00:00";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(760, 32);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(97, 25);
            this.btnClear.TabIndex = 32;
            this.btnClear.Text = "Clear Searches";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1133, 629);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.cbLevelPriority);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NOTIF-i";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpNew;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addATaskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addTodoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personalizeToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox grpOnGoing;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.GroupBox grpOnHold;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.GroupBox grpFinished;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroTextBox txtSearch;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroComboBox cbLevelPriority;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closedToDoToolStripMenuItem;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        public System.Windows.Forms.Button btnClear;
    }
}

