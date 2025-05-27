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
    public partial class Form1: Form
    {
        string caleFisierFirme = "firme.json";
        string caleFisierPersoane = "persoane.json";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnFirma_Click(object sender, EventArgs e)
        {
            FormFirma formFirma = new FormFirma();
            formFirma.ShowDialog(); // Blochează până e închis
        }

        private void btnPersoana_Click(object sender, EventArgs e)
        {
            FormPersoana formPersoana = new FormPersoana();
            formPersoana.ShowDialog();
        }

        private void btnVeziProgramari_Click(object sender, EventArgs e)
        {
            VizualizareDateForm vizForm = new VizualizareDateForm();
            vizForm.ShowDialog();
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }
        
    }
}
