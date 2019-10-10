using System;

namespace les_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // DEEL 1: if, else; switch
            
            int getal = 5;
            Console.WriteLine("Geef een getal in tussen 0 en 10");
            getal = Convert.ToInt32(Console.ReadLine());

            if(getal <= 5){
                Console.WriteLine("waarde van getal: " + getal);
            }
            else if(getal >= 6){
                Console.WriteLine("het getal is groter dan of gelijk aan 6");
            }
            else if(getal >= 7){
                Console.WriteLine("het getal is groter dan of gelijk aan 7");
            }

            switch(getal){
                case 5:
                    Console.WriteLine("Het getal = 5"); //statement
                    break;
                case 6:
                    Console.WriteLine("Het getal is 6");
                    break;
                default:
                    Console.WriteLine("Het getal is een ander getal... :-(");
                    break;
            }

        }
    }
}
