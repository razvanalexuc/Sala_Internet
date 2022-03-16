using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sala_Internet
{
	class Periferice
	{
		public string monitor { get; set; }
		public string mouse { get; set; }
		public string tastatura{ get; set; }
		public string casti { get; set; }

		public Periferice(string _monitor, string _mouse, string _tastatura, string _casti)
		{
			monitor = _monitor;
			mouse = _mouse;
			tastatura = _tastatura;
			casti = _casti;
		}

		public void AdaugaPeriferice()
		{
			Periferice set0 = new Periferice("Benq XL2411", "Logitech G102", "Redragon Vara", "Razer Kraken USB");
			Periferice set1 = new Periferice("Asus VX241", "ASUS TUF Gaming M3", "ASUS TUF Gaming K1", "HyperX Cloud Stinger");
			Periferice set2 = new Periferice("ASUS TUF VG247Q1A", "Logitech G PRO", "RAZER Huntsman V2", "HyperX Cloud White");
			List<Periferice> Periferice = new List<Periferice>
			{
				set0,
				set1,
				set2
			};
		}

		public void StergePeriferice()
		{
		}
	}
}
