using System;
using System.Collections.Generic;
using System.Text;

namespace JdR
{
	public class Monstre : AbstractCombattant
	{
		public Monstre(int pointDeVie, int degats, string nom) : base(nom, pointDeVie, degats, 100)
		{
		}
	}
}
