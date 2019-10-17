using System;

namespace oef_2
{
    class Program
    {
        static int Faculteit(int lengte){
            int faculteit = lengte;
            int a = 1;
            for (int i = 1; i <= faculteit; i++)
            {
                a = a * i;
            }
            return a;
        }
        static string Fibonacci(int aantal){
            int a = 0;
            int b = 1;
            string fibonaciRow = "0";
            for (int i = 1; i < aantal; i++)
            {
                fibonaciRow += ", ";
                int temp = a;
                a = b;
                fibonaciRow += Convert.ToString(a);
                b = temp + b;
            }
            return fibonaciRow;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Geef het getal in waarvan je de faculteit wil berekenen");
            int faculteit = Convert.ToInt32(Console.ReadLine());
            int fac = Faculteit(faculteit);
            Console.WriteLine("De faculteit van "+ faculteit + " = " + fac);
            Console.WriteLine("Van welk getal wil de rij van fibonaci uitrekenen?");
            int fibonaci = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Fibonacci(fibonaci));
        }
    }
}
