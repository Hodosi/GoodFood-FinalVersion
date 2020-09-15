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
    public partial class Vizualizare_comanda : Form
    {
        public Vizualizare_comanda()
        {
            InitializeComponent();
        }

        COMANDA comand = new COMANDA();
        private void dataGridView_e_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                int pret = int.Parse(this.dataGridView_e.Rows[e.RowIndex].Cells[3].Value.ToString());
                int kcal = int.Parse(this.dataGridView_e.Rows[e.RowIndex].Cells[2].Value.ToString());
                int pret_curent = int.Parse(this.textBox_PretTotal_e.Text);
                int kcal_curent = int.Parse(this.textBox_totalKcal_e.Text);
                pret_curent -= pret;
                kcal_curent -= kcal;
                this.textBox_totalKcal_e.Text = kcal_curent.ToString();
                this.textBox_PretTotal_e.Text = pret_curent.ToString();
                this.dataGridView_e.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void button_finalizare_Click(object sender, EventArgs e)
        {           
            int idclient = GLOBAL.GlobalClientid;
            DateTime dataC = DateTime.Now;
            comand.insertComanda(idclient, dataC);
            //-------------------------------------
            int idComanda = comand.getNrComenzi();
            int idProd, cant;
            int rcont = this.dataGridView_e.Rows.Count;
            rcont--;
            //MessageBox.Show(rcont.ToString());
            for (int i = 0; i < rcont; i++)
            {
                idProd = int.Parse(this.dataGridView_e.Rows[i].Cells[0].Value.ToString());
                cant = int.Parse(this.dataGridView_e.Rows[i].Cells[4].Value.ToString());
                comand.insertSubComanda(idComanda, idProd, cant);
            }
            MessageBox.Show("Command sent!");
            this.Hide();
            Start frmStart = new Start();
            frmStart.ShowDialog();
            this.Close();

        }
    }
}
