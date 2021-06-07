using System;

namespace JdR
{
	class Program
	{
		static void Main(string[] args)
		{
			Monde.Combat(Monde.PersonnageFactory(), Monde.MonstreFactory());
		}
	}
}
