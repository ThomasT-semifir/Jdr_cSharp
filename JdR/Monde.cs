using System;
using System.Collections.Generic;
using System.Text;

namespace JdR
{
	public static class Monde
	{
		public static List<ICombattant> ListePions = new List<ICombattant>();
		public static Personnage PersonnageFactory()
		{
			Console.WriteLine("Donnez moi le nom: ");
			string nomPerso = Console.ReadLine();
			Console.WriteLine("Donnez moi la classe: ");
			string classePerso = Console.ReadLine();
			Personnage personnage = new Personnage(nomPerso, 100, 2, classePerso);
			ListePions.Add(personnage);
			return personnage;
		}

		public static Monstre MonstreFactory()
		{
			List<string> debutNom = new List<string> { "chaton", "licorne", "chien", "démon", "cactus" };
			List<string> finNom = new List<string> { "brulant", "epineux", "flaboyant", "calciné", "piquant", "mortel" };
			string nomMonstre = GenererNom(debutNom, finNom);
			Monstre monstre = new Monstre(50, 1, nomMonstre);
			ListePions.Add(monstre);
			return monstre;
		}

		private static string GenererNom(List<string> debutNom, List<string> finNom)
		{
			string nom = debutNom[GenererNombreAleatoire(debutNom)] + " "+  finNom[GenererNombreAleatoire(finNom)];

			static int GenererNombreAleatoire(List<string> liste)
			{
				Random random = new Random();
				return random.Next(liste.Count);
			}

			return nom;
		}

		public static void AfficherInformations()
		{
			foreach(ICombattant perso in ListePions)
			{
				Console.WriteLine(perso.ToString());
			}
		}

		public static void AfficherInformations(Personnage personnage)
		{
			Console.WriteLine(personnage.ToString());
		}

		public static void Combat(ICombattant combattant1, ICombattant combattant2)
		{
			int tour = 0;
			while (combattant2.PointDeVie > 0 && combattant1.PointDeVie > 0)
			{
				ICombattant attaquant;
				ICombattant defenseur;
				if (tour % 2 == 0)
				{
					attaquant = combattant1;
					defenseur = combattant2;
				}
				else
				{
					attaquant = combattant2;
					defenseur = combattant1;
				}
				
				attaquant.Attaquer(defenseur);
				Console.WriteLine(defenseur.ToString());
				if(defenseur.PointDeVie <= 0)
				{
				Console.WriteLine($"{attaquant.Nom} a gagné!");
				}
				else
				{
					tour++;
				}
			}
		}
	}
}
