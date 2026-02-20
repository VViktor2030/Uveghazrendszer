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
		public Adattar()
		{
			novenyFajok = new List<NovenyFaj>();
		}


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






	}
}
