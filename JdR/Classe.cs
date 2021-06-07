using System;
using System.Collections.Generic;
using System.Text;

namespace JdR
{
	public class Classe
	{
		public string Nom { get; set; }
		public List<IAttaque> Attaques = new List<IAttaque>();

		public Classe(string nom, List<IAttaque> attaques)
		{
			this.Nom = nom;
			this.Attaques = attaques;
		}

		public IAttaque GetAttaque()
		{
			Random rand = new Random();
			return this.Attaques[rand.Next(this.Attaques.Count + 1)];
		}
	}
}
