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
                MessageBox.Show("Persoana a fost adăugată cu succes!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la adăugare: " + ex.Message);
            }
        }
    }
}
