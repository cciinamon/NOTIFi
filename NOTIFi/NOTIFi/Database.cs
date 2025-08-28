using NOTIFi;
using System;
using System.Data;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

public class Database
{
    string vbCrLf = Environment.NewLine;
    string mvstr_cmd;

   
    public DataTable DBSelect(string query)
    {
        var dt = new DataTable();

        using (var conn = new SqlConnection(Globals.ConnectionString))
        {
            using (var cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                using (var adapter = new SqlDataAdapter(cmd))
                {
                    adapter.Fill(dt);
                }
            }
        }

        return dt;
    }

    public bool DBExecute(string query)
    {
        if (string.IsNullOrEmpty(Globals.ConnectionString))
            throw new InvalidOperationException("Database connection string is not initialized. Please configure connection first.");

        using (var conn = new SqlConnection(Globals.ConnectionString))
        {
            using (var cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
        }
    }

    public DataTable GetNewTask(string searchText = "", string searchMode = "")
    {
        DataTable dt = null;

        try
        {
            mvstr_cmd = "SELECT * FROM tblToDo WHERE status = 'New' AND userID = "+ Globals.User_ID + "";

            if (searchText != "" && searchMode == "1")
            {
                mvstr_cmd += "AND (description LIKE  '%" + searchText + "%' OR title LIKE  '%" + searchText + "%' OR id LIKE  '%" + searchText + "%')";
            }
            else if (searchText != "" && searchMode == "2")
            {
                mvstr_cmd += "AND levelPriority = '" + searchText + "'";
            }

            dt = Globals.db.DBSelect(mvstr_cmd);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        return dt;
    }

    public DataTable GetOnGoingTask(string searchText = "", string searchMode = "")
    {
        DataTable dt = null;

        try
        {
            mvstr_cmd = "SELECT * FROM tblToDo WHERE status = 'On-going' AND userID = "+ Globals.User_ID + "";

            if (searchText != "" && searchMode == "1")
            {
                mvstr_cmd += "AND (description LIKE  '%" + searchText + "%' OR title LIKE  '%" + searchText + "%' OR id LIKE  '%" + searchText + "%')";
            }
            else if (searchText != "" && searchMode == "2")
            {
                mvstr_cmd += "AND levelPriority = '" + searchText + "'";
            }

            dt = Globals.db.DBSelect(mvstr_cmd);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        return dt;
    }

    public DataTable GetOnHoldTask(string searchText = "", string searchMode = "")
    {
        DataTable dt = null;

        try
        {
            mvstr_cmd = "SELECT * FROM tblToDo WHERE status = 'Hold' AND userID = "+ Globals.User_ID + "";

            if (searchText != "" && searchMode == "1")
            {
                mvstr_cmd += "AND (description LIKE  '%" + searchText + "%' OR title LIKE  '%" + searchText + "%' OR id LIKE  '%" + searchText + "%')";
            }
            else if (searchText != "" && searchMode == "2")
            {
                mvstr_cmd += "AND levelPriority = '" + searchText + "'";
            }

            dt = Globals.db.DBSelect(mvstr_cmd);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        return dt;
    }

    public DataTable GetFinishedTask(string searchText = "", string searchMode = "")
    {
        DataTable dt = null;

        try
        {
            mvstr_cmd = "SELECT * FROM tblToDo WHERE status = 'Finished' AND userID = "+ Globals.User_ID + "";
            
            if (searchText != "" && searchMode == "1")
            {
                mvstr_cmd += "AND (description LIKE  '%" + searchText + "%' OR title LIKE  '%" + searchText + "%' OR id LIKE  '%" + searchText + "%')";
            }
            else if (searchText != "" && searchMode == "2")
            {
                mvstr_cmd += "AND levelPriority = '" + searchText + "'";
            }

            dt = Globals.db.DBSelect(mvstr_cmd);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        return dt;
    }

    public DataTable GetClosedTask()
    {
        DataTable dt = null;

        try
        {
            mvstr_cmd = "SELECT * FROM tblToDo WHERE status = 'Closed' AND userID = " + Globals.User_ID + "";
            dt = Globals.db.DBSelect(mvstr_cmd);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        return dt;
    }

    public DataTable GetAllTask()
    {
        DataTable dt = null;

        try
        {
            mvstr_cmd = "SELECT * FROM tblToDo WHERE userID = " + Globals.User_ID + "";
            dt = Globals.db.DBSelect(mvstr_cmd);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        return dt;
    }

    public DataTable GetAllOpenTask()
    {
        DataTable dt = null;

        try
        {
            mvstr_cmd = "SELECT * FROM tblToDo WHERE userID = " + Globals.User_ID + "  AND status = 'On-going';";
            dt = Globals.db.DBSelect(mvstr_cmd);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        return dt;
    }

    public DataTable GetDueTask()
    {
        DataTable dt = null;

        try
        {
            mvstr_cmd = "SELECT id, title, status, targetStartDate, targetEndDate FROM tblToDo WHERE CAST(targetStartDate AS DATE) = CAST(GETDATE() AS DATE) AND userID = "+ Globals.User_ID + "";
            dt = Globals.db.DBSelect(mvstr_cmd);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        return dt;
    }

    public bool UpsertToDo(string title, string description, string subject, string startdate, string enddate, string status, string levelpriority, int id = -1)
    {
        if(id == -1)
        {
            mvstr_cmd = "INSERT INTO tblToDo (userID,title,description,subject,targetStartDate,targetEndDate,status,levelPriority) VALUES " + vbCrLf;
            mvstr_cmd += "('"+Globals.User_ID+"', '" + title + "', '" + description + "', '" + subject + "', '" + startdate + "'," + vbCrLf;
            mvstr_cmd += "'" + enddate + "', '" + status + "', '" + levelpriority + "')" + vbCrLf;
        }
        else
        {
            mvstr_cmd = "UPDATE tblToDo SET title = '"+title+"', description = '"+description+"', subject='"+subject+"', " + vbCrLf;
            mvstr_cmd += "targetStartDate = '"+ startdate + "', targetEndDate='"+enddate+"', status ='"+status+ "', levelPriority='"+levelpriority+"'" + vbCrLf;
            mvstr_cmd += "WHERE id = "+ id + " AND userID = "+ Globals.User_ID + "" + vbCrLf;
        }

        return DBExecute(mvstr_cmd);
    }

    public bool CloseToDo(int id = -1)
    {
        
        mvstr_cmd = "UPDATE tblToDo SET status ='Closed'" + vbCrLf;
        mvstr_cmd += "WHERE id = " + id + " AND userID = "+ Globals.User_ID + "" + vbCrLf;
       
        return DBExecute(mvstr_cmd);
    }

    public DataTable SignIn(string User_username, string User_password)
    {
        DataTable dt = null;

        try
        {
            mvstr_cmd = "SELECT * FROM tblUsers WHERE username = '"+ User_username + "' AND password = '"+ User_password + "'";
            dt = Globals.db.DBSelect(mvstr_cmd);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        return dt;
    }

    public bool UpsertUser(string user, string password, string firstname, string lastname, string email, int userID = -1)
    {
        if (userID == -1)
        {
            mvstr_cmd = "INSERT INTO tblUsers (username, password, firstname, lastname, email) VALUES " + vbCrLf;
            mvstr_cmd += " ('"+user+"', '"+password+"', '"+ firstname + "', '"+ lastname + "', '"+ email + "')" + vbCrLf;
        }
        else
        {
            //mvstr_cmd = "UPDATE tblToDo SET title = '" + title + "', description = '" + description + "', subject='" + subject + "', " + vbCrLf;
            //mvstr_cmd += "targetStartDate = '" + startdate + "', targetEndDate='" + enddate + "', status ='" + status + "', levelPriority='" + levelpriority + "'" + vbCrLf;
            //mvstr_cmd += "WHERE id = " + id + "" + vbCrLf;
        } 

        return DBExecute(mvstr_cmd);
    }

    public bool UpsertSystemSetting(int userID, string settingCode, string settingValue)
    {
        try
        {
            mvstr_cmd = "BEGIN TRANSACTION" + vbCrLf;
            mvstr_cmd += "DELETE FROM tblSystemSetting where userID = "+ userID + " and settingCode = '" + settingCode + "';" + vbCrLf;
            mvstr_cmd += "COMMIT TRANSACTION" + vbCrLf;
            mvstr_cmd += "INSERT INTO tblSystemSetting(userID, settingCode, settingValue, status)" + vbCrLf;
            mvstr_cmd += $"VALUES ("+ userID + ", '"+ settingCode + "', '"+ settingValue + "', 'A')";

            return DBExecute(mvstr_cmd);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return false;
        }

    }

    public string GetSystemSetting(string settingCode)
    {
        DataTable dt;
        string settingValue = "";

        try
        {
            mvstr_cmd = "SELECT * FROM tblSystemSetting WHERE settingCode = '"+ settingCode + "' AND userID = " + Globals.User_ID + "";
            dt = Globals.db.DBSelect(mvstr_cmd);

            if (dt != null && dt.Rows.Count > 0)
            {
                settingValue = dt.Rows[0]["settingValue"].ToString();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        return settingValue;
    }

    public DataTable SearchTask(string searchText, string searchMode, string from = "", string to = "")
    {
        DataTable dt = null;

        try
        {
            if (searchMode == "1")
            {
                mvstr_cmd = "SELECT * FROM tblToDo WHERE (description LIKE  '%" + searchText + "%' OR title LIKE  '%" + searchText + "%' OR id LIKE  '%" + searchText + "%') AND userID = " + Globals.User_ID + "";

                if (from != "" || to != "")
                {
                    mvstr_cmd += "AND targetStartDate >= '"+ from + "' OR targetEndDate >= '"+ to + "'";
                }
            }
            else if (searchMode == "2")
            {
                mvstr_cmd = "SELECT * FROM tblToDo WHERE levelPriority = '" + searchText + "' AND userID = " + Globals.User_ID + "";

                if (from != "" || to != "")
                {
                    mvstr_cmd += "AND targetStartDate >= '" + from + "' OR targetEndDate >= '" + to + "'";
                }
            }
            dt = Globals.db.DBSelect(mvstr_cmd);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        return dt;
    }


}
