using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace DataAccessLayer
{
    public static class ClsDBManager
    {
        static string connString = string.Empty;
        static SqlConnection conn;
        static SqlCommand cmd;
        static ClsDBManager()
        {
            connString = new ConfigurationBuilder().AddJsonFile("AppSetting").Build().GetSection("conn").Value;
            conn = new(connString);
            cmd = new("", conn);
        }

        public static DataTable GetQueryResult(string cmdText)
        {
            DataTable dt = new();
            cmd.CommandText = cmdText;
            SqlDataAdapter adapter = new(cmd);
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

        public static int ExcuteScalar(string cmdText)
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
