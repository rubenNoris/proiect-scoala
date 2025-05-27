namespace FormaFirma
{
    partial class FormPersoana
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
            this.components = new System.ComponentModel.Container();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtPrenume = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.Nume = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbTip = new System.Windows.Forms.ComboBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSalveaza = new System.Windows.Forms.Button();
            this.radioConfirma = new System.Windows.Forms.RadioButton();
            this.groupBoxConfirmare = new System.Windows.Forms.GroupBox();
            this.radioNuConfirma = new System.Windows.Forms.RadioButton();
            this.groupBoxConfirmare.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(129, 45);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(221, 22);
            this.txtNume.TabIndex = 0;
            this.txtNume.TextChanged += new System.EventHandler(this.txtNume_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtPrenume
            // 
            this.txtPrenume.Location = new System.Drawing.Point(129, 82);
            this.txtPrenume.Name = "txtPrenume";
            this.txtPrenume.Size = new System.Drawing.Size(221, 22);
            this.txtPrenume.TabIndex = 2;
            this.txtPrenume.TextChanged += new System.EventHandler(this.txtPrenume_TextChanged);
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(129, 119);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(221, 22);
            this.txtTelefon.TabIndex = 3;
            this.txtTelefon.TextChanged += new System.EventHandler(this.txtTelefon_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(129, 157);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(221, 22);
            this.txtEmail.TabIndex = 4;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // Nume
            // 
            this.Nume.AutoSize = true;
            this.Nume.Location = new System.Drawing.Point(12, 51);
            this.Nume.Name = "Nume";
            this.Nume.Size = new System.Drawing.Size(43, 16);
            this.Nume.TabIndex = 5;
            this.Nume.Text = "Nume";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Prenume";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Telefon";
            // 
            // cmbTip
            // 
            this.cmbTip.FormattingEnabled = true;
            this.cmbTip.Location = new System.Drawing.Point(129, 199);
            this.cmbTip.Name = "cmbTip";
            this.cmbTip.Size = new System.Drawing.Size(221, 24);
            this.cmbTip.TabIndex = 9;
            this.cmbTip.SelectedIndexChanged += new System.EventHandler(this.cmbTip_SelectedIndexChanged);
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(129, 239);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(221, 24);
            this.cmbStatus.TabIndex = 10;
            this.cmbStatus.SelectedIndexChanged += new System.EventHandler(this.cmbStatus_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Tip";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Status";
            // 
            // btnSalveaza
            // 
            this.btnSalveaza.Location = new System.Drawing.Point(129, 374);
            this.btnSalveaza.Name = "btnSalveaza";
            this.btnSalveaza.Size = new System.Drawing.Size(221, 23);
            this.btnSalveaza.TabIndex = 13;
            this.btnSalveaza.Text = "Salveaza";
            this.btnSalveaza.UseVisualStyleBackColor = true;
            this.btnSalveaza.Click += new System.EventHandler(this.btnSalveaza_Click);
            // 
            // radioConfirma
            // 
            this.radioConfirma.AutoSize = true;
            this.radioConfirma.Location = new System.Drawing.Point(6, 21);
            this.radioConfirma.Name = "radioConfirma";
            this.radioConfirma.Size = new System.Drawing.Size(172, 20);
            this.radioConfirma.TabIndex = 14;
            this.radioConfirma.TabStop = true;
            this.radioConfirma.Text = "Confirm datele introduse";
            this.radioConfirma.UseVisualStyleBackColor = true;
            this.radioConfirma.CheckedChanged += new System.EventHandler(this.radioConfirma_CheckedChanged);
            // 
            // groupBoxConfirmare
            // 
            this.groupBoxConfirmare.Controls.Add(this.radioNuConfirma);
            this.groupBoxConfirmare.Controls.Add(this.radioConfirma);
            this.groupBoxConfirmare.Location = new System.Drawing.Point(15, 308);
            this.groupBoxConfirmare.Name = "groupBoxConfirmare";
            this.groupBoxConfirmare.Size = new System.Drawing.Size(502, 43);
            this.groupBoxConfirmare.TabIndex = 15;
            this.groupBoxConfirmare.TabStop = false;
            this.groupBoxConfirmare.Text = "-";
            this.groupBoxConfirmare.Enter += new System.EventHandler(this.groupBoxConfirmare_Enter);
            // 
            // radioNuConfirma
            // 
            this.radioNuConfirma.AutoSize = true;
            this.radioNuConfirma.Location = new System.Drawing.Point(220, 21);
            this.radioNuConfirma.Name = "radioNuConfirma";
            this.radioNuConfirma.Size = new System.Drawing.Size(190, 20);
            this.radioNuConfirma.TabIndex = 15;
            this.radioNuConfirma.TabStop = true;
            this.radioNuConfirma.Text = "Nu confirm datele introduse";
            this.radioNuConfirma.UseVisualStyleBackColor = true;
            this.radioNuConfirma.CheckedChanged += new System.EventHandler(this.radioNuConfirma_CheckedChanged);
            // 
            // FormPersoana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxConfirmare);
            this.Controls.Add(this.btnSalveaza);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.cmbTip);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nume);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtPrenume);
            this.Controls.Add(this.txtNume);
            this.Name = "FormPersoana";
            this.Text = "FormPersoana";
            this.Load += new System.EventHandler(this.FormPersoana_Load);
            this.groupBoxConfirmare.ResumeLayout(false);
            this.groupBoxConfirmare.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtPrenume;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label Nume;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbTip;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSalveaza;
        private System.Windows.Forms.RadioButton radioConfirma;
        private System.Windows.Forms.GroupBox groupBoxConfirmare;
        private System.Windows.Forms.RadioButton radioNuConfirma;
    }
}