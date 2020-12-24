using System;
using System.Data.OleDb;
using System.Collections;

namespace AchieveDream
{
    public partial class DAO
    {
        public static Hashtable LogOn(string userName, string passWord, string telephone, int job, string idCode)
        {
            bool data = false;
            string message = "";
            OleDbConnection connection = Connection.Conn;
            Hashtable getUserNameNum = DAO.GetUserNameNum(userName);
            Hashtable getTelephoneNum = DAO.GetTelephoneNum(telephone);
            int userNameNum;
            int telephoneNum;
            if (getUserNameNum.ContainsKey("data"))
            {
                userNameNum = Convert.ToInt16(getUserNameNum["data"]);
            }
            else
            {
                return new Hashtable{
                    { "message", "获取用户名数量错误：" + getUserNameNum["message"].ToString().Trim() }
                };
            }
            if (getTelephoneNum.ContainsKey("data"))
            {
                telephoneNum = Convert.ToInt16(getTelephoneNum["data"]);
            }
            else
            {
                return new Hashtable{
                    { "message", "获取电话数量错误：" + getTelephoneNum["message"].ToString().Trim() }
                };
            }
            if (userNameNum == 0 && telephoneNum == 0)
            {
                try
                {
                    connection.Open();
                    string sql = "INSERT INTO [User] VALUES('{0}', '{1}', '{2}', '{3}', '{4}'); ";
                    sql = String.Format(sql, userName, passWord, telephone, job, idCode);
                    OleDbCommand command = new OleDbCommand(sql, connection);
                    int rows = command.ExecuteNonQuery();
                    if (rows == 1)
                    {
                        data = true;
                    }
                    else if (rows == 0)
                    {
                        message = "更新失败！";
                    }
                    else
                    {
                        message = "系统插入多行！";
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
            }
            else
            {
                if (userNameNum != 0)
                {
                    return new Hashtable{
                        { "message", "用户名重复，请更换！" }
                    };
                }
                else
                {
                    return new Hashtable{
                        { "message", "电话号码重复，请更换！" }
                    };
                }

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
    }
}