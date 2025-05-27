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
                // 1. Verificare CheckBox
                if (!checkBoxConfirmare.Checked)
                {
                    MessageBox.Show("Trebuie să confirmi că datele sunt corecte.");
                    return;
                }

                // 2. Preluare date
                string denumire = txtDenumire.Text.Trim();
                string cui = txtCUI.Text.Trim();
                string reprezentant = textReprezentant.Text.Trim();
                string telefon = textTelefon.Text.Trim();
                string email = textEmail.Text.Trim();
                TipFirma tip = (TipFirma)cmbTip.SelectedItem;
                StatusFirma status = (StatusFirma)cmbStatus.SelectedItem;

                // 3. Validări
                if (string.IsNullOrWhiteSpace(denumire) ||
                    string.IsNullOrWhiteSpace(cui) ||
                    string.IsNullOrWhiteSpace(reprezentant) ||
                    string.IsNullOrWhiteSpace(telefon) ||
                    string.IsNullOrWhiteSpace(email))
                {
                    MessageBox.Show("Toate câmpurile trebuie completate.");
                    return;
                }

                if (!cui.All(char.IsDigit))
                {
                    MessageBox.Show("CUI-ul trebuie să conțină doar cifre.");
                    return;
                }

                if (!telefon.All(char.IsDigit) || telefon.Length != 10)
                {
                    MessageBox.Show("Numărul de telefon trebuie să conțină exact 10 cifre.");
                    return;
                }

                if (!email.Contains("@"))
                {
                    MessageBox.Show("Email-ul trebuie să conțină caracterul '@'.");
                    return;
                }
                DateAplicatie.SalveazaDate();

                // 4. Creare firmă
                var firmaNoua = new Firma(
                    id: DateAplicatie.Firme.Count + 1,
                    denumire: denumire,
                    cui: cui,
                    reprezentantLegal: reprezentant,
                    telefon: telefon,
                    email: email,
                    tip: tip,
                    status: status
                );

                Firma.AdaugaFirma(DateAplicatie.Firme, firmaNoua);
                DateAplicatie.SalveazaFirmeInTxt("firme.txt");
                MessageBox.Show("Firma a fost adăugată cu succes!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la adăugare: " + ex.Message);
            }

           
            

           
        }


        private void checkBoxConfirmare_CheckedChanged(object sender, EventArgs e)
        {

        }
        public static void AdaugaFirma(List<Firma> listaFirme, Firma firmaNoua)
        {
            listaFirme.Add(firmaNoua);
        }
    }
}
