using System;
using System.Collections.Generic;
using System.Linq;

namespace proiect_scoala
{
    // Enum pentru Tipul unei persoane
    public enum TipPersoana
    {
        Angajat,
        Colaborator,
        Partener
    }

    // Enum pentru Statusul unei persoane
    public enum StatusPersoana
    {
        Activ,
        Inactiv
    }

    // Clasa PersoanaFizica
    public class PersoanaFizica
    {
        public int Id { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public TipPersoana Tip { get; set; }
        public StatusPersoana Status { get; set; }

        // Constructorul clasei
        public PersoanaFizica(int id, string nume, string prenume, string telefon, string email, TipPersoana tip, StatusPersoana status)
        {
            Id = id;
            Nume = nume;
            Prenume = prenume;
            Telefon = telefon;
            Email = email;
            Tip = tip;
            Status = status;
        }

        // Metodă de adăugare persoană
        public static void AdaugaClient(List<PersoanaFizica> persoane, PersoanaFizica client)
        {
            persoane.Add(client);
        }

        // Metodă de modificare persoană
        public static void ModificaClient(List<PersoanaFizica> persoane, int id, PersoanaFizica clientNou)
        {
            var client = persoane.FirstOrDefault(p => p.Id == id);
            if (client != null)
            {
                client.Nume = clientNou.Nume;
                client.Prenume = clientNou.Prenume;
                client.Telefon = clientNou.Telefon;
                client.Email = clientNou.Email;
                client.Tip = clientNou.Tip;
                client.Status = clientNou.Status;
            }
        }

        // Metodă de căutare persoană după nume
        public static PersoanaFizica CautaPersoanaDupaNume(List<PersoanaFizica> persoane, string numeCautat)
        {
            return persoane.FirstOrDefault(p => p.Nume.Equals(numeCautat, StringComparison.OrdinalIgnoreCase));
        }
    }
}
