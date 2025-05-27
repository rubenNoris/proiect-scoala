namespace proiect_scoala
{
    partial class VizualizareDateForm
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
            this.dgvPersoane = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCautare = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Cauta = new System.Windows.Forms.Button();
            this.btnSalveaza = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFirme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersoane)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFirme
            // 
            this.dgvFirme.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFirme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFirme.Location = new System.Drawing.Point(671, 140);
            this.dgvFirme.Name = "dgvFirme";
            this.dgvFirme.RowHeadersWidth = 51;
            this.dgvFirme.RowTemplate.Height = 24;
            this.dgvFirme.Size = new System.Drawing.Size(557, 357);
            this.dgvFirme.TabIndex = 0;
            // 
            // dgvPersoane
            // 
            this.dgvPersoane.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPersoane.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersoane.Location = new System.Drawing.Point(31, 140);
            this.dgvPersoane.Name = "dgvPersoane";
            this.dgvPersoane.RowHeadersWidth = 51;
            this.dgvPersoane.RowTemplate.Height = 24;
            this.dgvPersoane.Size = new System.Drawing.Size(548, 357);
            this.dgvPersoane.TabIndex = 1;
            this.dgvPersoane.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPersoane_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(668, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Aici se pot vedea programarile firmelor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(267, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Aici se pot vedea programarile persoanelor";
            // 
            // txtCautare
            // 
            this.txtCautare.Location = new System.Drawing.Point(376, 68);
            this.txtCautare.Name = "txtCautare";
            this.txtCautare.Size = new System.Drawing.Size(217, 22);
            this.txtCautare.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(313, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cauta";
            // 
            // Cauta
            // 
            this.Cauta.Location = new System.Drawing.Point(376, 94);
            this.Cauta.Name = "Cauta";
            this.Cauta.Size = new System.Drawing.Size(107, 29);
            this.Cauta.TabIndex = 6;
            this.Cauta.Text = "cauta";
            this.Cauta.UseVisualStyleBackColor = true;
            this.Cauta.Click += new System.EventHandler(this.Cauta_Click);
            // 
            // btnSalveaza
            // 
            this.btnSalveaza.Location = new System.Drawing.Point(556, 503);
            this.btnSalveaza.Name = "btnSalveaza";
            this.btnSalveaza.Size = new System.Drawing.Size(130, 31);
            this.btnSalveaza.TabIndex = 7;
            this.btnSalveaza.Text = "Salveaza";
            this.btnSalveaza.UseVisualStyleBackColor = true;
            this.btnSalveaza.Click += new System.EventHandler(this.btnSalveaza_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(489, 94);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(104, 29);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // VizualizareDateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 575);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSalveaza);
            this.Controls.Add(this.Cauta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCautare);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPersoane);
            this.Controls.Add(this.dgvFirme);
            this.Name = "VizualizareDateForm";
            this.Text = "VizualizareDateForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFirme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersoane)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFirme;
        private System.Windows.Forms.DataGridView dgvPersoane;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCautare;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Cauta;
        private System.Windows.Forms.Button btnSalveaza;
        private System.Windows.Forms.Button btnReset;
    }
}