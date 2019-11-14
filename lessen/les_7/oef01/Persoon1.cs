using System;

namespace oef01
{
	public class Persoon1
	{
        // Velden
		public string voornaam;
		private char geslacht;

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
		public Persoon1()
		{

		}
		public Persoon1(string naam, string voornaam)
		{
			Naam = naam;
			this.voornaam = voornaam;
		}
		public Persoon1(string naam, string voornaam, char geslacht)
		{
			Naam = naam;
			this.voornaam = voornaam;
			Geslacht = geslacht;
		}
        // Methods
		public void LogOutPut()
		{
			Console.WriteLine(String.Format("Output: Voornaam: {0}, Familienaam: {1}, Geslacht: {2}, geslacht: {3}", this.voornaam, Naam, Geslacht, this.geslacht));
		}
	}
}