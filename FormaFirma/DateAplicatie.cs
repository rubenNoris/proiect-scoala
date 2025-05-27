using System;
using System.Collections.Generic;
using System.IO;







namespace proiect_scoala
{
    public static class DateAplicatie
    {
        public static List<Firma> Firme = new List<Firma>();
        public static List<PersoanaFizica> Persoane = new List<PersoanaFizica>();


        public static string CaleFirme = "firme.txt";
        public static string CalePersoane = "persoane.txt";



        //MessageBox.Show("Număr firme: " + DateAplicatie.Firme.Count);
        //dgvFirme.DataSource = null;
        //dgvFirme.DataSource = DateAplicatie.Firme;
        public static void IncarcaDate()
        {
            Persoane = IncarcaPersoane(CalePersoane);
            Firme = IncarcaFirme(CaleFirme);
        }


        public static void SalveazaDate()
        {
            SalveazaFirme(Firme, CaleFirme);       // salvează în firme.txt
            SalveazaPersoane(Persoane, CalePersoane); // salvează în persoane.txt
        }


        public static void SalveazaFirme(List<Firma> firme, string cale)
        {
            using (StreamWriter sw = new StreamWriter(cale))
            {
                foreach (var firma in firme)
                {
                    string linie = $"{firma.Id},{firma.Denumire},{firma.CUI},{firma.Telefon},{firma.Email},{firma.Status}";
                    sw.WriteLine(linie);
                }
            }
        }


        public static List<Firma> IncarcaFirme(string cale)
        {
            var firme = new List<Firma>();
            if (!File.Exists(cale)) return firme;

            foreach (var linie in File.ReadAllLines(cale))
            {
                var valori = linie.Split(',');
                if (valori.Length == 6)
                {
                    TipFirma tipFirma = Enum.TryParse(valori[6], out TipFirma tip) ? tip : TipFirma.Micro;
                    StatusFirma statusFirma = Enum.TryParse(valori[7], out StatusFirma status) ? status : StatusFirma.Active;

                    firme.Add(new Firma
                    {
                        Id = int.Parse(valori[0]),
                        Denumire = valori[1],
                        CUI = valori[2],
                        ReprezentantLegal = valori[3],
                        Telefon = valori[4],
                        Email = valori[5],
                        Tip = tipFirma,
                        Status = statusFirma
                    });

                }
            }

            return firme;
        }


        public static void SalveazaPersoane(List<PersoanaFizica> persoane, string cale)
        {
            using (StreamWriter sw = new StreamWriter(cale))
            {
                foreach (var p in persoane)
                {
                    string linie = $"{p.Id},{p.Nume},{p.Prenume},{p.Telefon},{p.Email},{p.Tip},{p.Status}";
                    sw.WriteLine(linie);
                }
            }
        }

        public static List<PersoanaFizica> IncarcaPersoane(string cale)
        {
            var persoane = new List<PersoanaFizica>();

            if (!File.Exists(cale))
                return persoane;

            var linii = File.ReadAllLines(cale);

            foreach (var linie in linii)
            {
                var valori = linie.Split(',');

                if (valori.Length < 7)
                    continue; // Ignoră liniile invalide

                bool tipOk = Enum.TryParse(valori[5], true, out TipPersoana tip);
                bool statusOk = Enum.TryParse(valori[6], true, out StatusPersoana status);

                if (!tipOk || !statusOk)
                    continue; // Ignoră dacă nu poate parsa enum-urile

                persoane.Add(new PersoanaFizica
                {
                    Id = int.Parse(valori[0]),
                    Nume = valori[1],
                    Prenume = valori[2],
                    Telefon = valori[3],
                    Email = valori[4],
                    Tip = tip,
                    Status = status
                });
            }

            return persoane;
        }


        public static void SalveazaFirmeInTxt(string caleFisier)
        {
            using (StreamWriter sw = new StreamWriter(caleFisier))
            {
                foreach (var firma in Firme)
                {
                    sw.WriteLine($"{firma.Id}|{firma.Denumire}|{firma.CUI}|{firma.ReprezentantLegal}|{firma.Telefon}|{firma.Email}|{firma.Tip}|{firma.Status}");
                }
            }
        }

        public static void SalveazaPersoaneInTxt(string caleFisier)
        {
            using (StreamWriter sw = new StreamWriter(caleFisier))
            {
                foreach (var persoana in Persoane)
                {
                    sw.WriteLine($"{persoana.Id}|{persoana.Nume}|{persoana.Prenume}|{persoana.Telefon}|{persoana.Email}|{persoana.Tip}|{persoana.Status}");
                }
            }
        }

    }




}
