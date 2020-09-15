using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Good_Food
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        //CONNECT conn = new CONNECT();

        private void Form1_Load(object sender, EventArgs e)
        {
            stergere();
            intializare();
            string fn = Application.StartupPath + @"\Resurse_C#\good-food-4.jpg";
            this.pictureBox1.Image = Image.FromFile(fn);
        }
        public static void stergere()
        {
            CONNECT conn = new CONNECT();
            conn.openConnection();
            SqlCommand command = new SqlCommand("DELETE FROM Meniu",conn.getConnection());
            command.ExecuteNonQuery();
            conn.closeConnection();

        }
        public static void intializare()
        {
            CONNECT conn = new CONNECT();
            SqlCommand command = new SqlCommand();
            StreamReader sr = new StreamReader(Application.StartupPath+@"\Resurse_C#\meniu.txt");
            char[] split = { ';' };
            string sir;

            conn.openConnection();
            sir = sr.ReadLine();
            while ( (sir = sr.ReadLine()) != null ) 
            {
                string[] siruri = sir.Split(split);
                string query = "INSERT INTO Meniu(id_produs,denumire_produs,descriere,pret,kcal,felul) VALUES (@id,@nume,@desc,@pret,@kcal,@felul)";

               //@id,@nume,@desc,@pret,@kcal,@felul      
                //command.CommandText = query;
                //command.Connection = conn.getConnection();
                command = new SqlCommand(query, conn.getConnection());

                if (siruri[0].Trim() != "")
                {
                    command.Parameters.Add("id", SqlDbType.Int).Value = Convert.ToInt32(siruri[0].Trim());
                    command.Parameters.Add("nume", SqlDbType.VarChar).Value = siruri[1].ToString();
                    command.Parameters.Add("desc", SqlDbType.NText).Value = siruri[2].ToString();
                    command.Parameters.Add("pret", SqlDbType.Int).Value = Convert.ToInt32(siruri[3].ToString());
                    command.Parameters.Add("kcal", SqlDbType.Int).Value = Convert.ToInt32(siruri[4].ToString());
                    command.Parameters.Add("felul", SqlDbType.Int).Value = Convert.ToInt32(siruri[5].ToString());

                    command.ExecuteNonQuery();
                }
            }

            conn.closeConnection();
        }

        private void button_Inregistrare_Click(object sender, EventArgs e)
        {
            this.Hide();
            Creare_cont_client cl=new Creare_cont_client();
            cl.ShowDialog();
            this.Show();
        }

        private void button_Autentificare_Click(object sender, EventArgs e)
        {
            this.Hide();
            Autentificare_client aut = new Autentificare_client();
            aut.ShowDialog();
            this.Close();
        }

    }
}
