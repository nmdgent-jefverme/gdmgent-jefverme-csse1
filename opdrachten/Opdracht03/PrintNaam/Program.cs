using System;

namespace oef06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef uw naam in");
            string name = Convert.ToString(Console.ReadLine());
            foreach (char a in name)
            {
                if(!char.IsWhiteSpace(a))Console.WriteLine(a);
            }
        }
    }
}
