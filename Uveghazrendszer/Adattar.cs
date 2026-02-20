using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uveghazrendszer
{
	internal class Adattar
	{
		List<NovenyFaj> novenyFajok;
		UveghazRacs uveghaz;
		List<Kezelo> kezelok;


		public Adattar()
		{
			kezelok = new List<Kezelo>() { new Kezelo("Gipsz Jakab","gj",Szerepkor.KERTESZ), new Kezelo("Aranka néni", "ari",Szerepkor.ADMIN) };
			novenyFajok = new List<NovenyFaj>();
			uveghaz = new UveghazRacs(4);
			uveghaz.Parcellazas();
		}

		internal UveghazRacs Uveghaz { get => uveghaz; set => uveghaz = value; }

		public void UjNoveny(NovenyFaj noveny)
		{
			novenyFajok.Add(noveny);
		}

		public void NovenyekListazasa()
		{
			foreach (var i in novenyFajok)
			{
				Console.WriteLine(i);
			}
		}
		public void Ultetes()
		{
			uveghaz.Ultetes(novenyFajok);
		}




	}
}
