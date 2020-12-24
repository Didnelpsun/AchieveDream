﻿using System;
using System.Data.OleDb;
using AchieveDream.Objects;
using System.Collections.Generic;
using System.Collections;

namespace AchieveDream
{
    public partial class DAO
    {
        public static Hashtable GetUserNameNum(string userName)
        {
            int data = 0;
            OleDbConnection connection = Connection.Conn;
            try
            {
                connection.Open();
                string sql = "SELECT * FROM [User] WHERE UserName ='" + userName + "';";
                OleDbCommand command = new OleDbCommand(sql, connection);
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    data++;
                }
                reader.Close();
            }
            catch(Exception e)
            {
                connection.Close();
                return new Hashtable
                {
                    { "message", e.Message.ToString().Trim() }
                };
            }
            connection.Close();
            return new Hashtable
            {
                { "data", data }
            };
        }
    }
}