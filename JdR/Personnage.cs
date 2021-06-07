using System;
using System.Collections.Generic;
using System.Text;

namespace JdR
{
	public class Personnage : AbstractCombattant
	{
		public string Classe;
		public Personnage(string nom, int pdv, int degats, string classePerso ) : base(nom, pdv, degats, 75)
		{
			this.Classe = classePerso;
		}
	}
}
