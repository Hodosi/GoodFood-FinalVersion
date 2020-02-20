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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
            // e.RowIndex >= 0)
            //{
            //    //TODO - Button Clicked - Execute Code Here
            //}

            if (this.dataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                MessageBox.Show(this.dataGridView1.Columns[e.ColumnIndex].ToString());
                MessageBox.Show(e.ColumnIndex.ToString());
            }

        }
    }
}
