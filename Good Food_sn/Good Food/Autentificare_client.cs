﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Good_Food
{
    public partial class Autentificare_client : Form
    {
        public Autentificare_client()
        {
            InitializeComponent();
        }

        CLIENT client = new CLIENT();

        private void button_Intra_Click(object sender, EventArgs e)
        {
            string email = this.textBox_email_Aut.Text;
            string pass = this.textBox_pass_Aut.Text;

            if (client.clientExists(email,pass))
            {
                this.Hide();
                int id = client.getClientId(email);
                GLOBAL.GlobalClientid = id;
                this.Hide();
                Optiuni op = new Optiuni();
                op.ShowDialog();
                this.Close();
            }
            else
            {
                this.textBox_email_Aut.ResetText();
                this.textBox_pass_Aut.ResetText();
                MessageBox.Show("Login error!");
            }
        }
    }
}
