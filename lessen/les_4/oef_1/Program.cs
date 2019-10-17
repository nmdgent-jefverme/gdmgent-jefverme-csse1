using System;

namespace les_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Voorbeelden Integers en doubles");
            // met int
            int fahr = 100;
            int cels = (fahr - 32) * (5/9);
            Console.WriteLine("Fahrenheit berekend met Integer");
            Console.WriteLine(cels);
            // met double
            double cels2 = (fahr - 32.0) * (5.0/9.0);
            Console.WriteLine("Fahrenheit berekend met Double");
            Console.WriteLine(cels2);
            Console.Write('\n');

            // testen met booleans
            Console.WriteLine("Voorbeelden van booleans");
            Boolean test = true;

            Console.WriteLine(test.ToString());
            Console.Write('\n');

            //strings
            Console.WriteLine("Voorbeelden van strings");
            string mijnString = "dit is mijn eerste string";
            string mijnString2 = "dit is mijn\ntweede string"; // let op het \n teken die een nieuwe lijn toevoegd
            Console.WriteLine(mijnString);
            Console.WriteLine(mijnString2);

            string mijnString3 = "hallo";
            string mijnString4 = "iedereen";
            //strings samen voegen
            string mijnString5 = mijnString3 + " " + mijnString4;
            Console.WriteLine(mijnString5);
            Console.Write('\n');

            //voorbeelden met Decimals
            Console.WriteLine("Voorbeelden van Decimals");
            decimal a = 8.5m;
            decimal b = 4.9m;
            decimal result1 = a + b;
            Console.WriteLine("a + b: " + result1);
            decimal result2 = a * b;
            Console.WriteLine("a * b: " + result2);
        }
    }
}
