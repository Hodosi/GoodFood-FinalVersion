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
    public partial class Creare_cont_client : Form
    {
        public Creare_cont_client()
        {
            InitializeComponent();
        }

        private void Creare_cont_client_Load(object sender, EventArgs e)
        {
            string fn = Application.StartupPath + @"\Resurse_C#\good-food-4.jpg";
            this.pictureBox1.Image = Image.FromFile(fn);
        }
    }
}
