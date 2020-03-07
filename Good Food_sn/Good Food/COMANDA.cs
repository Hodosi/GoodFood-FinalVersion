using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Good_Food
{
    class COMANDA
    {
        CONNECT conn = new CONNECT();
        public int getNrComenzi()
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select * From Comenzi ";
            command.Connection = conn.getConnection();

            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(table);

            return Convert.ToInt32(table.Rows.Count);
        }

        public void insertComanda(int idClient, DateTime dataC)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "INSERT INTO Comenzi(id_client,data_comanda) VALUES(@id,@data)";
            command.Connection = conn.getConnection();

            command.Parameters.Add("id", SqlDbType.Int).Value = idClient;
            command.Parameters.Add("data", SqlDbType.DateTime).Value = dataC;

            conn.openConnection();
            command.ExecuteNonQuery();
            conn.closeConnection();
        }

        public void insertSubComanda(int idComanda,int idProdus,int cant)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "INSERT INTO Subcomenzi(id_comanda,id_produs,cantitate) VALUES(@idc,@idp,@cant)";
            command.Connection = conn.getConnection();

            command.Parameters.Add("idc", SqlDbType.Int).Value = idComanda;
            command.Parameters.Add("idp", SqlDbType.Int).Value = idProdus;
            command.Parameters.Add("cant", SqlDbType.Int).Value = cant;

            conn.openConnection();
            command.ExecuteNonQuery();
            conn.closeConnection();
        }
    }
}
