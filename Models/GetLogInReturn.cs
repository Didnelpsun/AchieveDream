using System;
using AchieveDream.Models;
using System.Data.OleDb;
using System.Diagnostics;

namespace AchieveDream.Models
{
    public class GetLogInReturn
    {
        public bool data;
        public string message;

        public GetLogInReturn(string s1, string s2, bool mode)
        {
            object[] results = new object[2];
            if (!mode)
            {
                results = LogInByName(s1, s2);
            }
            else
            {
                results = LogInByPhone(s1, s2);
            }
            data = Convert.ToBoolean(results[0]);
            message = results[1].ToString();
        }

        private object[] LogInByName(string username, string password)
        {
            bool data = false;
            string message = "";
            string comfirmword = "";
            OleDbConnection connection = Connection.connection();
            try
            {
                connection.Open();
                string sql = "SELECT PassWord FROM [User] WHERE UserName = '" + username + "'";
                OleDbCommand command = new OleDbCommand(sql, connection);
                OleDbDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    int rows = 0;
                    while (reader.Read())
                    {
                        comfirmword = reader["PassWord"].ToString().Trim();
                        rows++;
                    }
                    reader.Close();
                    connection.Close();
                    if (rows == 1)
                    {
                        if (password == comfirmword)
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
            return new Object[] { data, message };
        }

        private object[] LogInByPhone(string telephone, string code)
        {
            bool data = false;
            string message = "未实现该功能";
            return new Object[] { data, message };
        }
    }
}