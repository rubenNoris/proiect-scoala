using System;
using System.Collections.Generic;
using System.Linq;

namespace proiect_scoala
{
    // Enum pentru Tipul unei firme
    public enum TipFirma
    {
        Micro,
        Mediu,
        Multinationala
    }

    // Enum pentru Statusul unei firme
    public enum StatusFirma
    {
        Active,
        Inactiva,
        Inchisa
    }

    // Clasa Firma
    public class Firma
    {
        public int Id { get; set; }
        public string Denumire { get; set; }
        public string CUI { get; set; }
        public string ReprezentantLegal { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public TipFirma Tip { get; set; }
        public StatusFirma Status { get; set; }

        // Constructorul clasei
        public Firma(int id, string denumire, string cui, string reprezentantLegal, string telefon, string email, TipFirma tip, StatusFirma status)
        {
            Id = id;
            Denumire = denumire;
            CUI = cui;
            ReprezentantLegal = reprezentantLegal;
            Telefon = telefon;
            Email = email;
            Tip = tip;
            Status = status;
        }

        // Metodă de adăugare firmă
        public static void AdaugaFirma(List<Firma> firme, Firma firma)
        {
            firme.Add(firma);
        }

        // Metodă de modificare firmă
        public static void ModificaFirma(List<Firma> firme, int id, Firma firmaNoua)
        {
            var firma = firme.FirstOrDefault(f => f.Id == id);
            if (firma != null)
            {
                firma.Denumire = firmaNoua.Denumire;
                firma.CUI = firmaNoua.CUI;
                firma.ReprezentantLegal = firmaNoua.ReprezentantLegal;
                firma.Telefon = firmaNoua.Telefon;
                firma.Email = firmaNoua.Email;
                firma.Tip = firmaNoua.Tip;
                firma.Status = firmaNoua.Status;
            }
        }

        // Metodă de căutare firmă după CUI
        public static Firma CautaFirmaDupaCUI(List<Firma> firme, string cuiCautat)
        {
            return firme.FirstOrDefault(f => f.CUI.Equals(cuiCautat, StringComparison.OrdinalIgnoreCase));
        }
        public Firma() { }

    }
}
