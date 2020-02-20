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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_PretTotal = new System.Windows.Forms.TextBox();
            this.textBox_totalKcal = new System.Windows.Forms.TextBox();
            this.textBox_NecesarZilnic = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage_Meniu = new System.Windows.Forms.TabPage();
            this.tabPage_Grafic = new System.Windows.Forms.TabPage();
            this.id_produs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.denumire_produs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriere = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pret = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kcal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.felul = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantitate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adauga = new System.Windows.Forms.DataGridViewButtonColumn();
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
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(876, 468);
            this.tabControl1.TabIndex = 0;
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
            this.tabPage_CalulatorKcal.Location = new System.Drawing.Point(4, 33);
            this.tabPage_CalulatorKcal.Name = "tabPage_CalulatorKcal";
            this.tabPage_CalulatorKcal.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_CalulatorKcal.Size = new System.Drawing.Size(868, 431);
            this.tabPage_CalulatorKcal.TabIndex = 0;
            this.tabPage_CalulatorKcal.Text = "CalulatorKcal";
            this.tabPage_CalulatorKcal.UseVisualStyleBackColor = true;
            // 
            // button_Calculeaza
            // 
            this.button_Calculeaza.Location = new System.Drawing.Point(335, 267);
            this.button_Calculeaza.Name = "button_Calculeaza";
            this.button_Calculeaza.Size = new System.Drawing.Size(122, 40);
            this.button_Calculeaza.TabIndex = 8;
            this.button_Calculeaza.Text = "Calculeaza";
            this.button_Calculeaza.UseVisualStyleBackColor = true;
            this.button_Calculeaza.Click += new System.EventHandler(this.button_Calculeaza_Click);
            // 
            // textBox_Necesar
            // 
            this.textBox_Necesar.Location = new System.Drawing.Point(456, 128);
            this.textBox_Necesar.Name = "textBox_Necesar";
            this.textBox_Necesar.ReadOnly = true;
            this.textBox_Necesar.Size = new System.Drawing.Size(159, 29);
            this.textBox_Necesar.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(469, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Necesar Zilnic:";
            // 
            // textBox_Greutate
            // 
            this.textBox_Greutate.Location = new System.Drawing.Point(158, 198);
            this.textBox_Greutate.Name = "textBox_Greutate";
            this.textBox_Greutate.Size = new System.Drawing.Size(154, 29);
            this.textBox_Greutate.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Greutate(kg):";
            // 
            // textBox_Inaltime
            // 
            this.textBox_Inaltime.Location = new System.Drawing.Point(158, 128);
            this.textBox_Inaltime.Name = "textBox_Inaltime";
            this.textBox_Inaltime.Size = new System.Drawing.Size(154, 29);
            this.textBox_Inaltime.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Inaltime(cm):";
            // 
            // textBox_Varsta
            // 
            this.textBox_Varsta.Location = new System.Drawing.Point(158, 57);
            this.textBox_Varsta.Name = "textBox_Varsta";
            this.textBox_Varsta.Size = new System.Drawing.Size(154, 29);
            this.textBox_Varsta.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Varsta(ani):";
            // 
            // tabPage_Comanda
            // 
            this.tabPage_Comanda.Controls.Add(this.button1);
            this.tabPage_Comanda.Controls.Add(this.textBox_PretTotal);
            this.tabPage_Comanda.Controls.Add(this.textBox_totalKcal);
            this.tabPage_Comanda.Controls.Add(this.textBox_NecesarZilnic);
            this.tabPage_Comanda.Controls.Add(this.label7);
            this.tabPage_Comanda.Controls.Add(this.label6);
            this.tabPage_Comanda.Controls.Add(this.label5);
            this.tabPage_Comanda.Controls.Add(this.dataGridView1);
            this.tabPage_Comanda.Location = new System.Drawing.Point(4, 33);
            this.tabPage_Comanda.Name = "tabPage_Comanda";
            this.tabPage_Comanda.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Comanda.Size = new System.Drawing.Size(868, 431);
            this.tabPage_Comanda.TabIndex = 1;
            this.tabPage_Comanda.Text = "Comanda";
            this.tabPage_Comanda.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(363, 338);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(313, 43);
            this.button1.TabIndex = 7;
            this.button1.Text = "Comanda";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox_PretTotal
            // 
            this.textBox_PretTotal.Location = new System.Drawing.Point(150, 380);
            this.textBox_PretTotal.Name = "textBox_PretTotal";
            this.textBox_PretTotal.ReadOnly = true;
            this.textBox_PretTotal.Size = new System.Drawing.Size(117, 29);
            this.textBox_PretTotal.TabIndex = 6;
            this.textBox_PretTotal.Text = "0";
            // 
            // textBox_totalKcal
            // 
            this.textBox_totalKcal.Location = new System.Drawing.Point(150, 338);
            this.textBox_totalKcal.Name = "textBox_totalKcal";
            this.textBox_totalKcal.ReadOnly = true;
            this.textBox_totalKcal.Size = new System.Drawing.Size(117, 29);
            this.textBox_totalKcal.TabIndex = 5;
            this.textBox_totalKcal.Text = "0";
            // 
            // textBox_NecesarZilnic
            // 
            this.textBox_NecesarZilnic.Location = new System.Drawing.Point(150, 297);
            this.textBox_NecesarZilnic.Name = "textBox_NecesarZilnic";
            this.textBox_NecesarZilnic.ReadOnly = true;
            this.textBox_NecesarZilnic.Size = new System.Drawing.Size(117, 29);
            this.textBox_NecesarZilnic.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 385);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 24);
            this.label7.TabIndex = 3;
            this.label7.Text = "Pret Total:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 343);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 24);
            this.label6.TabIndex = 2;
            this.label6.Text = "Total Kcal:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 24);
            this.label5.TabIndex = 1;
            this.label5.Text = "Necesar Zilnic:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_produs,
            this.denumire_produs,
            this.descriere,
            this.pret,
            this.kcal,
            this.felul,
            this.cantitate,
            this.adauga});
            this.dataGridView1.Location = new System.Drawing.Point(8, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(851, 278);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tabPage_Meniu
            // 
            this.tabPage_Meniu.Location = new System.Drawing.Point(4, 33);
            this.tabPage_Meniu.Name = "tabPage_Meniu";
            this.tabPage_Meniu.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Meniu.Size = new System.Drawing.Size(868, 431);
            this.tabPage_Meniu.TabIndex = 2;
            this.tabPage_Meniu.Text = "Generare Meniu";
            this.tabPage_Meniu.UseVisualStyleBackColor = true;
            // 
            // tabPage_Grafic
            // 
            this.tabPage_Grafic.Location = new System.Drawing.Point(4, 33);
            this.tabPage_Grafic.Name = "tabPage_Grafic";
            this.tabPage_Grafic.Size = new System.Drawing.Size(868, 431);
            this.tabPage_Grafic.TabIndex = 3;
            this.tabPage_Grafic.Text = "GraficKcal";
            this.tabPage_Grafic.UseVisualStyleBackColor = true;
            // 
            // id_produs
            // 
            this.id_produs.HeaderText = "id_produs";
            this.id_produs.Name = "id_produs";
            this.id_produs.ReadOnly = true;
            // 
            // denumire_produs
            // 
            this.denumire_produs.HeaderText = "denumire_produs";
            this.denumire_produs.Name = "denumire_produs";
            this.denumire_produs.ReadOnly = true;
            // 
            // descriere
            // 
            this.descriere.HeaderText = "descriere";
            this.descriere.Name = "descriere";
            this.descriere.ReadOnly = true;
            // 
            // pret
            // 
            this.pret.HeaderText = "pret";
            this.pret.Name = "pret";
            this.pret.ReadOnly = true;
            // 
            // kcal
            // 
            this.kcal.HeaderText = "kcal";
            this.kcal.Name = "kcal";
            this.kcal.ReadOnly = true;
            // 
            // felul
            // 
            this.felul.HeaderText = "felul";
            this.felul.Name = "felul";
            this.felul.ReadOnly = true;
            // 
            // cantitate
            // 
            this.cantitate.HeaderText = "cantitate";
            this.cantitate.Name = "cantitate";
            // 
            // adauga
            // 
            this.adauga.HeaderText = "adauga";
            this.adauga.Name = "adauga";
            this.adauga.Text = "adauga";
            this.adauga.UseColumnTextForButtonValue = true;
            // 
            // Optiuni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 468);
            this.Controls.Add(this.tabControl1);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_produs;
        private System.Windows.Forms.DataGridViewTextBoxColumn denumire_produs;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriere;
        private System.Windows.Forms.DataGridViewTextBoxColumn pret;
        private System.Windows.Forms.DataGridViewTextBoxColumn kcal;
        private System.Windows.Forms.DataGridViewTextBoxColumn felul;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantitate;
        private System.Windows.Forms.DataGridViewButtonColumn adauga;

    }
}