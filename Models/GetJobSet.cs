using System;
using System.Data.OleDb;
using System.Data;
using AchieveDream.Objects;
using System.Collections.Generic;

namespace AchieveDream.Models
{
    public class GetJobSet
    {
        public IList<Simple> data;
        public string message;

        public GetJobSet()
        {
            message = "";
            OleDbConnection connection = Connection.Conn();
            try
            {
                connection.Open();
                IList<Simple> list = new List<Simple>();
                string sql = "SELECT ID, Name FROM [Job] WHERE ID > 0;";
                OleDbCommand command = new OleDbCommand(sql, connection);
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new Simple(Convert.ToInt16(reader["ID"]), reader["Name"].ToString().Trim()));
                }
                reader.Close();
                data = list;
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