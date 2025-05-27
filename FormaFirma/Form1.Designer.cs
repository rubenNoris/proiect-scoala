namespace FormaFirma
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
            this.btnPersoana = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFirma = new System.Windows.Forms.Button();
            this.btnVeziProgramari = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPersoana
            // 
            this.btnPersoana.Location = new System.Drawing.Point(88, 198);
            this.btnPersoana.Name = "btnPersoana";
            this.btnPersoana.Size = new System.Drawing.Size(254, 23);
            this.btnPersoana.TabIndex = 0;
            this.btnPersoana.Text = "Persoana fizica";
            this.btnPersoana.UseVisualStyleBackColor = true;
            this.btnPersoana.Click += new System.EventHandler(this.btnPersoana_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(273, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Meniu inscriere programare sedinta foto";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnFirma
            // 
            this.btnFirma.Location = new System.Drawing.Point(469, 198);
            this.btnFirma.Name = "btnFirma";
            this.btnFirma.Size = new System.Drawing.Size(254, 23);
            this.btnFirma.TabIndex = 2;
            this.btnFirma.Text = "Firma";
            this.btnFirma.UseVisualStyleBackColor = true;
            this.btnFirma.Click += new System.EventHandler(this.btnFirma_Click);
            // 
            // btnVeziProgramari
            // 
            this.btnVeziProgramari.Location = new System.Drawing.Point(276, 381);
            this.btnVeziProgramari.Name = "btnVeziProgramari";
            this.btnVeziProgramari.Size = new System.Drawing.Size(150, 30);
            this.btnVeziProgramari.TabIndex = 0;
            this.btnVeziProgramari.Text = "Vezi date firme/persoane";
            this.btnVeziProgramari.Click += new System.EventHandler(this.btnVeziProgramari_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(638, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Primul pas pentru a purea face inscrierea e sa alegeti pentru ce tip de instituti" +
    "e se va desfasura sedinta foto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(629, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Pentru o buna organizare puteti vzualiza si ce evenimente viitoare avem daca acce" +
    "sati butonul de mai jos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnVeziProgramari);
            this.Controls.Add(this.btnFirma);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPersoana);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPersoana;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFirma;
        private System.Windows.Forms.Button btnVeziProgramari;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

