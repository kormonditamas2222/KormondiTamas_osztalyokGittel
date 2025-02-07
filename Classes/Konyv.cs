using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
	internal class Konyv
	{
		private string cim;
		private string szerzo;
		private int kiadasEve;
		private int oldalszam;
		private double ar;
		public Konyv(string cim, string szerzo, int kiadasEve, int oldalszam, int ar)
		{
			this.cim = cim;
			this.szerzo = szerzo;
			this.kiadasEve = kiadasEve;
			this.oldalszam = oldalszam;
			this.ar = ar;
		}
		public Konyv(string cim, string szerzo) 
		{
			this.cim = cim;
			this.szerzo = szerzo;
			this.kiadasEve = DateTime.Now.Year;
			this.oldalszam = 200;
			this.ar = 3000;
		}
		public string Cim { get => cim; set => cim = value; }
		public string Szerzo { get => szerzo; set => szerzo = value; }
		public int KiadasEve { get => kiadasEve; set => kiadasEve = value; }
		public int Oldalszam { get => oldalszam; set => oldalszam = value; }
		public double Ar { get => ar; set => ar = value; }
		public double Arnoveles(int osszeg)
		{
			return this.ar += osszeg;
		}
		public double Kedvezmeny(double szazalek)
		{
			return this.ar -= this.ar * szazalek;
		}
		public int HanyOldalMaradt(int elolvasott)
		{
			return this.oldalszam - elolvasott;
		}
		public override string ToString()
		{
			return $"{this.cim} {this.szerzo} {this.kiadasEve} {this.oldalszam} {this.ar}";
		}
	}
}
