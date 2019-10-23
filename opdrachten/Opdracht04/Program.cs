using System;

namespace voorbereiding
{
    class Program
    {
        private const int getal1 = 8;
        private const int getal2 = 3;
        static int optellen(int a = getal1, int b = getal2){
            return a + b;
        }
        static int aftrekken(int a = getal1, int b = getal2){
            return a - b;
        }
        static int vermenigvuldigen(int a = getal1, int b = getal2){
            return a * b;
        }
        static double delen(double a = (double)getal1, double b = (double)getal2){
            return a / b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(getal1 + " * " + getal2 + " = " + vermenigvuldigen());
            Console.WriteLine(getal1 + " / " + getal2 + " = " + delen());
            Console.WriteLine(getal1 + " + " + getal2 + " = " + optellen());
            Console.WriteLine(getal1 + " - " + getal2 + " = " + aftrekken());
        }
    }
}
