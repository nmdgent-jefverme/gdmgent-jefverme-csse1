using System;

namespace oef02
{
    class Program
    {
        static void Main(string[] args)
        {
            // DEEL A: we berekenen de tafel van 5
            int vermenigvuldiging = 5;
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i + " x " + vermenigvuldiging + " = " + i * vermenigvuldiging);
            }

            // DEEL B: we berekenen alle tafels van 0 tot 10 dmv een geneste loop.
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Tafel van " + i);
                for (int j = 0; j <=10 ; j++)
                {
                    Console.WriteLine(i + " x " + j + " = " + i * j);
                }
            }

            // DEEL C: We vragen de gebruiker een waarde waarvan we de tafel willen kennen
            Console.WriteLine("Geef een getal in tussen 0 en 10");
            int tafel = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i + " x " + tafel + " = " + i * tafel);
            }
        }
    }
}
