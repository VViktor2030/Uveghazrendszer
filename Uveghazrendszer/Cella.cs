using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uveghazrendszer
{
	internal class Cella
	{
		Pozicio pozicio;
		NovenyFaj novenyFaj;
		int egyedSzam;
		List<Szenzor> szenzorok;
		List<Riasztas> riasztasok;

		public Cella(int x, int y)
		{
			pozicio = new Pozicio(x, y);
			novenyFaj = null;
			egyedSzam = 0;
			szenzorok = new List<Szenzor>();
			riasztasok = new List<Riasztas>();
		}

		public int EgyedSzam { get => egyedSzam; set => egyedSzam = value; }
		internal Pozicio Pozicio { get => pozicio; set => pozicio = value; }
		internal NovenyFaj NovenyFaj { get => novenyFaj; set => novenyFaj = value; }
		internal List<Szenzor> Szenzorok { get => szenzorok; set => szenzorok = value; }
		internal List<Riasztas> Riasztasok { get => riasztasok; set => riasztasok = value; }

		public bool UresE
		{
			get
			{
				return egyedSzam == 0;
			}
		}
		public bool Telepit(NovenyFaj noveny, int mennyiseg)
		{
			bool sikeres = false;
			if (mennyiseg > 0)
			{
			if (UresE)
			{
				novenyFaj = noveny;
				egyedSzam = mennyiseg;
				Console.WriteLine($"Sikeres telepítés: {noveny.Nev}");
				sikeres = true;
			}
			else if (novenyFaj.Equals(noveny))
			{
					Noveles(mennyiseg);
			}

			}

			else
			{
				Console.WriteLine("A mennyiség nem lehet 0 vagy negatív");
			}

			return sikeres;
		}
		public void Noveles(int mennyi)
		{
			egyedSzam += mennyi;
		}


		public void Csokkentes(int mennyi)
		{
			egyedSzam -= mennyi;
			if(egyedSzam <= 0)
			{
				Urites();
			}

		}
		public void Urites()
		{
			novenyFaj = null;
			egyedSzam = 0;
		}
		public override string ToString()
		{
			string str = "";
			if (UresE)
			{
				str = $"| {"üres",9} ";
			}
			else
			{
				str = $"| {novenyFaj.Azonosito,3} {this.egyedSzam,2}db";
			}
			return str;
		}
	}
}
