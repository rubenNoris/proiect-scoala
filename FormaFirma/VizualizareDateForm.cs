using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace proiect_scoala
{
    public partial class VizualizareDateForm : Form
    {
        public VizualizareDateForm()
        {
            InitializeComponent();
            IncarcaDateInGrid();
        }

        private void IncarcaDateInGrid()
        {
            dgvFirme.DataSource = null;
            dgvFirme.DataSource = DateAplicatie.Firme;

            dgvPersoane.DataSource = null;
            dgvPersoane.DataSource = DateAplicatie.Persoane;
        }

        private void dgvPersoane_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Cauta_Click(object sender, EventArgs e)
        {
            string cautat = txtCautare.Text.ToLower();

            var firmeFiltrate = DateAplicatie.Firme
                .Where(f => f.Denumire.ToLower().Contains(cautat) || f.CUI.ToLower().Contains(cautat))
                .ToList();

            dgvFirme.DataSource = null;
            dgvFirme.DataSource = firmeFiltrate;

            var persoaneFiltrate = DateAplicatie.Persoane
                .Where(p => p.Nume.ToLower().Contains(cautat) || p.Prenume.ToLower().Contains(cautat))
                .ToList();

            dgvPersoane.DataSource = null;
            dgvPersoane.DataSource = persoaneFiltrate;
        }

        private void btnSalveaza_Click(object sender, EventArgs e)
        {
            // actualizare firme
            DateAplicatie.Firme = ((List<Firma>)dgvFirme.DataSource).ToList();

            // actualizare persoane
            DateAplicatie.Persoane = ((List<PersoanaFizica>)dgvPersoane.DataSource).ToList();

            // salvare în fișier
            DateAplicatie.SalveazaDate();
            DateAplicatie.SalveazaFirmeInTxt("firme.txt");
            DateAplicatie.SalveazaPersoaneInTxt("persoane.txt");

            MessageBox.Show("Modificările au fost salvate.");
          
        }

        private void FormVizualizareDate_Load(object sender, EventArgs e)
        {
            dgvFirme.DataSource = null;
            dgvFirme.DataSource = DateAplicatie.Firme;

            dgvPersoane.DataSource = null;
            dgvPersoane.DataSource = DateAplicatie.Persoane;

            dgvFirme.ReadOnly = false;
            dgvPersoane.ReadOnly = false;
            dgvFirme.AllowUserToAddRows = false;
            dgvPersoane.AllowUserToAddRows = false;

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            dgvFirme.DataSource = null;
            dgvFirme.DataSource = DateAplicatie.Firme;
            dgvPersoane.DataSource = null;
            dgvPersoane.DataSource = DateAplicatie.Persoane;

            // Dacă lucrezi cu persoane:
            // dataGridView1.DataSource = DateAplicatie.Persoane;

            // Dacă ai și un TextBox pentru căutare, golește-l:
            txtCautare.Text = "";
        }
    }
}
