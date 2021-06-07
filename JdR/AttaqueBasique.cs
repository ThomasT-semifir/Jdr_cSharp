using System;
using System.Collections.Generic;
using System.Text;

namespace JdR
{
	class AttaqueBasique : IAttaque
	{
		public string Nom { get; set; }
		public string Description { get; set; }
		public int Degats { get; set; }

		public AttaqueBasique(int degats)
		{
			this.Degats = degats;
		}

		public int LancerAttaque(ICombattant lanceur, ICombattant cible)
		{
			Random random = new Random();
			int seuilTouche = random.Next(101);
			if (lanceur.ChanceToucher >= seuilTouche)
			{
				return lanceur.Degats;
			}
			else
			{
				Console.WriteLine($"{lanceur.Nom} rate sa cible");
				return 0;
			}
		}
	}
}
