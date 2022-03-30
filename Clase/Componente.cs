using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase
{
      public class Componente
	{
		public int RAM;
		public string CPU;
		public string GPU;
		public string cooler;
		public string HDD;
		public string SSD;

		public Componente(int ram, string procesor, string placa, string cool, string HardDisk, string SolidDrive)
		{
			this.RAM = ram;
			this.CPU = procesor;
			this.GPU = placa;
			this.cooler = cool;
			this.HDD = HardDisk;
			this.SSD = SolidDrive;
		}

		public int GetRAM()
        {
			return RAM;
        }

		public string GetCPU()
        {
			return CPU;
        }

		public string Getcool()
        {
			return cooler;
        }

		public string GetHardDisk()
        {
			return HDD;
        }

		public string GetSolidDrive()
        {
			return SSD;
        }

	}
}
