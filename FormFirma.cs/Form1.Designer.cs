namespace FormFirma.cs
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox txtDenumire;
        private System.Windows.Forms.TextBox txtCUI;
        private System.Windows.Forms.TextBox txtReprezentant;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.ComboBox cmbTip;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Button btnAdaugaFirma;
        private System.Windows.Forms.Label labelDenumire;
        private System.Windows.Forms.Label labelCUI;
        private System.Windows.Forms.Label labelReprezentant;
        private System.Windows.Forms.Label labelTelefon;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelTip;
        private System.Windows.Forms.Label labelStatus;

        // Metoda care inițializează controalele formularului
        private void InitializeComponent()
        {
            this.txtDenumire = new System.Windows.Forms.TextBox();
            this.txtCUI = new System.Windows.Forms.TextBox();
            this.txtReprezentant = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.cmbTip = new System.Windows.Forms.ComboBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.btnAdaugaFirma = new System.Windows.Forms.Button();
            this.labelDenumire = new System.Windows.Forms.Label();
            this.labelCUI = new System.Windows.Forms.Label();
            this.labelReprezentant = new System.Windows.Forms.Label();
            this.labelTelefon = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelTip = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();

            // Configurarea controalelor
            this.SuspendLayout();

            // TextBox - Denumire
            this.txtDenumire.Location = new System.Drawing.Point(120, 50);
            this.txtDenumire.Name = "txtDenumire";
            this.txtDenumire.Size = new System.Drawing.Size(200, 20);
            this.txtDenumire.TabIndex = 0;

            // TextBox - CUI
            this.txtCUI.Location = new System.Drawing.Point(120, 90);
            this.txtCUI.Name = "txtCUI";
            this.txtCUI.Size = new System.Drawing.Size(200, 20);
            this.txtCUI.TabIndex = 1;

            // TextBox - Reprezentant
            this.txtReprezentant.Location = new System.Drawing.Point(120, 130);
            this.txtReprezentant.Name = "txtReprezentant";
            this.txtReprezentant.Size = new System.Drawing.Size(200, 20);
            this.txtReprezentant.TabIndex = 2;

            // TextBox - Telefon
            this.txtTelefon.Location = new System.Drawing.Point(120, 170);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(200, 20);
            this.txtTelefon.TabIndex = 3;

            // TextBox - Email
            this.txtEmail.Location = new System.Drawing.Point(120, 210);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 20);
            this.txtEmail.TabIndex = 4;

            // ComboBox - Tip Firma
            this.cmbTip.Location = new System.Drawing.Point(120, 250);
            this.cmbTip.Name = "cmbTip";
            this.cmbTip.Size = new System.Drawing.Size(200, 21);
            this.cmbTip.TabIndex = 5;

            // ComboBox - Status Firma
            this.cmbStatus.Location = new System.Drawing.Point(120, 290);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(200, 21);
            this.cmbStatus.TabIndex = 6;

            // Button - Adaugă Firmă
            this.btnAdaugaFirma.Location = new System.Drawing.Point(120, 330);
            this.btnAdaugaFirma.Name = "btnAdaugaFirma";
            this.btnAdaugaFirma.Size = new System.Drawing.Size(200, 23);
            this.btnAdaugaFirma.TabIndex = 7;
            this.btnAdaugaFirma.Text = "Adaugă Firmă";
            this.btnAdaugaFirma.UseVisualStyleBackColor = true;
            this.btnAdaugaFirma.Click += new System.EventHandler(this.btnAdaugaFirma_Click);

            // Label - Denumire
            this.labelDenumire.Location = new System.Drawing.Point(20, 50);
            this.labelDenumire.Name = "labelDenumire";
            this.labelDenumire.Size = new System.Drawing.Size(100, 20);
            this.labelDenumire.Text = "Denumire:";

            // Label - CUI
            this.labelCUI.Location = new System.Drawing.Point(20, 90);
            this.labelCUI.Name = "labelCUI";
            this.labelCUI.Size = new System.Drawing.Size(100, 20);
            this.labelCUI.Text = "CUI:";

            // Label - Reprezentant
            this.labelReprezentant.Location = new System.Drawing.Point(20, 130);
            this.labelReprezentant.Name = "labelReprezentant";
            this.labelReprezentant.Size = new System.Drawing.Size(100, 20);
            this.labelReprezentant.Text = "Reprezentant:";

            // Label - Telefon
            this.labelTelefon.Location = new System.Drawing.Point(20, 170);
            this.labelTelefon.Name = "labelTelefon";
            this.labelTelefon.Size = new System.Drawing.Size(100, 20);
            this.labelTelefon.Text = "Telefon:";

            // Label - Email
            this.labelEmail.Location = new System.Drawing.Point(20, 210);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(100, 20);
            this.labelEmail.Text = "Email:";

            // Label - Tip
            this.labelTip.Location = new System.Drawing.Point(20, 250);
            this.labelTip.Name = "labelTip";
            this.labelTip.Size = new System.Drawing.Size(100, 20);
            this.labelTip.Text = "Tip Firma:";

            // Label - Status
            this.labelStatus.Location = new System.Drawing.Point(20, 290);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(100, 20);
            this.labelStatus.Text = "Status Firma:";

            // Finalizarea configurării formularului
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.txtDenumire);
            this.Controls.Add(this.txtCUI);
            this.Controls.Add(this.txtReprezentant);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.cmbTip);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.btnAdaugaFirma);
            this.Controls.Add(this.labelDenumire);
            this.Controls.Add(this.labelCUI);
            this.Controls.Add(this.labelReprezentant);
            this.Controls.Add(this.labelTelefon);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelTip);
            this.Controls.Add(this.labelStatus);
            this.Name = "Form1";
            this.Text = "Formular Firmă";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
