using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
	internal class Urhajo
	{
		private string nev;
		private int sebesseg;
		private int utaskapacitas;
		private int uzemanyagSzint;

		public Urhajo(string nev, int sebesseg, int utaskapacitas, int uzemanyagSzint)
		{
			this.nev = nev;
			this.sebesseg = sebesseg;
			this.utaskapacitas = utaskapacitas;
			this.uzemanyagSzint = uzemanyagSzint;
		}
		public Urhajo(string nev, int utaskapacitas)
		{
			this.nev = nev;
			this.sebesseg = 0;
			this.utaskapacitas = utaskapacitas;
			this.uzemanyagSzint = 100;
		}
		public string Nev { get => nev; set => nev = value; }
		public int Sebesseg { get => sebesseg; set => sebesseg = value; }
		public int Utaskapacitas { get => utaskapacitas; set => utaskapacitas = value; }
		public int UzemanyagSzint { get => uzemanyagSzint; set => uzemanyagSzint = value; }
		public void Indulas()
		{
			this.sebesseg += 100;
			this.uzemanyagSzint -= 10;
		}
		public int Tankolas(int mennyiseg)
		{
			if (this.uzemanyagSzint + mennyiseg >= 100)
			{
				return this.uzemanyagSzint = 100;
			}
			else if (this.uzemanyagSzint + mennyiseg < 100)
			{
				return this.uzemanyagSzint += mennyiseg;
			}
			else
			{
				return this.uzemanyagSzint;
			}
		}
		public void Landolas()
		{
			this.sebesseg = 0;
		}
		public override string ToString()
		{
			return $"Űrhajó neve: {this.nev}, sebessége: {this.sebesseg}, kapacitása: {this.utaskapacitas}, jelenlegi üzemanyagszint: {this.uzemanyagSzint}";
		}
	}
}
