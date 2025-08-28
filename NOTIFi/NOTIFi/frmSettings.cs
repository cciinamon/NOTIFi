using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace NOTIFi
{
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
            LoadConnection();
            lblStatus.Visible = false;

            LoadSystemSetting();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            string server = txtServerName.Text.Trim();
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string database = txtDatabaseName.Text.Trim();

            string connStr = $"Server={server};Database={database};User Id={username};Password={password};";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    lblStatus.Visible = true;
                    lblStatus.Text = "Connection Successful ✅";

                    SaveConnection(server, database, username, password);

                    // Update globals
                    Globals.ServerName = server;
                    Globals.Username = username;
                    Globals.Password = password;
                    Globals.DBName = database;
                    Globals.ConnectionString = connStr;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection Failed: " + ex.Message, "Error");
                    lblStatus.Visible = false;
                }
            }
        }

        private void SaveConnection(string server, string database, string username, string password)
        {
            string newConn = $"Server={server};Database={database};User Id={username};Password={password};";

            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.ConnectionStrings.ConnectionStrings["MyDBConnection"].ConnectionString = newConn;
            config.Save(ConfigurationSaveMode.Modified, true);
            ConfigurationManager.RefreshSection("connectionStrings");
        }

        public void LoadConnection()
        {
            var connStr = ConfigurationManager.ConnectionStrings["MyDBConnection"]?.ConnectionString;

            if (!string.IsNullOrEmpty(connStr))
            {
                var builder = new SqlConnectionStringBuilder(connStr);

                txtServerName.Text = builder.DataSource;
                txtDatabaseName.Text = builder.InitialCatalog;
                txtUsername.Text = builder.UserID;
                txtPassword.Text = builder.Password;

                Globals.ServerName = builder.DataSource;
                Globals.Username = builder.UserID;
                Globals.Password = builder.Password;
                Globals.DBName = builder.InitialCatalog;

                Globals.ConnectionString = connStr;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveSettings();
            this.Close();
        }

        private void LoadSystemSetting()
        {
            txtDaysBeforeEndDate.Text = Globals.db.GetSystemSetting("RemindDaysBeforeEndDate");
            chkRemindEveryHours.Checked = Globals.db.GetSystemSetting("EnableRemindEveryHours") == "1";
            txtRemindEveryHours.Text = Globals.db.GetSystemSetting("RemindEveryHours");
            chkDaysBeforeEndDate.Checked = Globals.db.GetSystemSetting("EnableRemindDaysBeforeEndDate") == "1";
            chkEnableCountdown.Checked = Globals.db.GetSystemSetting("EnableCountdown") == "1";

        }

        private void SaveSettings()
        {
            Globals.db.UpsertSystemSetting(Globals.User_ID, "RemindDaysBeforeEndDate", txtDaysBeforeEndDate.Text);
            Globals.db.UpsertSystemSetting(Globals.User_ID, "RemindEveryHours", txtRemindEveryHours.Text);
            Globals.db.UpsertSystemSetting(Globals.User_ID, "EnableRemindEveryHours", chkRemindEveryHours.Checked ? "1" : "0");
            Globals.db.UpsertSystemSetting(Globals.User_ID, "EnableRemindDaysBeforeEndDate", chkDaysBeforeEndDate.Checked ? "1" : "0");
            Globals.db.UpsertSystemSetting(Globals.User_ID, "EnableCountdown", chkEnableCountdown.Checked ? "1" : "0");
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            SaveSettings();
        }
    }
}
