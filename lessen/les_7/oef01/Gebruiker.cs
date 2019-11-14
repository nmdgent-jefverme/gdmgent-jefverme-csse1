using System;

namespace oef01
{
	public class Gebruiker : Persoon1
	{
		// Velden
		protected string gebruikersnaam;
		protected string wachtwoord;
		protected string login;
		protected Random rnd = new Random();
        // Properties
		public string Gebruikersnaam
		{
			get { return this.gebruikersnaam; }
		}

		public string Wachtwoord
		{
			get { return this.wachtwoord; }
		}

		public string Login{
			get { return this.login; }
		}

        // Constructor
		
		public Gebruiker (string naam, string voornaam, char geslacht) : base(naam, voornaam, geslacht)
		{
			this.gebruikersnaam = GenereerGebruikersnaam();
			this.login = GenereerLogin();
			this.wachtwoord = GenereerWachtwoord();
		}

		private string GenereerGebruikersnaam()
		{
			return voornaam + Naam;
		}

		private string GenereerLogin()
		{
			return voornaam + Naam + "@gebruikers.com";
		}

		protected string GenereerWachtwoord()
		{
			string ww = "Geb";
			for (int i = 0; i < 10; i++)
			{
				ww += Convert.ToString(rnd.Next(10));
			}
			return ww + "ruiker";
		}

		public void PrintGebruiker()
		{
			Console.WriteLine(string.Format("Gebruikersnaam: {0}, Login: {1}, Wachtwoord: {2}", Gebruikersnaam, Login, Wachtwoord));
		}

	}
}