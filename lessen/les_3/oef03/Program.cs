using System;

namespace oef03
{
    class Program
    {
        static void Main(string[] args)
        {
            // DEEL A
            Console.WriteLine("tafels met while loop");
            int i = 1;
            int j = 5;
            while (i <= 10)
            {
                 Console.WriteLine(i + " x " + j + " = " + i * j);
                 i ++;
            }

            // DEEL B
            int x = 1;
            int y = 0;
            while(x <= 10){
                Console.WriteLine("Tafel van " + x);
                while (y <= 10)
                {
                    Console.WriteLine(x + " x " + y + " = " + x * y);
                    y ++;
                }
                x ++;
                y = 0;
            }

            // DEEL C
            int a = 1;
            Console.WriteLine("Geef het getal in waarvan je de tafel wil zien");
            int b = Convert.ToInt32(Console.ReadLine());
            while (a <= 10)
            {
                 Console.WriteLine(a + " x " + b + " = " + a * b);
                 a ++;
            }
            Console.WriteLine('test');
        }
    }
}
