using System.Data.SqlClient;
using System.Data.OleDb;
using System.Web;

namespace AchieveDream.Models
{
    public class Connection
    {
        public static OleDbConnection connection()
        {
            string cons = "Provider=Microsoft.Ace.OleDb.12.0;";
            cons += @"Data Source=" + HttpContext.Current.Server.MapPath("/Data/Data.accdb");
            return new OleDbConnection(cons);
        }

        public static OleDbConnection connection(string s)
        {
            string cons = "Provider=Microsoft.Ace.OleDb.12.0;";
            cons += @"Data Source=" + HttpContext.Current.Server.MapPath(s);
            return new OleDbConnection(cons);
        }
    }
    
}