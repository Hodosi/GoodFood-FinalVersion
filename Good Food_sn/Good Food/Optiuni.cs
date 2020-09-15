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
        COMANDA comand = new COMANDA();
        CLIENT client = new CLIENT();
        MENIU meniu = new MENIU();
        Vizualizare_comanda frmViz = new Vizualizare_comanda();
        int[] obId = new int[3];
        int[] obCant = new int[3];
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
            client.updateClient(kcal, GLOBAL.GlobalClientid);
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            DataTable table = meniu.getMeniu();
            this.dataGridView1.Rows[0].Cells[1].Value = "1";

            this.textBox_NecesarZilnic.Text = this.textBox_Necesar.Text;

            table.DefaultView.AllowEdit = false;

            this.dataGridView1.DataSource = table;

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                int cantitate = 1;
                try
                {
                    cantitate = int.Parse(this.dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Enter the Quantity");
                    return;
                }
                if (cantitate < 1)
                {
                    MessageBox.Show("Negative amount");
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
                //---------------------------------------------------
                frmViz.textBox_NecesarZilnic_e.Text = this.textBox_NecesarZilnic.Text;
                frmViz.textBox_totalKcal_e.Text = this.textBox_totalKcal.Text;
                frmViz.textBox_PretTotal_e.Text = this.textBox_PretTotal.Text;
                //----------------------------------------------------
                int index = frmViz.dataGridView_e.Rows.Count;
                index--;
                DataGridViewRowCollection row = frmViz.dataGridView_e.Rows;
                string[] ob = new string[5];
                ob[0] = this.dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                ob[1] = this.dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                ob[2] = this.dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                ob[3] = this.dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                ob[4] = this.dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                row.Insert(index, ob);
            }
        }

        private void button_comanda_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmViz.ShowDialog();
            this.Close();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.textBox_necesar_ge.Text = client.getClientKcal(GLOBAL.GlobalClientid).ToString();
            made_graf();
        }

        private void button_genereaza_Click(object sender, EventArgs e)
        {
            int kcal_max = int.Parse(this.textBox_necesar_ge.Text);
            int buget_max = int.Parse(this.textBox_buget.Text);
            string[] ob = new string[5];
            DataTable table1 = meniu.getMeniuFel1();
            DataTable table2 = meniu.getMeniuFel2();
            DataTable table3 = meniu.getMeniuFel3();
            int l1 = table1.Rows.Count;
            int l2 = table2.Rows.Count;
            int l3 = table3.Rows.Count;
            string fel1, fel2, fel3;
            int pret1, pret2, pret3, kcal1, kcal2, kcal3;

            for (int a = 0; a < l1; a++)
            {
                fel1 = table1.Rows[a][1].ToString();
                pret1 = int.Parse(table1.Rows[a][3].ToString());
                kcal1 = int.Parse(table1.Rows[a][4].ToString());

                for (int b = 0; b < l2; b++)
                {
                    fel2 = table2.Rows[b][1].ToString();
                    pret2 = int.Parse(table2.Rows[b][3].ToString());
                    kcal2 = int.Parse(table2.Rows[b][4].ToString());
                    for (int c = 0; c < l3; c++)
                    {
                        fel3 = table3.Rows[c][1].ToString();
                        pret3 = int.Parse(table3.Rows[c][3].ToString());
                        kcal3 = int.Parse(table3.Rows[c][4].ToString());

                        if ((pret1 + pret2 + pret3) <= buget_max && (kcal1 + kcal2 + kcal3) <= kcal_max)
                        {
                            ob[0] = fel1;
                            obId[0] = int.Parse(table1.Rows[a][0].ToString());
                            obCant[0] = kcal1;
                            ob[1] = fel2;
                            obId[1] = int.Parse(table2.Rows[b][0].ToString());
                            obCant[1] = kcal2;
                            ob[2] = fel3;
                            obId[2] = int.Parse(table3.Rows[c][0].ToString());
                            obCant[2] = kcal3;
                            ob[3] = (kcal1 + kcal2 + kcal3).ToString();
                            ob[4] = (pret1 + pret2 + pret3).ToString();
                            this.dataGridView_ge.Rows.Add(ob);

                        }
                    }
                }
            }
        }

        private void dataGridView_ge_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                int idclient = GLOBAL.GlobalClientid;
                DateTime dataC = DateTime.Now;
                comand.insertComanda(idclient, dataC);
                //-------------------------------------
                int idComanda = comand.getNrComenzi();
                int idProd, cant;
                for (int i = 0; i < 3; i++)
                {
                    idProd = obId[i];
                    cant = 1;
                    comand.insertSubComanda(idComanda, idProd, cant);
                }
                MessageBox.Show("Command sent!");
                // this.Hide();
                // Start frmStart = new Start();
                // frmStart.ShowDialog();
                // this.Close();
            }
        }

        public void made_graf()
        {
            DataTable table = comand.getSubcomenzi(GLOBAL.GlobalClientid);
            int nr_prod = table.Rows.Count;
            //------------------------------------------------------------
            Graphics graphics = this.panel_grafKcal.CreateGraphics();
            Pen pen = new Pen(Color.Black);
            SolidBrush brushBlue = new SolidBrush(Color.Blue);
            SolidBrush brushBlack = new SolidBrush(Color.Black);
            Font font = new Font("Arial", 8);
            string[] unitVal = new string[] { "1000", "800", "600", "400", "200", "0" };

            int grafWidth = this.panel_grafKcal.ClientSize.Width;
            int grafHeight = this.panel_grafKcal.ClientSize.Height;

            graphics.DrawString("Kcal", font, brushBlack, grafWidth / 2 - 10, 15);

            grafHeight -= 160;
            grafWidth -= 160;
            int unitWidth = grafWidth / (nr_prod+1);
            int unitHeight = grafHeight / 5;
            int i = 0; ;
            int j = 0;
            for (i = 1; i <= 5; i++)
            {
                for (j = 1; j <= nr_prod+1; j++)
                {
                    graphics.DrawLine(pen, 80 + unitWidth * (j - 1), 80 + unitHeight * (i - 1), 80 + unitWidth * j, 80 + unitHeight * (i - 1));
                    graphics.DrawLine(pen, 80 + unitWidth * (j - 1), 80 + unitHeight * (i - 1), 80 + unitWidth * (j - 1), 80 + unitHeight * i);
                }
                graphics.DrawString(unitVal[i - 1], font, brushBlack, 40, 75 + unitHeight * (i - 1));
            }
            graphics.DrawLine(pen, 80, 80 + unitHeight * (i - 1), 80 + unitWidth * (nr_prod+1), 80 + unitHeight * (i - 1));
            graphics.DrawLine(pen, 80 + unitWidth * (nr_prod+1), 80, 80 + unitWidth * (nr_prod+1), 80 + unitHeight * 5);
            graphics.DrawString(unitVal[i - 1], font, brushBlack, 40, 75 + unitHeight * (i - 1));

            float kcalunitHeight = (float)grafHeight / 1000;
            float kcalunitWidth = unitWidth / 2 - 40;
            float rectWidht = unitWidth-10;
            float rectHeight;
            int[] posString = new int[5];
            posString[0]= 5;
            posString[1] = 17;
            posString[2] = 29;
            posString[3] = 41;
            posString[4] = 53;
            for (i = 1; i <= nr_prod; i++)
            {
                int id_prod = int.Parse(table.Rows[i-1][0].ToString());
                int kcal = meniu.getProdKcal(id_prod);
                string nume = meniu.getnumeProdKcal(id_prod);
                float x1 = 80 + i * unitWidth-rectWidht/2;
                float y1 = 80 + (1000-kcal) * kcalunitHeight;
                rectHeight = kcal* kcalunitHeight;
                graphics.FillRectangle(brushBlue, x1, y1, rectWidht, rectHeight);
                graphics.DrawString(nume, font, brushBlack, x1, y1 + rectHeight +posString[(i-1)%5]);
            }
        }
    }
}
