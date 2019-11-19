using System;

namespace Opdracht06
{
    class Program
    {
        static void Main(string[] args)
        {
            Persoon p1 = new Persoon("Doe", "John", 'v');
            p1.LogOutput();
            Gebruiker g1 = new Gebruiker("Parent", "Olivier", 'm');
            g1.LogOutput();
            Student s1 = new Student("Vermeire", "Jef", 'm');
            s1.LogOutput();
            Docent d1 = new Docent("Papito", "Dreirman", 'm');
            d1.LogOutput();
        }
    }
}
