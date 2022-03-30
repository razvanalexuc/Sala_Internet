using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase
{
    class Periferice
	{
		public string Monitor { get; set; }
		public string Mouse { get; set; }
		public string Tastatura { get; set; }
		public string Casti { get; set; }

		public Periferice(string monitor, string mouse, string tastatura, string casti)
		{
			this.Monitor = monitor;
			this.Mouse = mouse;
			this.Tastatura = tastatura;
			this.Casti = casti;
		}

		// WIP - TBA
		public void StergePeriferice()
		{
		}

		public string Getmonitor()
        {
			return Monitor;
        }

		public string Getmouse()
        {
			return Mouse;
        }

		public string Gettastatura()
        {
			return Tastatura;
        }

		public string Getcasti()
        {
			return Casti;
        }
	}
}
