using System;
using System.Data.OleDb;
using System.Data;
using AchieveDream.Objects;
using System.Collections.Generic;

namespace AchieveDream.Models
{
    public class LogOn
    {
        public bool data;
        public string message;

        public LogOn(string userName, string passWord, string conmfirmWord, int job, string idCode, string telephone)
        {
            data = false;
            message = "";
            OleDbConnection connection = Connection.Conn();
            try
            {
                connection.Open();
                string sql = "SELECT ID, Name FROM [Job] WHERE ID > 0;";
                OleDbCommand command = new OleDbCommand(sql, connection);
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new Simple(Convert.ToInt16(reader["ID"]), reader["Name"].ToString().Trim()));
                }
                reader.Close();
                data = true;
            }
            catch(Exception e)
            {
                message = e.Message;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}