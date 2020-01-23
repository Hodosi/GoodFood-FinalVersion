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
            //update db
            //this.dataGridView1.DataSource=
            

            //DataGridView dgv = new DataGridView();
            //dgv.DataSource = dtusers;

            //DataGridViewColumn amount = new DataGridViewColumn();
            //amount.HeaderText = "Amount";
            //amount.Name = "Amount";
            //dgv.Columns.Insert(0, amount);

            //DataGridViewColumn narration = new DataGridViewColumn();
            //narration.HeaderText = "Narration";
            //narration.Name = "Narration";
           // dgv.Columns.Insert(0, narration);
        }
    }
}
