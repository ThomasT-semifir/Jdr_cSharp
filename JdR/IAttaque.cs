using System;
using System.Collections.Generic;
using System.Text;

namespace JdR
{
	public interface IAttaque
	{
		public string Nom { get; set; }
		public string Description { get; set; }

		public int LancerAttaque(ICombattant lanceur, ICombattant cible);
	}
}
