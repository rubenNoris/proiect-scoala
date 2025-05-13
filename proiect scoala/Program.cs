using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Intrinsics.X86;
using System.Text.RegularExpressions;

namespace proiect_scoala
{
    class Program
    {
        // Listă pentru stocarea firmelor și persoanelor
        static List<Firma> firme = new List<Firma>();
        static List<PersoanaFizica> persoane = new List<PersoanaFizica>();

        static void Main()
        {
            while (true)
            {
                Console.WriteLine("1. Adauga Firma");
                Console.WriteLine("2. Adauga Persoana");
                Console.WriteLine("3. Afiseaza Date");
                Console.WriteLine("4. Cauta Firma dupa CUI");
                Console.WriteLine("5. Cauta Persoana dupa Nume");
                Console.WriteLine("6. Iesire");
                Console.WriteLine("7. Citeste si Salveaza in Fisier");
                Console.WriteLine("8. Actualizeaza Firma");
                Console.WriteLine("9. Actualizeaza Persoana");
                Console.Write("Alege optiunea: ");
                int optiune;
                if (int.TryParse(Console.ReadLine(), out optiune))
                {
                    switch (optiune)
                    {
                        case 1:
                            firme.Add(CitesteFirma());
                            break;
                        case 2:
                            persoane.Add(CitestePersoana());
                            break;
                        case 3:
                            AfiseazaDate();
                            break;
                        case 4:
                            CautaFirma();
                            break;
                        case 5:
                            CautaPersoana();
                            break;
                        case 6:
                            return;
                        case 7:
                            CitesteSiSalveazaInFisier();
                            break;
                        case 8:
                            ActualizeazaFirma();
                            break;
                        case 9:
                            ActualizeazaPersoana();
                            break;
                        default:
                            Console.WriteLine("Optiune invalida!");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Optiune invalida! Introduceti un numar valid.");
                }
            }
        }

        // Citirea unei firme
        static Firma CitesteFirma()
        {
            Console.Write("Denumire: ");
            string denumire = Console.ReadLine();
            Console.Write("CUI: ");
            string cui = Console.ReadLine();
            Console.Write("Reprezentant Legal: ");
            string reprezentant = Console.ReadLine();
            Console.Write("Telefon: ");
            string telefon = Console.ReadLine();
            if (!ValidatePhone(telefon)) // Validare telefon
            {
                Console.WriteLine("Telefon invalid!");
                return null;
            }
            Console.Write("Email: ");
            string email = Console.ReadLine();
            if (!ValidateEmail(email)) // Validare email
            {
                Console.WriteLine("Email invalid!");
                return null;
            }
            Console.Write("Tip (0-Micro, 1-Mediu, 2-Multinationala): ");
            TipFirma tip = (TipFirma)int.Parse(Console.ReadLine());
            Console.Write("Status (0-Active, 1-Inactiva, 2-Inchisa): ");
            StatusFirma status = (StatusFirma)int.Parse(Console.ReadLine());

            return new Firma(firme.Count + 1, denumire, cui, reprezentant, telefon, email, tip, status);
        }

        // Citirea unei persoane
        static PersoanaFizica CitestePersoana()
        {
            Console.Write("Nume: ");
            string nume = Console.ReadLine();
            Console.Write("Prenume: ");
            string prenume = Console.ReadLine();
            Console.Write("Telefon: ");
            string telefon = Console.ReadLine();
            if (!ValidatePhone(telefon)) // Validare telefon
            {
                Console.WriteLine("Telefon invalid!");
                return null;
            }
            Console.Write("Email: ");
            string email = Console.ReadLine();
            if (!ValidateEmail(email)) // Validare email
            {
                Console.WriteLine("Email invalid!");
                return null;
            }
            Console.Write("Tip (0-Angajat, 1-Colaborator, 2-Partener): ");
            TipPersoana tip = (TipPersoana)int.Parse(Console.ReadLine());
            Console.Write("Status (0-Activ, 1-Inactiv): ");
            StatusPersoana status = (StatusPersoana)int.Parse(Console.ReadLine());

            return new PersoanaFizica(persoane.Count + 1, nume, prenume, telefon, email, tip, status);
        }

        // Validare telefon (exemplu simplu)
        static bool ValidatePhone(string phone)
        {
            var regex = new Regex(@"^\d{10}$"); // 10 cifre
            return regex.IsMatch(phone);
        }

        // Validare email
        static bool ValidateEmail(string email)
        {
            var regex = new Regex(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");
            return regex.IsMatch(email);
        }

        // Afisarea datelor firmelor și persoanelor
        static void AfiseazaDate()
        {
            Console.WriteLine("Firme:");
            foreach (var firma in firme)
            {
                Console.WriteLine($"Denumire: {firma.Denumire}");
                Console.WriteLine($"CUI: {firma.CUI}");
                Console.WriteLine($"Reprezentant Legal: {firma.ReprezentantLegal}");
                Console.WriteLine($"Telefon: {firma.Telefon}");
                Console.WriteLine($"Email: {firma.Email}");
                Console.WriteLine($"Tip: {firma.Tip}");
                Console.WriteLine($"Status: {firma.Status}");
                Console.WriteLine(); // Linie goala pentru separare
            }

            Console.WriteLine("\nPersoane:");
            foreach (var persoana in persoane)
            {
                Console.WriteLine($"Nume: {persoana.Nume}");
                Console.WriteLine($"Prenume: {persoana.Prenume}");
                Console.WriteLine($"Telefon: {persoana.Telefon}");
                Console.WriteLine($"Email: {persoana.Email}");
                Console.WriteLine($"Tip: {persoana.Tip}");
                Console.WriteLine($"Status: {persoana.Status}");
                Console.WriteLine();
            }
        }

        // Căutarea unei firme după CUI
        static void CautaFirma()
        {
            Console.Write("Introduceți CUI-ul firmei: ");
            string cuiCautat = Console.ReadLine();
            var firmaGasita = firme.Find(f => f.CUI == cuiCautat);

            if (firmaGasita != null)
            {
                Console.WriteLine($"Firma găsită: {firmaGasita.Denumire}, CUI: {firmaGasita.CUI}, Reprezentant: {firmaGasita.ReprezentantLegal}");
            }
            else
            {
                Console.WriteLine("Firma nu a fost găsită!");
            }
        }

        // Căutarea unei persoane după nume
        static void CautaPersoana()
        {
            Console.Write("Introduceți numele persoanei: ");
            string numeCautat = Console.ReadLine();
            var persoanaGasita = persoane.Find(p => p.Nume.Contains(numeCautat));

            if (persoanaGasita != null)
            {
                Console.WriteLine($"Persoana găsită: {persoanaGasita.Nume} {persoanaGasita.Prenume}, Telefon: {persoanaGasita.Telefon}");
            }
            else
            {
                Console.WriteLine("Persoana nu a fost găsită!");
            }
        }

        // Operația de actualizare a datelor pentru firmă
        static void ActualizeazaFirma()
        {
            Console.Write("Introduceți CUI-ul firmei de actualizat: ");
            string cuiCautat = Console.ReadLine();
            var firmaGasita = firme.Find(f => f.CUI == cuiCautat);
            if (firmaGasita != null)
            {
                Console.Write("Introduceti noua Denumire: ");
                firmaGasita.Denumire = Console.ReadLine();
                Console.Write("Introduceti noul Reprezentant Legal: ");
                firmaGasita.ReprezentantLegal = Console.ReadLine();
                string telefon;
                do
                {
                    Console.Write("Introduceti noul Telefon: ");
                    telefon = Console.ReadLine();
                    if (!ValidatePhone(telefon))
                        Console.WriteLine("Telefon invalid! Incercati din nou.");
                } while (!ValidatePhone(telefon));
                firmaGasita.Telefon = telefon;

                string email;
                do
                {
                    Console.Write("Introduceti noul Email: ");
                    email = Console.ReadLine();
                    if (!ValidateEmail(email))
                        Console.WriteLine("Email invalid! Incercati din nou.");
                } while (!ValidateEmail(email));
                firmaGasita.Email = email;
            }
            else
            {
                Console.WriteLine("Firma nu a fost găsită!");
            }
        }

        // Operația de actualizare a datelor pentru persoană
        static void ActualizeazaPersoana()
        {
            Console.Write("Introduceți numele persoanei de actualizat: ");
            string numeCautat = Console.ReadLine();
            var persoanaGasita = PersoanaFizica.CautaPersoanaDupaNume(persoane, numeCautat);
            if (persoanaGasita != null)
            {
                Console.Write("Introduceti noul Prenume: ");
                persoanaGasita.Prenume = Console.ReadLine();

                string telefon;
                do
                {
                    Console.Write("Introduceti noul Telefon: ");
                    telefon = Console.ReadLine();
                    if (!ValidatePhone(telefon))
                        Console.WriteLine("Telefon invalid! Incercati din nou.");
                } while (!ValidatePhone(telefon));
                persoanaGasita.Telefon = telefon;

                string email;
                do
                {
                    Console.Write("Introduceti noul Email: ");
                    email = Console.ReadLine();
                    if (!ValidateEmail(email))
                        Console.WriteLine("Email invalid! Incercati din nou.");
                } while (!ValidateEmail(email));
                persoanaGasita.Email = email;
            }
            else
            {
                Console.WriteLine("Persoana nu a fost găsită!");
            }
        }

        // Citirea și salvarea datelor într-un fișier
        static void CitesteSiSalveazaInFisier()
        {
            string fisierFirme = "firme.txt";
            string fisierPersoane = "persoane.txt";

            // Salvarea datelor firmelor într-un fișier
            using (StreamWriter sw = new StreamWriter(fisierFirme))
            {
                foreach (var firma in firme)
                {
                    sw.WriteLine($"{firma.Denumire},{firma.CUI},{firma.ReprezentantLegal},{firma.Telefon},{firma.Email},{firma.Tip},{firma.Status}");
                }
            }

            // Salvarea datelor persoanelor într-un fișier
            using (StreamWriter sw = new StreamWriter(fisierPersoane))
            {
                foreach (var persoana in persoane)
                {
                    sw.WriteLine($"{persoana.Nume},{persoana.Prenume},{persoana.Telefon},{persoana.Email},{persoana.Tip},{persoana.Status}");
                }
            }

            Console.WriteLine("Datele au fost salvate!");
        }
    }
}
