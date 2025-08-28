using NOTIFi.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Tulpep.NotificationWindow;

namespace NOTIFi
{
    public partial class frmMain : Form
    {

        frmSettings settings = new frmSettings();

        public frmMain()
        {
            InitializeComponent();
            Globals.settings.LoadConnection();

            LoadNewTasks();
            LoadOnGoingTasks();
            LoadOnHoldTasks();
            LoadFinishedTasks();
            CheckDueTasks();

        }

        private void addTodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTasks tasks = new frmTasks(this);
            tasks.lblID.Visible = false;
            tasks.btnClose.Visible = false;
            tasks.ShowDialog();
        }

        public void LoadNewTasks(string searchText = "", string searchMode = "")
        {
            grpNew.Controls.Clear(); // Clear previous panels if reloaded

            try
            {
                DataTable dt = Globals.db.GetNewTask(searchText, searchMode); 

                if (dt != null && dt.Rows.Count > 0)
                {
                    int y = 20; 

                    foreach (DataRow row in dt.Rows)
                    {
                        int id = Convert.ToInt32(row["id"]);
                        string title = row["title"].ToString();
                        string levelPriority = row["levelPriority"].ToString();
                        string startDate = row["targetStartDate"].ToString();
                        string endDate = row["targetEndDate"].ToString();
                        string description = row["description"].ToString();
                        string status = row["status"].ToString();
                        string subject = row["subject"].ToString();

                        // Create panel
                        // Panel panel = new Panel();

                        Design panel = new Design
                        {
                            Size = new Size(300, 80),
                            Location = new Point(10, y),
                            BorderColor = Color.White, // customize
                            CornerRadius = 10,
                            BorderThickness = 2,
                            BackColor = Color.White
                        };

                        
                        panel.BackColor = Color.White;
                        panel.Size = new Size(240, 100);
                        panel.Location = new Point(10, y);


                        Label lblId = new Label
                        {
                            Text = "TO-DO#: " + id.ToString(),
                            Location = new Point(10, 10),
                            AutoSize = true,
                            ForeColor = Color.Gray
                        };

                        Label lblTitle = new Label
                        {
                            Text = "Title: " + title,
                            Location = new Point(10, 25),
                            AutoSize = true,
                            Font = new Font("Segoe UI", 10, FontStyle.Bold)
                        };

                        Label lblDesc = new Label
                        {
                            Text = "Priority: " + levelPriority,
                            Location = new Point(10, 45),
                            AutoSize = true
                        };

                        // Change background + foreground depending on levelPriority
                        if (levelPriority.Equals("Critical", StringComparison.OrdinalIgnoreCase))
                        {
                            lblDesc.BackColor = Color.Red;
                            lblDesc.ForeColor = Color.White;
                        }
                        else if (levelPriority.Equals("High", StringComparison.OrdinalIgnoreCase))
                        {
                            lblDesc.BackColor = Color.Maroon;
                            lblDesc.ForeColor = Color.White;
                        }
                        else if (levelPriority.Equals("Low", StringComparison.OrdinalIgnoreCase))
                        {
                            lblDesc.BackColor = Color.Green;
                            lblDesc.ForeColor = Color.White;
                        }

                        Label lblStartDate = new Label
                        {
                            Text = "Target Start Date: " + startDate,
                            Location = new Point(10, 60),
                            AutoSize = true
                        };

                        Label lblEndDate = new Label
                        {
                            Text = "Target End Date: " + endDate,
                            Location = new Point(10, 75),
                            AutoSize = true
                        };

                        // Add labels to panel
                        panel.Controls.Add(lblId);
                        panel.Controls.Add(lblTitle);
                        panel.Controls.Add(lblDesc);
                        panel.Controls.Add(lblStartDate);
                        panel.Controls.Add(lblEndDate);


                        // Optional click event
                        panel.Click += (s, e) =>
                        {
                            //MessageBox.Show($"You clicked task {id}: {title}");
                            frmTasks taskForm = new frmTasks(this, id, title, description, subject, status, levelPriority, startDate, endDate);
                            taskForm.btnClose.Visible = true;
                            taskForm.ShowDialog();
                        };

                        // Add panel to groupbox
                        grpNew.Controls.Add(panel);

                        y += panel.Height + 10; // move down for next panel
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading tasks: " + ex.Message);
            }
        }

        public void LoadOnGoingTasks(string searchText = "", string searchMode = "")
        {
            grpOnGoing.Controls.Clear(); // Clear previous panels if reloaded

            try
            {
                DataTable dt = Globals.db.GetOnGoingTask(searchText, searchMode);

                if (dt != null && dt.Rows.Count > 0)
                {
                    int y = 20;

                    foreach (DataRow row in dt.Rows)
                    {
                        int id = Convert.ToInt32(row["id"]);
                        string title = row["title"].ToString();
                        string levelPriority = row["levelPriority"].ToString();
                        string startDate = row["targetStartDate"].ToString();
                        string endDate = row["targetEndDate"].ToString();
                        string description = row["description"].ToString();
                        string status = row["status"].ToString();
                        string subject = row["subject"].ToString();

                        // Create panel
                        // Panel panel = new Panel();

                        Design panel = new Design
                        {
                            Size = new Size(300, 80),
                            Location = new Point(10, y),
                            BorderColor = Color.White, // customize
                            CornerRadius = 10,
                            BorderThickness = 2,
                            BackColor = Color.White
                        };


                        panel.BackColor = Color.White;
                        panel.Size = new Size(240, 100);
                        panel.Location = new Point(10, y);


                        Label lblId = new Label
                        {
                            Text = "TO-DO#: " + id.ToString(),
                            Location = new Point(10, 10),
                            AutoSize = true,
                            ForeColor = Color.Gray
                        };

                        Label lblTitle = new Label
                        {
                            Text = "Title: " + title,
                            Location = new Point(10, 25),
                            AutoSize = true,
                            Font = new Font("Segoe UI", 10, FontStyle.Bold)
                        };

                        Label lblDesc = new Label
                        {
                            Text = "Priority: " + levelPriority,
                            Location = new Point(10, 45),
                            AutoSize = true
                        };

                        // Change background + foreground depending on levelPriority
                        if (levelPriority.Equals("Critical", StringComparison.OrdinalIgnoreCase))
                        {
                            lblDesc.BackColor = Color.Red;
                            lblDesc.ForeColor = Color.White;
                        }
                        else if (levelPriority.Equals("High", StringComparison.OrdinalIgnoreCase))
                        {
                            lblDesc.BackColor = Color.Maroon;
                            lblDesc.ForeColor = Color.White;
                        }
                        else if (levelPriority.Equals("Low", StringComparison.OrdinalIgnoreCase))
                        {
                            lblDesc.BackColor = Color.Green;
                            lblDesc.ForeColor = Color.White;
                        }

                        Label lblStartDate = new Label
                        {
                            Text = "Target Start Date: " + startDate,
                            Location = new Point(10, 60),
                            AutoSize = true
                        };

                        Label lblEndDate = new Label
                        {
                            Text = "Target End Date: " + endDate,
                            Location = new Point(10, 75),
                            AutoSize = true
                        };

                        // Add labels to panel
                        panel.Controls.Add(lblId);
                        panel.Controls.Add(lblTitle);
                        panel.Controls.Add(lblDesc);
                        panel.Controls.Add(lblStartDate);
                        panel.Controls.Add(lblEndDate);


                        // Optional click event
                        panel.Click += (s, e) =>
                        {
                            //MessageBox.Show($"You clicked task {id}: {title}");
                            frmTasks taskForm = new frmTasks(this, id, title, description, subject, status, levelPriority, startDate, endDate);
                            taskForm.btnClose.Visible = true;
                            taskForm.ShowDialog();
                        };

                        // Add panel to groupbox
                        grpOnGoing.Controls.Add(panel);

                        y += panel.Height + 10; // move down for next panel
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading tasks: " + ex.Message);
            }
        }

        public void LoadOnHoldTasks(string searchText = "", string searchMode = "")
        {
            grpOnHold.Controls.Clear(); // Clear previous panels if reloaded

            try
            {
                DataTable dt = Globals.db.GetOnHoldTask(searchText, searchMode);

                if (dt != null && dt.Rows.Count > 0)
                {
                    int y = 20;

                    foreach (DataRow row in dt.Rows)
                    {
                        int id = Convert.ToInt32(row["id"]);
                        string title = row["title"].ToString();
                        string levelPriority = row["levelPriority"].ToString();
                        string startDate = row["targetStartDate"].ToString();
                        string endDate = row["targetEndDate"].ToString();
                        string description = row["description"].ToString();
                        string status = row["status"].ToString();
                        string subject = row["subject"].ToString();

                        // Create panel
                        // Panel panel = new Panel();

                        Design panel = new Design
                        {
                            Size = new Size(300, 80),
                            Location = new Point(10, y),
                            BorderColor = Color.White, // customize
                            CornerRadius = 10,
                            BorderThickness = 2,
                            BackColor = Color.White
                        };


                        panel.BackColor = Color.White;
                        panel.Size = new Size(240, 100);
                        panel.Location = new Point(10, y);


                        Label lblId = new Label
                        {
                            Text = "TO-DO#: " + id.ToString(),
                            Location = new Point(10, 10),
                            AutoSize = true,
                            ForeColor = Color.Gray
                        };

                        Label lblTitle = new Label
                        {
                            Text = "Title: " + title,
                            Location = new Point(10, 25),
                            AutoSize = true,
                            Font = new Font("Segoe UI", 10, FontStyle.Bold)
                        };

                        Label lblDesc = new Label
                        {
                            Text = "Priority: " + levelPriority,
                            Location = new Point(10, 45),
                            AutoSize = true
                        };

                        // Change background + foreground depending on levelPriority
                        if (levelPriority.Equals("Critical", StringComparison.OrdinalIgnoreCase))
                        {
                            lblDesc.BackColor = Color.Red;
                            lblDesc.ForeColor = Color.White;
                        }
                        else if (levelPriority.Equals("High", StringComparison.OrdinalIgnoreCase))
                        {
                            lblDesc.BackColor = Color.Maroon;
                            lblDesc.ForeColor = Color.White;
                        }
                        else if (levelPriority.Equals("Low", StringComparison.OrdinalIgnoreCase))
                        {
                            lblDesc.BackColor = Color.Green;
                            lblDesc.ForeColor = Color.White;
                        }

                        Label lblStartDate = new Label
                        {
                            Text = "Target Start Date: " + startDate,
                            Location = new Point(10, 60),
                            AutoSize = true
                        };

                        Label lblEndDate = new Label
                        {
                            Text = "Target End Date: " + endDate,
                            Location = new Point(10, 75),
                            AutoSize = true
                        };

                        // Add labels to panel
                        panel.Controls.Add(lblId);
                        panel.Controls.Add(lblTitle);
                        panel.Controls.Add(lblDesc);
                        panel.Controls.Add(lblStartDate);
                        panel.Controls.Add(lblEndDate);


                        // Optional click event
                        panel.Click += (s, e) =>
                        {
                            //MessageBox.Show($"You clicked task {id}: {title}");
                            frmTasks taskForm = new frmTasks(this, id, title, description, subject, status, levelPriority, startDate, endDate);
                            taskForm.btnClose.Visible = true;
                            taskForm.ShowDialog();
                        };

                        // Add panel to groupbox
                        grpOnHold.Controls.Add(panel);

                        y += panel.Height + 10; // move down for next panel
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading tasks: " + ex.Message);
            }
        }

        public void LoadFinishedTasks(string searchText = "", string searchMode = "")
        {
            grpFinished.Controls.Clear(); // Clear previous panels if reloaded

            try
            {
                DataTable dt = Globals.db.GetFinishedTask(searchText, searchMode);

                if (dt != null && dt.Rows.Count > 0)
                {
                    int y = 20;

                    foreach (DataRow row in dt.Rows)
                    {
                        int id = Convert.ToInt32(row["id"]);
                        string title = row["title"].ToString();
                        string levelPriority = row["levelPriority"].ToString();
                        string startDate = row["targetStartDate"].ToString();
                        string endDate = row["targetEndDate"].ToString();
                        string description = row["description"].ToString();
                        string status = row["status"].ToString();
                        string subject = row["subject"].ToString();

                        // Create panel
                        // Panel panel = new Panel();

                        Design panel = new Design
                        {
                            Size = new Size(300, 80),
                            Location = new Point(10, y),
                            BorderColor = Color.White, // customize
                            CornerRadius = 10,
                            BorderThickness = 2,
                            BackColor = Color.White
                        };


                        panel.BackColor = Color.White;
                        panel.Size = new Size(240, 100);
                        panel.Location = new Point(10, y);


                        Label lblId = new Label
                        {
                            Text = "TO-DO#: " + id.ToString(),
                            Location = new Point(10, 10),
                            AutoSize = true,
                            ForeColor = Color.Gray
                        };

                        Label lblTitle = new Label
                        {
                            Text = "Title: " + title,
                            Location = new Point(10, 25),
                            AutoSize = true,
                            Font = new Font("Segoe UI", 10, FontStyle.Bold)
                        };

                        Label lblDesc = new Label
                        {
                            Text = "Priority: " + levelPriority,
                            Location = new Point(10, 45),
                            AutoSize = true
                        };

                        // Change background + foreground depending on levelPriority
                        if (levelPriority.Equals("Critical", StringComparison.OrdinalIgnoreCase))
                        {
                            lblDesc.BackColor = Color.Red;
                            lblDesc.ForeColor = Color.White;
                        }
                        else if (levelPriority.Equals("High", StringComparison.OrdinalIgnoreCase))
                        {
                            lblDesc.BackColor = Color.Maroon;
                            lblDesc.ForeColor = Color.White;
                        }
                        else if (levelPriority.Equals("Low", StringComparison.OrdinalIgnoreCase))
                        {
                            lblDesc.BackColor = Color.Green;
                            lblDesc.ForeColor = Color.White;
                        }

                        Label lblStartDate = new Label
                        {
                            Text = "Target Start Date: " + startDate,
                            Location = new Point(10, 60),
                            AutoSize = true
                        };

                        Label lblEndDate = new Label
                        {
                            Text = "Target End Date: " + endDate,
                            Location = new Point(10, 75),
                            AutoSize = true
                        };

                        // Add labels to panel
                        panel.Controls.Add(lblId);
                        panel.Controls.Add(lblTitle);
                        panel.Controls.Add(lblDesc);
                        panel.Controls.Add(lblStartDate);
                        panel.Controls.Add(lblEndDate);


                        // Optional click event
                        panel.Click += (s, e) =>
                        {
                            // MessageBox.Show($"You clicked task {id}: {title}");
                            frmTasks taskForm = new frmTasks(this, id, title, description, subject, status, levelPriority, startDate, endDate);
                            taskForm.btnClose.Visible = true;
                            taskForm.ShowDialog();
                        };

                        // Add panel to groupbox
                        grpFinished.Controls.Add(panel);

                        y += panel.Height + 10; // move down for next panel
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading tasks: " + ex.Message);
            }
        }

        private void txtFrom_Validating(object sender, CancelEventArgs e)
        {
            DateTime parsedDate;

            //if (!DateTime.TryParseExact(
            //    txtFrom.Text,
            //    "MM/dd/yyyy",
            //    System.Globalization.CultureInfo.InvariantCulture,
            //    System.Globalization.DateTimeStyles.None,
            //    out parsedDate))
            //{
            //    e.Cancel = true;
            //    MessageBox.Show("Please enter a valid date in MM/DD/YYYY format.",
            //                    "Invalid Date",
            //                    MessageBoxButtons.OK,
            //                    MessageBoxIcon.Warning);
            //    txtFrom.SelectAll();
            //}
        }

        private void txtTo_Validating(object sender, CancelEventArgs e)
        {
            DateTime parsedDate;

            //if (!DateTime.TryParseExact(
            //    txtTo.Text,
            //    "MM/dd/yyyy",
            //    System.Globalization.CultureInfo.InvariantCulture,
            //    System.Globalization.DateTimeStyles.None,
            //    out parsedDate))
            //{
            //    e.Cancel = true;
            //    MessageBox.Show("Please enter a valid date in MM/DD/YYYY format.",
            //                    "Invalid Date",
            //                    MessageBoxButtons.OK,
            //                    MessageBoxIcon.Warning);
            //    txtTo.SelectAll();
            //}
        }

        private void ShowPopup(string title, string message)
        {
            PopupNotifier popup = new PopupNotifier();
            popup.TitleText = title;
            popup.ContentText = message;
            popup.Popup();
        }

        private async void CheckDueTasks()
        {
            DataTable dt = Globals.db.GetDueTask();

            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    int id = Convert.ToInt32(row["id"]);
                    string title = row["title"].ToString();
                    string status = row["status"].ToString();
                    string startDate = row["targetStartDate"].ToString();
                    string endDate = row["targetEndDate"].ToString();

                    string message = $"Status: {status}\nStart: {startDate}\nEnd: {endDate}";
                    ShowPopup($"Task #{id}: {title}", message);

                    await Task.Delay(2000);
                }
            }
        }

        private void closedToDoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmToDoList list = new frmToDoList();
            list.ShowDialog();
        }

        private void personalizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            settings.ShowDialog();
        }

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim();
            cbLevelPriority.SelectedIndex = -1;

            LoadNewTasks(searchText, "1");
            LoadOnGoingTasks(searchText, "1");
            LoadOnHoldTasks(searchText, "1");
            LoadFinishedTasks(searchText, "1");


        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            string searchText = cbLevelPriority.Text;
            txtSearch.Text = "";

            LoadNewTasks(searchText, "2");
            LoadOnGoingTasks(searchText, "2");
            LoadOnHoldTasks(searchText, "2");
            LoadFinishedTasks(searchText, "2");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            cbLevelPriority.SelectedIndex = -1;

            LoadNewTasks();
            LoadOnGoingTasks();
            LoadOnHoldTasks();
            LoadFinishedTasks();
        }

        public void TimerWorker()
        {

        }




        //
    }
}
