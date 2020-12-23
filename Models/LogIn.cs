using System;
using System.Collections;
using System.Data.OleDb;

namespace AchieveDream.Models
{
    public class LogIn
    {
        public bool data;
        public string message;

        public LogIn(string s1, string s2, bool mode)
        {
            Hashtable results = new Hashtable();
            if (!mode)
            {
                results = LogInByName(s1, s2);
            }
            else
            {
                results = LogInByPhone(s1, s2);
            }
            data = Convert.ToBoolean(results["data"]);
            message = results["message"].ToString().Trim();
        }

        private Hashtable LogInByName(string userName, string passWord)
        {
            bool data = false;
            string message = "";
            string comfirmWord = "";
            OleDbConnection connection = Connection.Conn();
            try
            {
                connection.Open();
                string sql = "SELECT PassWord FROM [User] WHERE UserName = '" + userName + "';";
                OleDbCommand command = new OleDbCommand(sql, connection);
                OleDbDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    int rows = 0;
                    while (reader.Read())
                    {
                        comfirmWord = reader["PassWord"].ToString().Trim();
                        rows++;
                    }
                    reader.Close();
                    connection.Close();
                    if (rows == 1)
                    {
                        if (passWord == comfirmWord)
                        {
                            data = true;
                        }
                        else
                        {
                            message = "密码不匹配！";
                        }
                    }
                    else
                    {
                        message = "数据库错误，有多条相同UserName数据！";
                    }
                }
                else
                {
                    message = "用户名不存在！";
                }
            }
            catch (Exception e)
            {
                message = e.Message;
                connection.Close();
            }
            Hashtable hashtable = new Hashtable();
            hashtable.Add("data", data);
            hashtable.Add("message", message);
            return hashtable;
        }

        private Hashtable LogInByPhone(string telePhone, string code)
        {
            bool data = false;
            string message = "未实现该功能";
            Hashtable hashtable = new Hashtable();
            hashtable.Add("data", data);
            hashtable.Add("message", message);
            return hashtable;
        }
    }
}