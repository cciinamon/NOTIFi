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

namespace NOTIFi
{
    public partial class frmTasks : Form
    {
        private frmMain _mainForm;

        public frmTasks(frmMain mainForm, int id = -1, string title = "", string description = "", string subject = "", string status = "", string levelPriority = "", string startdate = "", string enddate = "")
        {
            InitializeComponent();

            _mainForm = mainForm;

            if (id > 0) 
            {
                lblID.Visible = true;
                lblID.Text = "To-Do#: " + id.ToString();
                txtTitle.Text = title;
                txtDescription.Text = description;
                txtSubject.Text = subject;
                cbStatus.SelectedItem = status;
                cbPriority.SelectedItem = levelPriority;
                txtStartDate.Text = startdate;
                txtEndDate.Text = enddate;
            }
            else
            {
                txtStartDate.Text = DateTime.Now.ToString("MM/dd/yyyy");
                txtEndDate.Text = DateTime.Now.ToString("MM/dd/yyyy");
            }
        }


        private void txtStartDate_Validating(object sender, CancelEventArgs e)
        {
            DateTime startDate, endDate;

            if (!DateTime.TryParseExact(
                txtStartDate.Text,
                "MM/dd/yyyy",
                System.Globalization.CultureInfo.InvariantCulture,
                System.Globalization.DateTimeStyles.None,
                out startDate))
            {
                e.Cancel = true;
                MessageBox.Show("Please enter a valid START date in MM/DD/YYYY format.",
                                "Invalid Date",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                txtStartDate.SelectAll();
                return;
            }

            // validate end date only if user has typed something
            if (DateTime.TryParseExact(
                txtEndDate.Text,
                "MM/dd/yyyy",
                System.Globalization.CultureInfo.InvariantCulture,
                System.Globalization.DateTimeStyles.None,
                out endDate))
            {
                if (startDate > endDate) // start is later than end
                {
                    e.Cancel = true;
                    MessageBox.Show("Start Date cannot be later than End Date.",
                                    "Invalid Date Range",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    txtStartDate.SelectAll();
                }
            }
        }

        private void txtEndDate_Validating(object sender, CancelEventArgs e)
        {
            DateTime endDate, startDate;

            if (!DateTime.TryParseExact(
                txtEndDate.Text,
                "MM/dd/yyyy",
                System.Globalization.CultureInfo.InvariantCulture,
                System.Globalization.DateTimeStyles.None,
                out endDate))
            {
                e.Cancel = true;
                MessageBox.Show("Please enter a valid END date in MM/DD/YYYY format.",
                                "Invalid Date",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                txtEndDate.SelectAll();
                return;
            }

            // Check against start date if it's valid
            if (DateTime.TryParseExact(
                txtStartDate.Text,
                "MM/dd/yyyy",
                System.Globalization.CultureInfo.InvariantCulture,
                System.Globalization.DateTimeStyles.None,
                out startDate))
            {
                if (endDate < startDate) // End date is earlier than Start date
                {
                    e.Cancel = true;
                    MessageBox.Show("End Date cannot be earlier than Start Date.",
                                    "Invalid Date Range",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    txtEndDate.SelectAll();
                }
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Globals.db.UpsertToDo(txtTitle.Text, txtDescription.Text, txtSubject.Text, txtStartDate.Text, 
                txtEndDate.Text, cbStatus.Text, cbPriority.Text, Convert.ToInt32(lblID.Text.Replace("To-Do#: ", "").Trim())))
            {
                Clear();
                this.Close();

                if (_mainForm != null)
                {
                    _mainForm.LoadNewTasks();
                    _mainForm.LoadOnGoingTasks();
                    _mainForm.LoadOnHoldTasks();
                    _mainForm.LoadFinishedTasks();
                }
                else
                {
                    MessageBox.Show("Main form reference is null!");
                }

            }
        }

        private void Clear()
        {
            txtTitle.Text = "";
            txtDescription.Text = "";
            txtSubject.Text = "";
            txtStartDate.Text = DateTime.Now.ToString("MM/dd/yyyy");
            txtEndDate.Text = DateTime.Now.ToString("MM/dd/yyyy");
            cbStatus.SelectedIndex = -1;
            cbPriority.SelectedIndex = -1;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to close this task?",
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                if(Globals.db.CloseToDo(Convert.ToInt32(lblID.Text.Replace("To-Do#: ", "").Trim())))
                {
                    Clear();
                    this.Close();

                    if (_mainForm != null)
                    {
                        _mainForm.LoadNewTasks();
                        _mainForm.LoadOnGoingTasks();
                        _mainForm.LoadOnHoldTasks();
                        _mainForm.LoadFinishedTasks();
                    }
                    else
                    {
                        MessageBox.Show("Main form reference is null!");
                    }
                }
            }
            else
            {

            }
        }
    }
}
