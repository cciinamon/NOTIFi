namespace NOTIFi
{
    public static class Globals
    {
        public static string ServerName;
        public static string Username;
        public static string Password;
        public static string DBName;

        // Store connection string, not SqlConnection
        public static string ConnectionString;


        public static Database db = new Database();
        public static frmSettings settings = new frmSettings();


        //values
        //public static string Title;
        //public static string Description;
        //public static string Subject;
        //public static string TargetStartDate;
        //public static string TargetEndDate;
        //public static string Status;
        //public static string LevelPriority;

    }
}
