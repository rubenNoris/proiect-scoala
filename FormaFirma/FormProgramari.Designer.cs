namespace FormaFirma
{
    partial class FormProgramari
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
            this.dgvFirme = new System.Windows.Forms.DataGridView();
            this.dvgPersoane = new System.Windows.Forms.DataGridView();
            this.dgvFirma = new System.Windows.Forms.DataGridView();
            this.dgvPersoana = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFirme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgPersoane)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFirma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersoana)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFirme
            // 
            this.dgvFirme.ColumnHeadersHeight = 29;
            this.dgvFirme.Location = new System.Drawing.Point(0, 0);
            this.dgvFirme.Name = "dgvFirme";
            this.dgvFirme.RowHeadersWidth = 51;
            this.dgvFirme.Size = new System.Drawing.Size(125, 150);
            this.dgvFirme.TabIndex = 0;
            // 
            // dvgPersoane
            // 
            this.dvgPersoane.ColumnHeadersHeight = 29;
            this.dvgPersoane.Location = new System.Drawing.Point(0, 0);
            this.dvgPersoane.Name = "dvgPersoane";
            this.dvgPersoane.RowHeadersWidth = 51;
            this.dvgPersoane.Size = new System.Drawing.Size(125, 150);
            this.dvgPersoane.TabIndex = 0;
            // 
            // dgvFirma
            // 
            this.dgvFirma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFirma.Location = new System.Drawing.Point(28, 111);
            this.dgvFirma.Name = "dgvFirma";
            this.dgvFirma.RowHeadersWidth = 51;
            this.dgvFirma.RowTemplate.Height = 24;
            this.dgvFirma.Size = new System.Drawing.Size(386, 311);
            this.dgvFirma.TabIndex = 1;
            this.dgvFirma.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFirma_CellContentClick);
            // 
            // dgvPersoana
            // 
            this.dgvPersoana.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersoana.Location = new System.Drawing.Point(420, 111);
            this.dgvPersoana.Name = "dgvPersoana";
            this.dgvPersoana.RowHeadersWidth = 51;
            this.dgvPersoana.RowTemplate.Height = 24;
            this.dgvPersoana.Size = new System.Drawing.Size(368, 311);
            this.dgvPersoana.TabIndex = 2;
            this.dgvPersoana.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPersoana_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Programari firma";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(441, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Programari persoana fizica";
            // 
            // FormProgramari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPersoana);
            this.Controls.Add(this.dgvFirma);
            this.Name = "FormProgramari";
            this.Text = "FormProgramari";
            this.Load += new System.EventHandler(this.FormProgramari_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFirme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgPersoane)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFirma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersoana)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvFirme;
        private System.Windows.Forms.DataGridView dvgPersoane;
        private System.Windows.Forms.DataGridView dgvFirma;
        private System.Windows.Forms.DataGridView dgvPersoana;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}