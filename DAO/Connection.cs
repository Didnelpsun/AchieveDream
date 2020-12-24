using System.Data.SqlClient;
using System.Data.OleDb;
using System.Web;

namespace AchieveDream
{
    public class Connection
    {
        // 连接类型
        public string _Kind;
        public string Kind
        {
            set
            {
                _Kind = value;
            }
            get
            {
                return _Kind;
            }
        }
        // 连接字符串
        public string _ConStr;
        public string ConStr
        {
            set
            {
                _ConStr = value;
            }
            get
            {
                return _ConStr;
            }
        }
        // 数据库地址
        public string _Location;
        public string Location
        {
            set
            {
                _Location = value;
            }
            get
            {
                return _Location;
            }
        }
        // 连接
        public OleDbConnection _Connect;
        public OleDbConnection Connect
        {
            set
            {
                _Connect = value;
            }
            get
            {
                return _Connect;
            }
        }
        public Connection()
        {
            _Kind = "Provider=Microsoft.Ace.OleDb.12.0;";
            _Location = HttpContext.Current.Server.MapPath("/Data/Data.accdb");
            _ConStr = _Kind + @"Data Source=" + _Location;
            _Connect = new OleDbConnection(_ConStr);
        }
        public Connection(string location)
        {
            _Kind = "Provider=Microsoft.Ace.OleDb.12.0;";
            _Location = HttpContext.Current.Server.MapPath(location);
            _ConStr = _Kind + @"Data Source=" + _Location;
            _Connect = new OleDbConnection(_ConStr);
        }
        public static OleDbConnection Conn = new Connection().Connect;
    }
}