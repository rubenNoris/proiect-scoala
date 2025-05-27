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
    public partial class FormPersoana: Form
    {
        public FormPersoana()
        {
            InitializeComponent();
            
            cmbTip.DataSource = Enum.GetValues(typeof(TipPersoana));
            cmbStatus.DataSource = Enum.GetValues(typeof(StatusPersoana));
        }

        private void txtNume_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrenume_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefon_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
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
                // Confirmare introducere
                if (!radioConfirma.Checked)
                {
                    MessageBox.Show("Trebuie să confirmi că datele introduse sunt corecte.");
                    return;
                }

                string nume = txtNume.Text.Trim();
                string prenume = txtPrenume.Text.Trim();
                string telefon = txtTelefon.Text.Trim();
                string email = txtEmail.Text.Trim();

                // Validări
                if (string.IsNullOrWhiteSpace(nume) ||
                    string.IsNullOrWhiteSpace(prenume) ||
                    string.IsNullOrWhiteSpace(telefon) ||
                    string.IsNullOrWhiteSpace(email))
                {
                    MessageBox.Show("Toate câmpurile trebuie completate.");
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

                // Creare obiect persoană și adăugare
                var persoanaNoua = new PersoanaFizica(
                 id: DateAplicatie.Persoane.Count + 1,
                 nume: txtNume.Text,
                 prenume: txtPrenume.Text,
                 telefon: txtTelefon.Text,
                 email: txtEmail.Text,
                 tip: (TipPersoana)cmbTip.SelectedItem,
                 status: (StatusPersoana)cmbStatus.SelectedItem
  );

                PersoanaFizica.AdaugaClient(DateAplicatie.Persoane, persoanaNoua);
                DateAplicatie.SalveazaPersoaneInTxt("persoane.txt");
                MessageBox.Show("Persoana a fost adăugată cu succes!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare: " + ex.Message);
            }
            DateAplicatie.SalveazaDate();
        }



        private void FormPersoana_Load(object sender, EventArgs e)
        {
            //DateAplicatie.IncarcaPersoane();
        }

        private void radioNuConfirma_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioConfirma_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBoxConfirmare_Enter(object sender, EventArgs e)
        {

        }
    }
}
