using System;
using System.Collections.Generic;
using System.Text;

namespace JdR
{
	public class AbstractCombattant : ICombattant
	{
		public string Nom { get; set; }
		public int PointDeVie { get; set; }
		public int Degats { get; set; }
		public int ChanceToucher { get; set; }

		public AbstractCombattant(string nom, int pdv, int degats, int chanceToucher)
		{
			this.Nom = nom;
			this.PointDeVie = pdv;
			this.Degats = degats;
			this.ChanceToucher = chanceToucher;
		}

		public void Attaquer(ICombattant adversaire)
		{
			adversaire.Defendre(this.Degats);
		}

		public void Defendre(int degats)
		{
			this.PointDeVie -= degats;
		}

		public override string ToString()
		{
			return $"nom:{this.Nom}, pdv: {this.PointDeVie}, degats:{this.Degats}";
		}
	}
}
