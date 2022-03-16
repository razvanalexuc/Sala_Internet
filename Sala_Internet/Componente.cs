using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sala_Internet
{
	class Componente
	{
		public int RAM;
		public string CPU;
		public string GPU;
		public string cooler;
		public string HDD;
		public string SSD;

		public Componente(int ram, string procesor, string placa, string cool, string HardDisk, string SolidDrive)
		{
			RAM = ram;
			CPU = procesor;
			GPU = placa;
			cooler = cool;
			HDD = HardDisk;
			SSD = SolidDrive;
		}

	}
}
