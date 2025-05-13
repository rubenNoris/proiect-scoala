using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using proiect_scoala;

namespace FormaFirma
{
    public partial class FormFirma: Form
    {
        public FormFirma()
        {
            InitializeComponent();
            
            cmbTip.DataSource = Enum.GetValues(typeof(TipFirma));
            cmbStatus.DataSource = Enum.GetValues(typeof(StatusFirma));
        }

        private void FormFirma_Load(object sender, EventArgs e)
        {

        }

        private void txtCUI_TextChanged(object sender, EventArgs e)
        {

        }

        private void textReprezentant_TextChanged(object sender, EventArgs e)
        {

        }

        private void textTelefon_TextChanged(object sender, EventArgs e)
        {

        }

        private void textEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbTip_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSalveaza_Click(object sender, EventArgs e)
        {
            try
            {
                var firmaNoua = new Firma(
                    id: DateAplicatie.Firme.Count + 1,
                    denumire: txtDenumire.Text,
                    cui: txtCUI.Text,
                    reprezentantLegal: textReprezentant.Text,
                    telefon: textTelefon.Text,
                    email: textEmail.Text,
                    tip: (TipFirma)cmbTip.SelectedItem,
                    status: (StatusFirma)cmbStatus.SelectedItem
                );

                Firma.AdaugaFirma(DateAplicatie.Firme, firmaNoua);
                MessageBox.Show("Firma a fost adăugată cu succes!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la adăugare: " + ex.Message);
            }

        }
    }
}
