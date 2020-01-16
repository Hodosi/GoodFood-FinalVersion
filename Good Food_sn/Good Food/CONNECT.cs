using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Good_Food
{
    class CONNECT
    {
        public static string constring = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|GOOD_FOOD.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";

        SqlConnection conn = new SqlConnection(constring);

        public SqlConnection getConnection()
        {
            return conn;
        }

        public void openConnection()
        {
            if(conn.State==ConnectionState.Closed)
            {
                conn.Open();
            }
        }
        public void closeConnection()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
    }
}
