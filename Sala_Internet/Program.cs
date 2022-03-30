using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.Specialized;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Clase;
using Administrare_Fisier;
using System.Configuration;

namespace Sala_Internet
{
	public class Program
	{
        private static string nume_pers;
        private static string cod_pers;
		static void Main(string[] args)
		{

            string numeFisier = args[0];
            AdministrarePersoane_FisierText administrarePersoane = new AdministrarePersoane_FisierText(numeFisier);
            Persoana persoananew = new Persoana();
            int nrPers = 0;

            string optiune;
            do
            {
                Console.WriteLine("A. Afisare Persoane din file ");
                Console.WriteLine("B. Salvare Persoane in file");
                Console.WriteLine("C. Citirea de la tastatura a persoanelor");
                Console.WriteLine("D. Cautarea unui utilizator al calculatorului");
                Console.WriteLine("CA. Adaugati componentele dorite"); // WIP - TBA
                Console.WriteLine("CB. Adaugati perifericele dorite"); // WIP - TBA
                Console.WriteLine("X. Inchidere program");
                Console.WriteLine("Alegeti o optiune");
                optiune = Console.ReadLine();
                switch (optiune.ToUpper())
                {
                    case "A":
                        Persoana[] persoane = administrarePersoane.GetPersoane(out nrPers);
                        AfisarePersoane(persoane, nrPers);
                        break;
                    case "B":
                        int idPers = nrPers++;
                        persoananew.SetcodPersoana(idPers);
                        administrarePersoane.AddPersoane(persoananew);

                        break;
                    case "C":
                        persoananew = CitireTastatura();
                        break;
                    case "D":
                        Console.WriteLine("Introduceti codul utilizatorului pe care doriti sa il cautati:");
                        cod_pers = Console.ReadLine();
                        Console.WriteLine("Introduceti numele utilizatorului pe care doriti sa il cautati:");
                        nume_pers = Console.ReadLine();
                        Persoana existingPers = administrarePersoane.CautarePersoana(cod_pers, nume_pers);
                        if (existingPers == null)
                        {
                            Console.WriteLine("Persoana cautata nu figureaza pe lista.");
                        }
                        else
                        {
                            Console.WriteLine(string.Format("Utilizatorul gasit are codul #{0} si se numeste: {1}",
                                existingPers.GetIdPers(),
                                existingPers.GetNume() ?? "NECUNOSCUT"));
                        }
                        break;
                    case "X":
                        return;
                    default:
                        Console.WriteLine("Optiunea introdusa este inexistenta!");
                        break;
                }
            } while (optiune.ToUpper() != "X");

            Console.ReadKey();
        }

        public static void AfisarePersoane(Persoana[] persoane, int nrPers)
        {
            Console.WriteLine("Utilizatorii calculatorului sunt:");
            for (int contor = 0; contor < nrPers; contor++)
            {
                string infoPersoana = string.Format("Utilizatorul cu id-ul #{0} are numele: {1} {2}, varsta de {3}, iar numarul de ore achizitionate este {4}",
                    persoane[contor].GetIdPers(),
                    persoane[contor].GetNume() ?? "NECUNOSCUT",
                    persoane[contor].GetPrenume() ?? "NECUNOSCUT",
                    persoane[contor].GetVarsta(),
                    persoane[contor].Getnr_ore());
                Console.WriteLine(infoPersoana);

            }
        }


        public static Persoana CitireTastatura()
        {
            Console.WriteLine("Introduceti numele si prenumele utilizatorului de calculator");
            string Nume = Console.ReadLine();
            string Prenume = Console.ReadLine();
            int Varsta = Convert.ToInt32(Console.ReadLine());
            int Nr_ore = Convert.ToInt32(Console.ReadLine());

            Persoana persoana = new Persoana(0, Nume, Prenume, Varsta, Nr_ore);
            return persoana;

        }



        // WIP - TBA
        public static void AfisareCalculator()
        {

        }


    }
	}
