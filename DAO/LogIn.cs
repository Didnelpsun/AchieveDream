using System;
using System.Collections;
using System.Data.OleDb;

namespace AchieveDream
{
    public partial class DAO
    {
        public static Hashtable LogIn(string s1, string s2, bool mode)
        {
            Hashtable results;
            if (!mode)
            {
                results = LogInByName(s1, s2);
            }
            else
            {
                results = LogInByPhone(s1, s2);
            }
            return results;
        }

        private static Hashtable LogInByName(string userName, string passWord)
        {
            bool data = false;
            string message = "";
            string comfirmWord = "";
            OleDbConnection connection = Connection.Conn;
            connection.Close();
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
            }
            finally
            {
                connection.Close();
            }
            if (data)
            {
                return new Hashtable{
                    { "data", data }
                };
            }
            else
            {
                return new Hashtable{
                    { "message", message }
                };
            }
        }

        private static Hashtable LogInByPhone(string telePhone, string code)
        {
            string message = "未实现该功能";
            Hashtable hashtable = new Hashtable
            {
                { "message", message }
            };
            return hashtable;
        }
    }
}