namespace Good_Food
{
    partial class Start
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_Inregistrare = new System.Windows.Forms.Button();
            this.button_Autentificare = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(99, 149);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(629, 202);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button_Inregistrare
            // 
            this.button_Inregistrare.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Inregistrare.Location = new System.Drawing.Point(99, 396);
            this.button_Inregistrare.Margin = new System.Windows.Forms.Padding(4);
            this.button_Inregistrare.Name = "button_Inregistrare";
            this.button_Inregistrare.Size = new System.Drawing.Size(179, 55);
            this.button_Inregistrare.TabIndex = 1;
            this.button_Inregistrare.Text = "Sign Up";
            this.button_Inregistrare.UseVisualStyleBackColor = true;
            this.button_Inregistrare.Click += new System.EventHandler(this.button_Inregistrare_Click);
            // 
            // button_Autentificare
            // 
            this.button_Autentificare.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Autentificare.Location = new System.Drawing.Point(549, 396);
            this.button_Autentificare.Margin = new System.Windows.Forms.Padding(4);
            this.button_Autentificare.Name = "button_Autentificare";
            this.button_Autentificare.Size = new System.Drawing.Size(179, 55);
            this.button_Autentificare.TabIndex = 2;
            this.button_Autentificare.Text = "Login";
            this.button_Autentificare.UseVisualStyleBackColor = true;
            this.button_Autentificare.Click += new System.EventHandler(this.button_Autentificare_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(704, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Various menus characterized by diversity and excellence!";
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 521);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Autentificare);
            this.Controls.Add(this.button_Inregistrare);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Start";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Start";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_Inregistrare;
        private System.Windows.Forms.Button button_Autentificare;
        private System.Windows.Forms.Label label1;
    }
}

