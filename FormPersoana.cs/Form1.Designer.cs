namespace FormPersoana.cs
{
    partial class Form1
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
            this.Nume = new System.Windows.Forms.TextBox();
            this.Prenume = new System.Windows.Forms.TextBox();
            this.Telefon = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.Tip = new System.Windows.Forms.ComboBox();
            this.Status = new System.Windows.Forms.ComboBox();
            this.Salvare = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Nume
            // 
            this.Nume.Location = new System.Drawing.Point(12, 22);
            this.Nume.Name = "Nume";
            this.Nume.Size = new System.Drawing.Size(100, 22);
            this.Nume.TabIndex = 0;
            // 
            // Prenume
            // 
            this.Prenume.Location = new System.Drawing.Point(12, 71);
            this.Prenume.Name = "Prenume";
            this.Prenume.Size = new System.Drawing.Size(100, 22);
            this.Prenume.TabIndex = 1;
            this.Prenume.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Telefon
            // 
            this.Telefon.Location = new System.Drawing.Point(12, 129);
            this.Telefon.Name = "Telefon";
            this.Telefon.Size = new System.Drawing.Size(100, 22);
            this.Telefon.TabIndex = 2;
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(12, 187);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(100, 22);
            this.Email.TabIndex = 3;
            // 
            // Tip
            // 
            this.Tip.FormattingEnabled = true;
            this.Tip.Location = new System.Drawing.Point(12, 265);
            this.Tip.Name = "Tip";
            this.Tip.Size = new System.Drawing.Size(121, 24);
            this.Tip.TabIndex = 4;
            // 
            // Status
            // 
            this.Status.FormattingEnabled = true;
            this.Status.Location = new System.Drawing.Point(12, 323);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(121, 24);
            this.Status.TabIndex = 5;
            this.Status.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // Salvare
            // 
            this.Salvare.Location = new System.Drawing.Point(655, 323);
            this.Salvare.Name = "Salvare";
            this.Salvare.Size = new System.Drawing.Size(75, 23);
            this.Salvare.TabIndex = 6;
            this.Salvare.Text = "button1";
            this.Salvare.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Salvare);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.Tip);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Telefon);
            this.Controls.Add(this.Prenume);
            this.Controls.Add(this.Nume);
            this.Name = "Form1";
            this.Text = "Persoana";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Nume;
        private System.Windows.Forms.TextBox Prenume;
        private System.Windows.Forms.TextBox Telefon;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.ComboBox Tip;
        private System.Windows.Forms.ComboBox Status;
        private System.Windows.Forms.Button Salvare;
    }
}

