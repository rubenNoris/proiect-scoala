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

using System.IO;



namespace FormaFirma
{
    public partial class FormProgramari : Form
    {
        public static string CaleFirme = "firme.txt";
        public static string CalePersoane = "persoane.txt";


        public FormProgramari()
        {
            InitializeComponent();
            this.Load += FormProgramari_Load;

        }

        // private void FormProgramari_Load(object sender, EventArgs e)
        // {
        //     DateAplicatie.IncarcaDate();

        //     DateAplicatie.Firme.Add(new Firma(
        //1, "Firma Test", "RO123456", "Ion Popescu", "0712345678", "firma@test.ro", TipFirma.Micro, StatusFirma.Active));
        //     AfiseazaFirme();
        //     AfiseazaPersoane();

        //     dgvFirme.DataSource = null;
        //     dgvFirme.DataSource = DateAplicatie.Firme;

        //     if (dgvFirme.Columns.Count > 0)
        //     {
        //         dgvFirme.Columns["Denumire"].HeaderText = "Denumire";
        //         // etc.
        //     }

        //     dvgPersoane.DataSource = null;
        //     dvgPersoane.DataSource = DateAplicatie.Persoane;

        //     if (dvgPersoane.Columns.Count > 0)
        //     {
        //         dvgPersoane.Columns["Nume"].HeaderText = "Nume";
        //         // etc.
        //     }

        // }

        private void FormProgramari_Load(object sender, EventArgs e)
        {
            DateAplicatie.IncarcaDate(); // Încărcare date din JSON

            MessageBox.Show("Număr firme: " + DateAplicatie.Firme.Count);
            MessageBox.Show("Număr persoane: " + DateAplicatie.Persoane.Count);

            dgvFirme.AutoGenerateColumns = true;
            dgvFirme.DataSource = null;
            dgvFirme.DataSource = DateAplicatie.Firme;

            dvgPersoane.AutoGenerateColumns = true;
            dvgPersoane.DataSource = null;
            dvgPersoane.DataSource = DateAplicatie.Persoane;
            DateAplicatie.IncarcaDate();

        }

        private void AfiseazaFirme()
        {
            dgvFirme.AutoGenerateColumns = true; // important!
            dgvFirme.DataSource = null;
            dgvFirme.DataSource = DateAplicatie.Firme;
        }

        private void AfiseazaPersoane()
        {
            dvgPersoane.DataSource = null;
            dvgPersoane.DataSource = DateAplicatie.Persoane;

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvPersoana_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvPersoana.DataSource = null;
            dgvPersoana.DataSource = DateAplicatie.Persoane.Concat<object>(DateAplicatie.Firme).ToList();

        }

        private void lstProgramari_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormProgramari_Load_1(object sender, EventArgs e)
        {

        }

        private void dgvFirma_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           dgvFirma.DataSource = null;
            dgvFirma.DataSource = DateAplicatie.Persoane.Concat<object>(DateAplicatie.Firme).ToList();

        }
    }
}
