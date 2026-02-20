using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uveghazrendszer
{
	internal class NovenyFaj
	{
		string nev;
		int nedvessegTartalom;
		int egeszsegSzint;
		int optimalisSuruseg;



		public NovenyFaj(string nev, int optimalisSuruseg)
		{
			this.nev = nev;
			this.optimalisSuruseg = optimalisSuruseg;
			nedvessegTartalom = 100;
			egeszsegSzint = 100;
		}

		public string Nev { get => nev; set => nev = value; }
		public int NedvessegTartalom { get => nedvessegTartalom; set => nedvessegTartalom = value; }
		public int EgeszsegSzint { get => egeszsegSzint; set => egeszsegSzint = value; }
		public int OptimalisSuruseg { get => optimalisSuruseg; set => optimalisSuruseg = value; }
		public string Azonosito { get => Azonosito.Substring(0, 3); }

		public override string ToString()
		{
			return $"{nev} nedevesség: {nedvessegTartalom}, egészség: {egeszsegSzint}, ideális egyedszám: {optimalisSuruseg}";
		}

	}
}
