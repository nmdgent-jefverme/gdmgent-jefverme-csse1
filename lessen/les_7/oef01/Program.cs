using System;

namespace oef01
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("Hello World!");
            Persoon p = new Persoon();
            Persoon1 p1 = new Persoon1();
            p1.voornaam = "Jef";
            p1.Geslacht = 'M';
            p1.Naam = "Vermeire";
            p1.LogOutPut();
            Persoon1 p2 = new Persoon1("Doe", "John", 'M');
            p2.LogOutPut(); */
            Gebruiker g1 = new Gebruiker("Doe", "John", 'M');
            g1.PrintGebruiker();
            Student s1 = new Student("Vermeire", "Jef", 'm');
            s1.PrintGebruiker();
            Docent d1 = new Docent("Verplancken", "Franky", 'm');
            d1.PrintGebruiker();
        }

    }

    public class Persoon
    {
        // Velden

        // Properties

        // Constructor

        // Methods

    }
}
