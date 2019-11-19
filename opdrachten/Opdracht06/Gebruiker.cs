using System;
using System.Configuration;
using System.Security.Cryptography;
using System.Text;

namespace Opdracht06
{
	public class Gebruiker : Persoon
	{
		// Velden
		protected string gebruikersnaam;
		protected string wachtwoord;
		protected string login;

		// Variable for Password Generator
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
			this.wachtwoord = CreatePasswordHash(GenereerWachtwoord(), CreateSalt());
		}

		public Gebruiker (string naam, string voornaam, char geslacht, string gebruikersnaam, string login, string wachtwoord) : base(naam, voornaam, geslacht)
		{
			this.gebruikersnaam = gebruikersnaam;
			this.login = login;
			this.wachtwoord = CreatePasswordHash(wachtwoord, CreateSalt());
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

		public new void LogOutput()
		{
			Console.WriteLine(string.Format("Gebruikersnaam: {0}, Login: {1}, Wachtwoord: {2}", Gebruikersnaam, Login, Wachtwoord));
		}

		// Code copied from https://dotnetfiddle.net/yVeOVA
		// @Author: Kiran Unnikrishnan

		protected string CreatePasswordHash(string pwd, string salt)
		{
			string saltAndPwd = String.Concat(pwd, salt);
			string hashedPwd = GetHashString(saltAndPwd);
			var saltPosition = 5;
			hashedPwd = hashedPwd.Insert(saltPosition, salt);
			return hashedPwd;
		}

		protected string CreateSalt()
		{
			RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
			byte[] buff = new byte[10];
			rng.GetBytes(buff);
			var saltSize = 1;
			string salt = Convert.ToBase64String(buff);
			if (salt.Length > saltSize)
			{
				salt = salt.Substring(0, saltSize);
				return salt.ToUpper();
			}

			var saltChar = '^';
			salt = salt.PadRight(saltSize, saltChar);
			return salt.ToUpper();
		}

		protected string GetHashString(string password)
		{
			StringBuilder sb = new StringBuilder();
			foreach (byte b in GetHash(password))
				sb.Append(b.ToString("X2"));
			return sb.ToString();
		}

		protected byte[] GetHash(string password)
		{
			SHA384 sha = new SHA384CryptoServiceProvider();
			return sha.ComputeHash(Encoding.UTF8.GetBytes(password));
		}
	}
}