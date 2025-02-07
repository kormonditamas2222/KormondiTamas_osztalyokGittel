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
		static void Main(string[] args)
		{
			Konyvek();
		}
	}
}
