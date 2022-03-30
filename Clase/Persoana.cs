using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Clase
{
	public class Persoana
	{
		// CONSTANTE
		private const char SEPARATOR_PRINCIPAL_FISIER = ';';

		public string Nume { get; set; }
		public string Prenume { get; set; }
		public int Nr_ore { get; set; }
		public int Varsta { get; set; }

		private int IdPers; // identificatorul unic al persoanei care utilizeaza calculatorul
		private const int ID = 0;
		private const int NUME = 1;
		private const int PRENUME = 2;
		private const int VARSTA = 3;
		private const int Nr_ORE = 4;


		public Persoana()
		{
			IdPers = 0;
			Nume = string.Empty;
			Prenume = string.Empty;
			Varsta = 0;
			IdPers = 0;

		}

		// constructorul cu parametrii (elementele constituente ale Persoanei)

		public Persoana(int idPers, string nume, string prenume, int varsta, int nr_ore)
		{
			this.IdPers = idPers;
			this.Nume = nume;
			this.Prenume = prenume;
			this.Varsta = varsta;
			this.Nr_ore = nr_ore;
		}


		public void SetcodPersoana(int id)
        {
			IdPers = id;
        }


		// Constructor cu un singur parametru de tip string

		public Persoana(string linieFisier)
        {
			var dateFisier = linieFisier.Split(SEPARATOR_PRINCIPAL_FISIER);

			IdPers = Convert.ToInt32(dateFisier[ID]);
			Nume = dateFisier[NUME];
			Prenume = dateFisier[PRENUME];
			Varsta = Convert.ToInt32(dateFisier[VARSTA]);
			Nr_ore = Convert.ToInt32(dateFisier[Nr_ORE]);
        }


		// Conversia catre string
		public string ConversieLaSir_PentruFisier()
        {
			string obiectPersoanaPentruFisier = string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}{0}",
				SEPARATOR_PRINCIPAL_FISIER,
				IdPers.ToString(),
				(Nume ?? " NECUNOSCUT "),
				(Prenume ?? " NECUNOSCUT "),
				Varsta.ToString(),
				Nr_ore.ToString());
			return obiectPersoanaPentruFisier;
        }

		// WIP - TBA
		public void StergePersoana()
		{
		}

		// Return pentru fiecare element
		public int GetIdPers()
		{
			return IdPers;
		}

		public string GetNume()
        {
			return Nume;
        }

		public string GetPrenume()
		{
			return Prenume;
		}

		public int GetVarsta()
        {
			return Varsta;
        }

		public int Getnr_ore()
        {
			return Nr_ore;
        }



	}
}

