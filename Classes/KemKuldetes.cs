using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
	internal class KemKuldetes
	{
		private string kodnev;
		private string orszag;
		private int veszelySzint;
		private int sikerEsely;

		public KemKuldetes(string kodnev, string orszag, int veszelySzint, int sikerEsely)
		{
			this.kodnev = kodnev;
			this.orszag = orszag;
			this.veszelySzint = veszelySzint;
			this.sikerEsely = sikerEsely;
		}
		public KemKuldetes(string kodnev, string orszag)
		{
			this.kodnev = kodnev;
			this.orszag = orszag;
			this.veszelySzint = 5;
			this.sikerEsely = 50;
		}
		public string Kodnev { get => kodnev; set => kodnev = value; }
		public string Orszag { get => orszag; set => orszag = value; }
		public int VeszelySzint { get => veszelySzint; set => veszelySzint = value; }
		public int SikerEsely { get => sikerEsely; set => sikerEsely = value; }

		public void KuldetesInditasa()
		{
            Console.WriteLine(this.kodnev + " küldetés elkezdődött.");
        }
		public int VeszelySzintNovelese(int mennyiseg)
		{
			return this.veszelySzint += mennyiseg;
		}
		public int SikerEselyNovelese(int szazalek)
		{
			if (this.sikerEsely + szazalek >= 100)
			{
				return this.sikerEsely = 100;
			}
			else if (this.sikerEsely + szazalek < 100)
			{
				return this.sikerEsely += szazalek;
			}
			else
			{
				return this.sikerEsely;
			}
		}
		public override string ToString()
		{
			return $"Küldetés kódneve: {this.kodnev}, {this.orszag}, veszélyszint: {this.veszelySzint}, siker esélye: {this.sikerEsely}%";
		}
	}
}
