using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace Good_Food
{
    class CLIENT
    {
        CONNECT conn = new CONNECT();

        public int getClientId(string email)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select id_client From  Clienti Where email=@em ";
            command.Connection = conn.getConnection();

            command.Parameters.Add("em", SqlDbType.VarChar).Value = email;

            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(table);

            return Convert.ToInt32(table.Rows[0][0].ToString());
        }

        public int getClientKcal(int id)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select kcal_zilnice From  Clienti Where id_client=@id ";
            command.Connection = conn.getConnection();

            command.Parameters.Add("id", SqlDbType.Int).Value = id;

            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(table);

            return Convert.ToInt32(table.Rows[0][0].ToString());
        }

        public bool emailExists(string email)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select * From  Clienti Where email=@em ";
            command.Connection = conn.getConnection();

            command.Parameters.Add("em", SqlDbType.VarChar).Value = email;

            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void insertClient(string nume, string pre, string pass, string address, string email)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "INSERT INTO Clienti(nume,parola,prenume,adresa,email) VALUES(@nm,@par,@pre,@add,@em) ";
            command.Connection = conn.getConnection();

            command.Parameters.Add("nm", SqlDbType.VarChar).Value = nume;
            command.Parameters.Add("par", SqlDbType.VarChar).Value = pass;
            command.Parameters.Add("pre", SqlDbType.VarChar).Value = pre;
            command.Parameters.Add("add", SqlDbType.VarChar).Value = address;
            command.Parameters.Add("em", SqlDbType.VarChar).Value = email;

            conn.openConnection();
            command.ExecuteNonQuery();
            conn.closeConnection();
        }
        public void updateClient(int kcal,int id)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "UPDATE Clienti SET kcal_zilnice=@kc WHERE id_client=@id ";
            command.Connection = conn.getConnection();

            command.Parameters.Add("kc", SqlDbType.Int).Value = kcal;
            command.Parameters.Add("id", SqlDbType.Int).Value = id;

            conn.openConnection();
            command.ExecuteNonQuery();
            conn.closeConnection();
        }

        public bool clientExists(string email,string pass)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select * From  Clienti Where email=@em and parola=@pass";
            command.Connection = conn.getConnection();

            command.Parameters.Add("em", SqlDbType.VarChar).Value = email;
            command.Parameters.Add("pass", SqlDbType.VarChar).Value = pass;

            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
