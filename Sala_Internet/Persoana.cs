using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sala_Internet
{
	class Persoana
	{
		public string nume { get; set; }
		public string prenume { get; set; }
		public static int pers_index = 0;
		public int nr_ore { get; set; }
		public int varsta { get; set; }


		public Persoana(string _nume, string _prenume, int _nr_ore, int _varsta)
		{
			nume = _nume;
			prenume = _prenume;
			nr_ore = _nr_ore;
			varsta = _varsta;
			pers_index++;
		}

		public void AdaugaPersoana()
		{
			Persoana persoana0 = new Persoana("Alexuc", "Razvan", 3, 20);
			Persoana persoana1 = new Persoana("Rosca", "Alexandru", 5, 21);
			Persoana persoana2 = new Persoana("Mihai", "Ion", 2, 19);

			List<Persoana> Persoane = new List<Persoana>
			{
				persoana0,
				persoana1,
				persoana2
			};


		}
		public void StergePersoana()
		{
		}
	}
}