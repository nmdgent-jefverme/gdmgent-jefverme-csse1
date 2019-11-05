using System;

namespace Opdracht05
{
    class Program
    {
        static int som(int a, int b){
            return a + b;
        }
        static int verschil(int a, int b){
            return a - b;
        }
        static double quotient(double a, double b){
            return a/b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("5 + 6 = " + som(5,6));
            Console.WriteLine("8 - 5 = " + verschil(8,5));
            Console.WriteLine("8 / 4 = " + quotient(8,4));
        }
    }
}
