﻿using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace DataAccessLayer
{
    public static class ClsDBManager
    {
        static string connString = string.Empty;
        static SqlConnection conn;
        static SqlCommand cmd;
        static SqlDataAdapter adapter;
        static ClsDBManager()
        {
            connString = new ConfigurationBuilder().AddJsonFile("AppSetting.json").Build().GetSection("conn").Value;
            conn = new(connString);
            cmd = new("", conn);
            adapter = new(cmd);
        }

        public static DataTable GetQueryResult(string cmdText)
        {
            DataTable dt = new();
            cmd.CommandText = cmdText;
            adapter.InsertCommand = cmd;
            adapter.Fill(dt);
            return dt;
        }

        public static int ExecuteNonQuery(string cmdText)
        {
            int rowAffected = 0;
            cmd.CommandText = cmdText;
            conn.Open();
            rowAffected = cmd.ExecuteNonQuery();
            conn.Close();
            return rowAffected;
        }

        public static int ExecuteScalar(string cmdText)
        {
            int identity = 0;
            cmd.CommandText = cmdText;
            cmd.CommandText += "select Scope_Identity()";
            conn.Open();
            identity = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();
            return identity;
        }
    }
}
