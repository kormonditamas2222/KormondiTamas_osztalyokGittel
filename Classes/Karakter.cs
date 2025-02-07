using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
	internal class Karakter
	{
		private string nev;
		private int szint;
		private int eletero;
		private int ero;

		public Karakter(string nev, int szint, int eletero, int ero)
		{
			this.nev = nev;
			this.szint = szint;
			this.eletero = eletero;
			this.ero = ero;
		}
		public Karakter(string nev, int ero) 
		{
			this.nev = nev;
			this.szint = 1;
			this.eletero = 100;
			this.ero = ero;
		}

		public string Nev { get => nev; set => nev = value; }
		public int Szint { get => szint; set => szint = value; }
		public int Eletero { get => eletero; set => eletero = value; }
		public int Ero { get => ero; set => ero = value; }

		public void Tamadas()
		{
            Console.WriteLine("A karakter támad, " + this.ero + " erővel");
        }
		public int Gyogyulas(int mennyiseg)
		{
			return this.eletero += mennyiseg;
		}
		public void Szintlepes()
		{
			this.szint += 1;
			this.ero += 1;
		}

		public override string ToString()
		{
			return $"Karakter neve: {this.nev}, szintje: {this.szint}, életereje: {this.eletero} HP, ereje: {this.ero} ";
		}
	}
}
