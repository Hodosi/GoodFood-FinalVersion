namespace Good_Food
{
    partial class Optiuni
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_CalulatorKcal = new System.Windows.Forms.TabPage();
            this.button_Calculeaza = new System.Windows.Forms.Button();
            this.textBox_Necesar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Greutate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Inaltime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Varsta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage_Comanda = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox_PretTotal = new System.Windows.Forms.TextBox();
            this.textBox_totalKcal = new System.Windows.Forms.TextBox();
            this.textBox_NecesarZilnic = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage_Meniu = new System.Windows.Forms.TabPage();
            this.tabPage_Grafic = new System.Windows.Forms.TabPage();
            this.button_comanda = new System.Windows.Forms.Button();
            this.Adauga = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Cantitate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage_CalulatorKcal.SuspendLayout();
            this.tabPage_Comanda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_CalulatorKcal);
            this.tabControl1.Controls.Add(this.tabPage_Comanda);
            this.tabControl1.Controls.Add(this.tabPage_Meniu);
            this.tabControl1.Controls.Add(this.tabPage_Grafic);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1168, 576);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tabPage_CalulatorKcal
            // 
            this.tabPage_CalulatorKcal.Controls.Add(this.button_Calculeaza);
            this.tabPage_CalulatorKcal.Controls.Add(this.textBox_Necesar);
            this.tabPage_CalulatorKcal.Controls.Add(this.label4);
            this.tabPage_CalulatorKcal.Controls.Add(this.textBox_Greutate);
            this.tabPage_CalulatorKcal.Controls.Add(this.label3);
            this.tabPage_CalulatorKcal.Controls.Add(this.textBox_Inaltime);
            this.tabPage_CalulatorKcal.Controls.Add(this.label2);
            this.tabPage_CalulatorKcal.Controls.Add(this.textBox_Varsta);
            this.tabPage_CalulatorKcal.Controls.Add(this.label1);
            this.tabPage_CalulatorKcal.Location = new System.Drawing.Point(4, 38);
            this.tabPage_CalulatorKcal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage_CalulatorKcal.Name = "tabPage_CalulatorKcal";
            this.tabPage_CalulatorKcal.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage_CalulatorKcal.Size = new System.Drawing.Size(1160, 534);
            this.tabPage_CalulatorKcal.TabIndex = 0;
            this.tabPage_CalulatorKcal.Text = "CalulatorKcal";
            this.tabPage_CalulatorKcal.UseVisualStyleBackColor = true;
            // 
            // button_Calculeaza
            // 
            this.button_Calculeaza.Location = new System.Drawing.Point(447, 329);
            this.button_Calculeaza.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Calculeaza.Name = "button_Calculeaza";
            this.button_Calculeaza.Size = new System.Drawing.Size(163, 49);
            this.button_Calculeaza.TabIndex = 8;
            this.button_Calculeaza.Text = "Calculeaza";
            this.button_Calculeaza.UseVisualStyleBackColor = true;
            this.button_Calculeaza.Click += new System.EventHandler(this.button_Calculeaza_Click);
            // 
            // textBox_Necesar
            // 
            this.textBox_Necesar.Location = new System.Drawing.Point(608, 158);
            this.textBox_Necesar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_Necesar.Name = "textBox_Necesar";
            this.textBox_Necesar.ReadOnly = true;
            this.textBox_Necesar.Size = new System.Drawing.Size(211, 34);
            this.textBox_Necesar.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(625, 103);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Necesar Zilnic:";
            // 
            // textBox_Greutate
            // 
            this.textBox_Greutate.Location = new System.Drawing.Point(211, 244);
            this.textBox_Greutate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_Greutate.Name = "textBox_Greutate";
            this.textBox_Greutate.Size = new System.Drawing.Size(204, 34);
            this.textBox_Greutate.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 250);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Greutate(kg):";
            // 
            // textBox_Inaltime
            // 
            this.textBox_Inaltime.Location = new System.Drawing.Point(211, 158);
            this.textBox_Inaltime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_Inaltime.Name = "textBox_Inaltime";
            this.textBox_Inaltime.Size = new System.Drawing.Size(204, 34);
            this.textBox_Inaltime.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 164);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Inaltime(cm):";
            // 
            // textBox_Varsta
            // 
            this.textBox_Varsta.Location = new System.Drawing.Point(211, 70);
            this.textBox_Varsta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_Varsta.Name = "textBox_Varsta";
            this.textBox_Varsta.Size = new System.Drawing.Size(204, 34);
            this.textBox_Varsta.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Varsta(ani):";
            // 
            // tabPage_Comanda
            // 
            this.tabPage_Comanda.Controls.Add(this.button_comanda);
            this.tabPage_Comanda.Controls.Add(this.dataGridView1);
            this.tabPage_Comanda.Controls.Add(this.textBox_PretTotal);
            this.tabPage_Comanda.Controls.Add(this.textBox_totalKcal);
            this.tabPage_Comanda.Controls.Add(this.textBox_NecesarZilnic);
            this.tabPage_Comanda.Controls.Add(this.label7);
            this.tabPage_Comanda.Controls.Add(this.label6);
            this.tabPage_Comanda.Controls.Add(this.label5);
            this.tabPage_Comanda.Location = new System.Drawing.Point(4, 38);
            this.tabPage_Comanda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage_Comanda.Name = "tabPage_Comanda";
            this.tabPage_Comanda.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage_Comanda.Size = new System.Drawing.Size(1160, 534);
            this.tabPage_Comanda.TabIndex = 1;
            this.tabPage_Comanda.Text = "Comanda";
            this.tabPage_Comanda.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Adauga,
            this.Cantitate});
            this.dataGridView1.Location = new System.Drawing.Point(4, 7);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1143, 330);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // textBox_PretTotal
            // 
            this.textBox_PretTotal.Location = new System.Drawing.Point(200, 468);
            this.textBox_PretTotal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_PretTotal.Name = "textBox_PretTotal";
            this.textBox_PretTotal.ReadOnly = true;
            this.textBox_PretTotal.Size = new System.Drawing.Size(155, 34);
            this.textBox_PretTotal.TabIndex = 6;
            this.textBox_PretTotal.Text = "0";
            // 
            // textBox_totalKcal
            // 
            this.textBox_totalKcal.Location = new System.Drawing.Point(200, 416);
            this.textBox_totalKcal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_totalKcal.Name = "textBox_totalKcal";
            this.textBox_totalKcal.ReadOnly = true;
            this.textBox_totalKcal.Size = new System.Drawing.Size(155, 34);
            this.textBox_totalKcal.TabIndex = 5;
            this.textBox_totalKcal.Text = "0";
            // 
            // textBox_NecesarZilnic
            // 
            this.textBox_NecesarZilnic.Location = new System.Drawing.Point(200, 366);
            this.textBox_NecesarZilnic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_NecesarZilnic.Name = "textBox_NecesarZilnic";
            this.textBox_NecesarZilnic.ReadOnly = true;
            this.textBox_NecesarZilnic.Size = new System.Drawing.Size(155, 34);
            this.textBox_NecesarZilnic.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(67, 474);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 29);
            this.label7.TabIndex = 3;
            this.label7.Text = "Pret Total:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 422);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 29);
            this.label6.TabIndex = 2;
            this.label6.Text = "Total Kcal:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 372);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 29);
            this.label5.TabIndex = 1;
            this.label5.Text = "Necesar Zilnic:";
            // 
            // tabPage_Meniu
            // 
            this.tabPage_Meniu.Location = new System.Drawing.Point(4, 38);
            this.tabPage_Meniu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage_Meniu.Name = "tabPage_Meniu";
            this.tabPage_Meniu.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage_Meniu.Size = new System.Drawing.Size(1160, 534);
            this.tabPage_Meniu.TabIndex = 2;
            this.tabPage_Meniu.Text = "Generare Meniu";
            this.tabPage_Meniu.UseVisualStyleBackColor = true;
            // 
            // tabPage_Grafic
            // 
            this.tabPage_Grafic.Location = new System.Drawing.Point(4, 38);
            this.tabPage_Grafic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage_Grafic.Name = "tabPage_Grafic";
            this.tabPage_Grafic.Size = new System.Drawing.Size(1160, 534);
            this.tabPage_Grafic.TabIndex = 3;
            this.tabPage_Grafic.Text = "GraficKcal";
            this.tabPage_Grafic.UseVisualStyleBackColor = true;
            // 
            // button_comanda
            // 
            this.button_comanda.Location = new System.Drawing.Point(526, 416);
            this.button_comanda.Margin = new System.Windows.Forms.Padding(4);
            this.button_comanda.Name = "button_comanda";
            this.button_comanda.Size = new System.Drawing.Size(417, 53);
            this.button_comanda.TabIndex = 9;
            this.button_comanda.Text = "Comanda";
            this.button_comanda.UseVisualStyleBackColor = true;
            this.button_comanda.Click += new System.EventHandler(this.button_comanda_Click);
            // 
            // Adauga
            // 
            this.Adauga.HeaderText = "Adauga";
            this.Adauga.MinimumWidth = 6;
            this.Adauga.Name = "Adauga";
            this.Adauga.Text = "Adauga";
            // 
            // Cantitate
            // 
            this.Cantitate.HeaderText = "Cantitate";
            this.Cantitate.MinimumWidth = 6;
            this.Cantitate.Name = "Cantitate";
            this.Cantitate.ToolTipText = "1";
            // 
            // Optiuni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 576);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Optiuni";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Optiuni";
            this.Load += new System.EventHandler(this.Optiuni_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage_CalulatorKcal.ResumeLayout(false);
            this.tabPage_CalulatorKcal.PerformLayout();
            this.tabPage_Comanda.ResumeLayout(false);
            this.tabPage_Comanda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_CalulatorKcal;
        private System.Windows.Forms.Button button_Calculeaza;
        private System.Windows.Forms.TextBox textBox_Necesar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Greutate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Inaltime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Varsta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage_Comanda;
        private System.Windows.Forms.TabPage tabPage_Meniu;
        private System.Windows.Forms.TabPage tabPage_Grafic;
        private System.Windows.Forms.TextBox textBox_PretTotal;
        private System.Windows.Forms.TextBox textBox_totalKcal;
        private System.Windows.Forms.TextBox textBox_NecesarZilnic;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_comanda;
        private System.Windows.Forms.DataGridViewButtonColumn Adauga;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantitate;
    }
}