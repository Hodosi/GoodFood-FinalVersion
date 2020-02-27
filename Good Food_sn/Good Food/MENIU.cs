using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace Good_Food
{
    class MENIU
    {
        CONNECT conn = new CONNECT();

        public DataTable getMeniu()
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select * From  Meniu ";
            command.Connection = conn.getConnection();

            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }

    }
}
