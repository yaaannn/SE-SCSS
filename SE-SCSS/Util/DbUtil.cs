using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE_SCSS
{
    internal class DbUtil
    {

        private static readonly string connStr =
            "server=127.0.0.1;port=3306;user=root;password=heyan5201314;database=scss;";
        private static MySqlCommand cmd;
        private static MySqlConnection conn;
        public static MySqlConnection GetConn()
        {
            conn = new MySqlConnection(connStr);
            conn.Open();
            return conn;
        }

        public static bool AppandData(string sql)
        {
            conn = GetConn();
            cmd = new MySqlCommand(sql, conn);
            if (cmd.ExecuteNonQuery() > 0)
                return true;
            else
                return false;
        }

        public static MySqlDataReader DataReader(string sql)
        {
            conn = GetConn();
            cmd = new MySqlCommand(sql, conn);
            return cmd.ExecuteReader();
        }

        public static void CloseConn(MySqlConnection conn)
        {
            if (conn != null)
            {
                conn.Close();
            }
        }

    }
}
