using System.Data.SqlClient;
using System.Data.OleDb;
using System.Web;

namespace AchieveDream.Models
{
    public class Connection
    {
        public static string kind = "Provider=Microsoft.Ace.OleDb.12.0;";
        public static OleDbConnection Conn()
        {
            return new OleDbConnection(kind + @"Data Source=" + HttpContext.Current.Server.MapPath("/Data/Data.accdb"));
        }

        public static OleDbConnection Conn(string s)
        {
            return new OleDbConnection(kind + @"Data Source=" + HttpContext.Current.Server.MapPath(s));
        }

        public static string ConnStr()
        {
            return kind + @"Data Source=" + HttpContext.Current.Server.MapPath("/Data/Data.accdb");
        }
    }
    
}