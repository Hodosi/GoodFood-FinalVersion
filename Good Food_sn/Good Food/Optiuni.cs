using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Good_Food
{
    public partial class Optiuni : Form
    {
        public Optiuni()
        {
            InitializeComponent();
        }
        CLIENT client = new CLIENT();
        MENIU meniu = new MENIU();

        private void Optiuni_Load(object sender, EventArgs e)
        {

        }

        private void button_Calculeaza_Click(object sender, EventArgs e)
        {
            int ani = Convert.ToInt32(this.textBox_Varsta.Text);
            int inalt = Convert.ToInt32(this.textBox_Inaltime.Text);
            int greu = Convert.ToInt32(this.textBox_Greutate.Text);

            int s = ani + inalt + greu;
            int kcal;

            if (s < 250)
            {
                kcal = 1800;
            }
            else if (s >= 250 && s <= 275)
            {
                kcal = 2200;
            }
            else
            {
                kcal = 2500;
            }

            this.textBox_Necesar.Text = kcal.ToString();
            client.updateClient(kcal,GLOBAL.GlobalClientid);
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            DataTable table = meniu.getMeniu();
            this.dataGridView1.Rows[0].Cells[1].Value = "1";
            //for (int i = 0; i < table.Rows.Count; i++)
            //{
            //    MessageBox.Show(i.ToString());
            //    this.dataGridView1.Rows[i].Cells[1].Value = "1";
            //}

            this.textBox_NecesarZilnic.Text = this.textBox_Necesar.Text;

            table.DefaultView.AllowEdit = false;
            // table.Columns.Add("cantitate",typeof(int),"1");
            // DataColumn column = new DataColumn("cantitate1", typeof(string));
            //column.DefaultValue = "1";
            //table.Columns.Add(column);
            this.dataGridView1.DataSource = table;

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                int cantitate = int.Parse(this.dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
                if (cantitate < 1)
                {
                    MessageBox.Show("Cantitate negativa");
                    return;
                }
                int pret = int.Parse(this.dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());
                int kcal = int.Parse(this.dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString());
                pret *= cantitate;
                kcal *= cantitate;
                int pret_curent = int.Parse(this.textBox_PretTotal.Text);
                int kcal_curent = int.Parse(this.textBox_totalKcal.Text);
                pret_curent += pret;
                kcal_curent += kcal;
                this.textBox_totalKcal.Text = kcal_curent.ToString();
                this.textBox_PretTotal.Text = pret_curent.ToString();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Vizualizare_comanda frmVizComand = new Vizualizare_comanda();
            frmVizComand.ShowDialog();
            this.Close();
        }
    }
}
