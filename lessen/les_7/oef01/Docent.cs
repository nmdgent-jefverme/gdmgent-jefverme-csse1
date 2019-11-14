using System;

namespace oef01
{
	public class Docent : Gebruiker
	{
		public Docent(string naam, string voornaam, char geslacht) : base (naam, voornaam, geslacht)
		{
			this.gebruikersnaam = GenereerGebruikersnaam();
			this.login = GenereerLogin();
			this.wachtwoord = GenereerWachtwoord();
		}

		private string GenereerGebruikersnaam()
		{
			string fullName = "";
			if (voornaam.Length < 4){
                fullName += voornaam.ToLower() + Naam.ToLower().Substring(0, 2);
            } else {
                fullName += voornaam.ToLower().Substring(0, 4) + Naam.ToLower().Substring(0, 2);
            }
            return fullName;
		}

		private string GenereerLogin()
		{
			string fullName = "";
			if (voornaam.Length < 4){
                fullName += voornaam.ToLower() + Naam.ToLower().Substring(0, 2);
            } else {
                fullName += voornaam.ToLower().Substring(0, 4) + Naam.ToLower().Substring(0, 2);
            }
            return fullName + "@arteveldehs.be";
		}
		protected new string GenereerWachtwoord()
		{
			string ww = "Do";
			for (int i = 0; i < 10; i++)
			{
				ww += Convert.ToString(rnd.Next(10));
			}
			return ww + "cent";
		}
	}
}