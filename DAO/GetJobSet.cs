using System;
using System.Data.OleDb;
using AchieveDream.Objects;
using System.Collections.Generic;
using System.Collections;

namespace AchieveDream
{
    public partial class DAO
    {
        public static Hashtable GetJobList()
        {
            IList<Simple> data = new List<Simple>();
            string message;
            Hashtable result = new Hashtable();
            OleDbConnection connection = Connection.Conn;
            try
            {
                connection.Open();
                string sql = "SELECT ID, Name FROM [Job] WHERE ID > 0;";
                OleDbCommand command = new OleDbCommand(sql, connection);
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    data.Add(new Simple(Convert.ToInt16(reader["ID"]), reader["Name"].ToString().Trim()));
                }
                reader.Close();
                result.Add("data", data);
            }
            catch(Exception e)
            {
                result.Clear();
                message = e.Message;
                result.Add("message", message);
            }
            finally
            {
                connection.Close();
            }
            return result;
        }
    }
}