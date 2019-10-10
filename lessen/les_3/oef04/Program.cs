using System;

namespace oef04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef het getal in waarvan je de faculteit wil berekenen");
            int faculteit = Convert.ToInt32(Console.ReadLine());
            int a = 1;
            for (int i = 1; i <= faculteit; i++)
            {
                a = a * i;
            }
            Console.WriteLine(a);
        }
    }
}
