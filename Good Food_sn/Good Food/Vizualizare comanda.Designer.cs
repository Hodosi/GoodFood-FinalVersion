namespace Good_Food
{
    partial class Vizualizare_comanda
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_finalizare = new System.Windows.Forms.Button();
            this.textBox_PretTotal_e = new System.Windows.Forms.TextBox();
            this.textBox_totalKcal_e = new System.Windows.Forms.TextBox();
            this.textBox_NecesarZilnic_e = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView_e = new System.Windows.Forms.DataGridView();
            this.IdC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kcal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pret = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantitate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Elimina = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_e)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_finalizare);
            this.panel1.Controls.Add(this.textBox_PretTotal_e);
            this.panel1.Controls.Add(this.textBox_totalKcal_e);
            this.panel1.Controls.Add(this.textBox_NecesarZilnic_e);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dataGridView_e);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1002, 425);
            this.panel1.TabIndex = 0;
            // 
            // button_finalizare
            // 
            this.button_finalizare.Location = new System.Drawing.Point(468, 313);
            this.button_finalizare.Margin = new System.Windows.Forms.Padding(4);
            this.button_finalizare.Name = "button_finalizare";
            this.button_finalizare.Size = new System.Drawing.Size(417, 53);
            this.button_finalizare.TabIndex = 13;
            this.button_finalizare.Text = "Finalizare";
            this.button_finalizare.UseVisualStyleBackColor = true;
            this.button_finalizare.Click += new System.EventHandler(this.button_finalizare_Click);
            // 
            // textBox_PretTotal_e
            // 
            this.textBox_PretTotal_e.Location = new System.Drawing.Point(202, 374);
            this.textBox_PretTotal_e.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_PretTotal_e.Name = "textBox_PretTotal_e";
            this.textBox_PretTotal_e.ReadOnly = true;
            this.textBox_PretTotal_e.Size = new System.Drawing.Size(155, 34);
            this.textBox_PretTotal_e.TabIndex = 12;
            this.textBox_PretTotal_e.Text = "0";
            // 
            // textBox_totalKcal_e
            // 
            this.textBox_totalKcal_e.Location = new System.Drawing.Point(202, 322);
            this.textBox_totalKcal_e.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_totalKcal_e.Name = "textBox_totalKcal_e";
            this.textBox_totalKcal_e.ReadOnly = true;
            this.textBox_totalKcal_e.Size = new System.Drawing.Size(155, 34);
            this.textBox_totalKcal_e.TabIndex = 11;
            this.textBox_totalKcal_e.Text = "0";
            // 
            // textBox_NecesarZilnic_e
            // 
            this.textBox_NecesarZilnic_e.Location = new System.Drawing.Point(202, 272);
            this.textBox_NecesarZilnic_e.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_NecesarZilnic_e.Name = "textBox_NecesarZilnic_e";
            this.textBox_NecesarZilnic_e.ReadOnly = true;
            this.textBox_NecesarZilnic_e.Size = new System.Drawing.Size(155, 34);
            this.textBox_NecesarZilnic_e.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(69, 380);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 29);
            this.label7.TabIndex = 9;
            this.label7.Text = "Pret Total:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(65, 328);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 29);
            this.label6.TabIndex = 8;
            this.label6.Text = "Total Kcal:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 278);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 29);
            this.label5.TabIndex = 7;
            this.label5.Text = "Necesar Zilnic:";
            // 
            // dataGridView_e
            // 
            this.dataGridView_e.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_e.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_e.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdC,
            this.Nume,
            this.Kcal,
            this.Pret,
            this.Cantitate,
            this.Elimina});
            this.dataGridView_e.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView_e.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_e.Name = "dataGridView_e";
            this.dataGridView_e.RowHeadersWidth = 51;
            this.dataGridView_e.RowTemplate.Height = 24;
            this.dataGridView_e.Size = new System.Drawing.Size(1002, 245);
            this.dataGridView_e.TabIndex = 0;
            this.dataGridView_e.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_e_CellContentClick);
            // 
            // IdC
            // 
            this.IdC.HeaderText = "IdC";
            this.IdC.MinimumWidth = 6;
            this.IdC.Name = "IdC";
            this.IdC.ReadOnly = true;
            // 
            // Nume
            // 
            this.Nume.HeaderText = "Nume";
            this.Nume.MinimumWidth = 6;
            this.Nume.Name = "Nume";
            this.Nume.ReadOnly = true;
            // 
            // Kcal
            // 
            this.Kcal.HeaderText = "Kcal";
            this.Kcal.MinimumWidth = 6;
            this.Kcal.Name = "Kcal";
            this.Kcal.ReadOnly = true;
            // 
            // Pret
            // 
            this.Pret.HeaderText = "Pret";
            this.Pret.MinimumWidth = 6;
            this.Pret.Name = "Pret";
            this.Pret.ReadOnly = true;
            // 
            // Cantitate
            // 
            this.Cantitate.HeaderText = "Cantitate";
            this.Cantitate.MinimumWidth = 6;
            this.Cantitate.Name = "Cantitate";
            this.Cantitate.ReadOnly = true;
            this.Cantitate.ToolTipText = "1";
            // 
            // Elimina
            // 
            this.Elimina.HeaderText = "Elimina";
            this.Elimina.MinimumWidth = 6;
            this.Elimina.Name = "Elimina";
            this.Elimina.Text = "Elimina";
            // 
            // Vizualizare_comanda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 425);
            this.Controls.Add(this.panel1);
            this.Name = "Vizualizare_comanda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vizualizare_comanda";
            this.Load += new System.EventHandler(this.Vizualizare_comanda_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_e)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox textBox_PretTotal_e;
        public System.Windows.Forms.TextBox textBox_totalKcal_e;
        public System.Windows.Forms.TextBox textBox_NecesarZilnic_e;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.DataGridView dataGridView_e;
        private System.Windows.Forms.Button button_finalizare;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nume;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kcal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pret;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantitate;
        private System.Windows.Forms.DataGridViewButtonColumn Elimina;
    }
}