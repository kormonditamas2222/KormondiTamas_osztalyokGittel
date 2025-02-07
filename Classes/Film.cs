using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
	internal class Film
	{
		private string cim;
		private string rendezo;
		private int hosszPercekben;
		private string mufaj;
		private bool megjelent;

		
		public Film(string cim, string rendezo, int hosszPercekben, string mufaj, bool megjelent)
		{
			this.cim = cim;
			this.rendezo = rendezo;
			this.hosszPercekben = hosszPercekben;
			this.mufaj = mufaj;
			this.megjelent = megjelent;
		}
		public Film(string cim, string rendezo)
		{
			this.cim = cim;
			this.rendezo = rendezo;
			this.hosszPercekben = 120;
			this.mufaj = "Ismeretlen";
			this.megjelent = false;
		}
		public string Cim { get => cim; set => cim = value; }
		public string Rendezo { get => rendezo; set => rendezo = value; }
		public int HosszPercekben { get => hosszPercekben; set => hosszPercekben = value; }
		public string Mufaj { get => mufaj; set => mufaj = value; }
		public bool Megjelent { get => megjelent; set => megjelent = value; }
		public void Jatszas()
		{
            Console.WriteLine(this.cim + " film vetítése elkezdődött.");
        }
		public string MufajModositas(string ujMufaj)
		{
			return this.mufaj = ujMufaj;
		}
		public int HosszNovelese(int percek)
		{
			return this.hosszPercekben += percek;
		}
		public override string ToString()
		{
			return $"{this.cim} nevű film, rendező: {this.rendezo}, hossza {this.hosszPercekben} perc, műfaj: {this.mufaj}, megjelent? {this.megjelent}";
		}
	}
}
