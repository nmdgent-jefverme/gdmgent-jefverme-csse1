using System;

namespace oef05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Van welk getal wil de rij van fibonaci uitrekenen?");
            int fibonaci = Convert.ToInt32(Console.ReadLine());
            int a = 0;
            int b = 1;
            string fibonaciRow = "0";
            for (int i = 1; i < fibonaci; i++)
            {
                fibonaciRow += ", ";
                int temp = a;
                a = b;
                fibonaciRow += Convert.ToString(a);
                b = temp + b;
            }
            Console.WriteLine(fibonaciRow);
        }
    }
}
