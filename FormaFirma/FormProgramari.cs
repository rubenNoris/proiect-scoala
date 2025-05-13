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
    public partial class FormProgramari : Form
    {

        public FormProgramari()
        {
            InitializeComponent();
            this.Load += FormProgramari_Load;

        }

        private void FormProgramari_Load(object sender, EventArgs e)
        {
            
            DateAplicatie.Firme.Add(new Firma(
       1, "Firma Test", "RO123456", "Ion Popescu", "0712345678", "firma@test.ro", TipFirma.Micro, StatusFirma.Active));
            AfiseazaFirme();
            AfiseazaPersoane();

            dgvFirme.DataSource = null;
            dgvFirme.DataSource = DateAplicatie.Firme;

            if (dgvFirme.Columns.Count > 0)
            {
                dgvFirme.Columns["Denumire"].HeaderText = "Denumire";
                // etc.
            }

            dvgPersoane.DataSource = null;
            dvgPersoane.DataSource = DateAplicatie.Persoane;

            if (dvgPersoane.Columns.Count > 0)
            {
                dvgPersoane.Columns["Nume"].HeaderText = "Nume";
                // etc.
            }

        }

        private void AfiseazaFirme()
        {
            dgvFirme.AutoGenerateColumns = false; // important!
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

        }

        private void lstProgramari_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
