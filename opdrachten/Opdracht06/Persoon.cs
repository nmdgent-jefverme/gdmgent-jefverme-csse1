using System;

namespace Opdracht06
{
	public class Persoon
	{
        // Velden
		public string voornaam;
		protected char geslacht;

        // Properties
		public char Geslacht
		{
			get
			{
				return geslacht;
			}
			set
			{
				geslacht = value;
			}
		}

		public string Naam
		{
			get;
			set;
		}
        // Constructor
		public Persoon()
		{

		}
		public Persoon(string naam, string voornaam)
		{
			Naam = naam;
			this.voornaam = voornaam;
		}
		public Persoon(string naam, string voornaam, char geslacht)
		{
			Naam = naam;
			this.voornaam = voornaam;
			Geslacht = geslacht;
		}
        // Methods
		public void LogOutput()
		{
			Console.WriteLine(String.Format("Output: Voornaam: {0}, Familienaam: {1}, Geslacht: {2}, geslacht: {3}", this.voornaam, Naam, Geslacht, this.geslacht));
		}
	}
}