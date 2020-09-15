namespace Good_Food
{
    partial class Autentificare_client
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
            this.textBox_pass_Aut = new System.Windows.Forms.TextBox();
            this.textBox_email_Aut = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Intra = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_pass_Aut
            // 
            this.textBox_pass_Aut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_pass_Aut.Location = new System.Drawing.Point(229, 151);
            this.textBox_pass_Aut.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_pass_Aut.Name = "textBox_pass_Aut";
            this.textBox_pass_Aut.PasswordChar = '*';
            this.textBox_pass_Aut.Size = new System.Drawing.Size(364, 30);
            this.textBox_pass_Aut.TabIndex = 13;
            // 
            // textBox_email_Aut
            // 
            this.textBox_email_Aut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_email_Aut.Location = new System.Drawing.Point(227, 78);
            this.textBox_email_Aut.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_email_Aut.Name = "textBox_email_Aut";
            this.textBox_email_Aut.Size = new System.Drawing.Size(364, 30);
            this.textBox_email_Aut.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(95, 152);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 29);
            this.label2.TabIndex = 11;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(131, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "E-mail:";
            // 
            // button_Intra
            // 
            this.button_Intra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Intra.Location = new System.Drawing.Point(339, 234);
            this.button_Intra.Margin = new System.Windows.Forms.Padding(4);
            this.button_Intra.Name = "button_Intra";
            this.button_Intra.Size = new System.Drawing.Size(124, 47);
            this.button_Intra.TabIndex = 14;
            this.button_Intra.Text = "Login";
            this.button_Intra.UseVisualStyleBackColor = true;
            this.button_Intra.Click += new System.EventHandler(this.button_Intra_Click);
            // 
            // Autentificare_client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 347);
            this.Controls.Add(this.button_Intra);
            this.Controls.Add(this.textBox_pass_Aut);
            this.Controls.Add(this.textBox_email_Aut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Autentificare_client";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_pass_Aut;
        private System.Windows.Forms.TextBox textBox_email_Aut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Intra;
    }
}