using System.Runtime.CompilerServices;

namespace Classes
{
	internal class Program
	{
		static void Konyvek()
		{
			Konyv k1 = new Konyv("Egri csillagok", "Gárdonyi Géza", 1901, 555, 4500);
			Konyv k2 = new Konyv("Életem", "Én");
            Console.WriteLine(k1);
			k1.Arnoveles(500);
            Console.WriteLine(k1.Ar);
			k1.Kedvezmeny(0.2);
            Console.WriteLine(k1.Ar);
            Console.WriteLine(k1.HanyOldalMaradt(241));
            Console.WriteLine(k2);
			k2.Arnoveles(1000);
			k2.Kedvezmeny(0.01);
            Console.WriteLine(k2);
        }
		static void Filmek()
		{
			Film f1 = new Film("Shrek", "Andrew Adamson, Vicky Jenson", 90, "Animációs film", true);
			Film f2 = new Film("Tutel", "Petrik Lajos");
            Console.WriteLine(f1);
            Console.WriteLine(f2);
			f2.MufajModositas("Dokumentumfilm");
			f2.HosszNovelese(20);
			f2.Cim = "Iskola Budapesten";
            Console.WriteLine(f2);
			f1.Jatszas();
        }
		static void Main(string[] args)
		{
			Konyvek();
			Filmek();
		}
	}
}
