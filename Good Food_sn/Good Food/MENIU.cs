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
            command.CommandText = "Select id_produs As Id, denumire_Produs As Name, descriere As Description, Pret As Price, kcal As Kcal, Felul As Type From  Meniu ";
            command.Connection = conn.getConnection();

            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }

        public DataTable getMeniuFel1()
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select * From  Meniu Where felul=@fel";
            command.Connection = conn.getConnection();

            command.Parameters.Add("fel", SqlDbType.Int).Value = 1;

            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }
        public DataTable getMeniuFel2()
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select * From  Meniu Where felul=@fel";
            command.Connection = conn.getConnection();

            command.Parameters.Add("fel", SqlDbType.Int).Value = 2;

            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }

        public DataTable getMeniuFel3()
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select * From  Meniu Where felul=@fel";
            command.Connection = conn.getConnection();

            command.Parameters.Add("fel", SqlDbType.Int).Value = 3;

            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }

        public int getProdKcal(int id)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select kcal From  Meniu Where id_produs=@id";
            command.Connection = conn.getConnection();

            command.Parameters.Add("id", SqlDbType.Int).Value = id;

            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(table);

            return int.Parse(table.Rows[0][0].ToString());
        }

        public string getnumeProdKcal(int id)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select denumire_produs From  Meniu Where id_produs=@id";
            command.Connection = conn.getConnection();

            command.Parameters.Add("id", SqlDbType.Int).Value = id;

            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table.Rows[0][0].ToString();
        }

    }
}
