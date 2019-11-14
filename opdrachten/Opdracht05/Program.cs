using System;
using System.Threading;


namespace Opdracht05
{
    class Program
    {
        static void SchrijfLog(object input){ Console.WriteLine(input.ToString()); }
        static Random rnd = new Random();
        static int Som(int a, int b){
            return a + b;
        }
        static int Verschil(int a, int b){
            return a - b;
        }
        static double Quotient(double a, double b){
            return a/b;
        }
        static int Product(int a, int b){
            return a * b;
        }
        static double Modulo(double a, double b){
            return a % b;
        }
        static int Verhogen(int a){
            return a + 1;
        }
        static int Verlagen(int a){
            return a - 1;
        }
        static string RunMathFunctions(){
            string output = "5 + 6 = " + Som(5,6) + '\n';
            output += "8 - 5 = " + Verschil(8,5) + '\n';
            output += "8 / 4 = " + Quotient(8,4) + '\n';
            output += "5 * 3 = " + Product(5,3) + '\n';
            output += "7 verhogen = " + Verhogen(7) + '\n';
            output += "8 verhogen = " + Verlagen(8) + '\n';
            return output;
        }
        static int RandomNr(int range = 0){
            if(range == 0){
                return rnd.Next();
            } else {
                return rnd.Next(1, range);
            }
        }
        static int[] GenerateNumberArray(int length, int range){
            int[] nrArray = new int[length];
            for (int i = 0; i < nrArray.Length; i++)
            {
                int nr = RandomNr(range);
                int pos = Array.IndexOf(nrArray, nr);
                while (pos != -1)
                {
                    nr = RandomNr(range);
                    pos = Array.IndexOf(nrArray, nr);
                }
                nrArray[i] = nr;
            }
            return nrArray;
        }
        static void PrintArray(int[] input, int range){
            for (int i = 0; i < input.Length; i++)
            {
                int sleepTimer = 100;
                for (int j = 0; j < 7; j++)
                {
                    Console.Write(RandomNr(range));
                    Thread.Sleep(sleepTimer);
                    Console.Write("\b \b");
                    Console.Write("\b \b");
                    sleepTimer += 50;
                }
                Console.WriteLine(input[i]);
            }
        }
        static void LottoTrekking(){
            Console.WriteLine("De lottotrekking van deze week.");
            int[] nrArray = GenerateNumberArray(6, 45);
            Console.WriteLine("De winnende nummers zijn:");
            PrintArray(nrArray, 45);
        }
        static void EuroMillions(){
            Console.WriteLine("De euromillions trekking van deze week.");
            int[] nrArray = GenerateNumberArray(5, 50);
            Console.WriteLine("De winnende nummers zijn:");
            PrintArray(nrArray, 50);
            int[] starArray = GenerateNumberArray(2, 12);
            Console.WriteLine("De winnende sterren zijn:");
            PrintArray(starArray, 12);
        }

        static string AccountGenerator(string role, string fName, string lName){
            string email = "";
            string fullName = "";
            if(role.ToLower() == "docent"){
                if (fName.Length < 4){
                    fullName += fName.ToLower() + lName.ToLower().Substring(0, 2);
                } else {
                    fullName += fName.ToLower().Substring(0, 4) + lName.ToLower().Substring(0, 2);
                }
                email = "@arteveldehs.be";
            } else if(role.ToLower() == "student"){
                if (fName.Length < 4){
                    fullName += fName.ToLower() + lName.ToLower().Substring(0, 4);
                } else {
                    fullName += fName.ToLower().Substring(0, 4) + lName.ToLower().Substring(0, 4);
                }
                email = "@student.arteveldehs.be";
            }
            return fullName + email;
        }
        static void CheckIban(string iban){
            string str = iban.Replace(" ", "");
            string land = str.Substring(0, 2).ToLower();
            string tmp = "";
            foreach (char c in land)
            {
                tmp+= (int) c - 87;
            }
            tmp += str.Substring(2,2);
            string numbers = str.Substring(4);
            numbers += tmp;
            long mod = Convert.ToInt64(numbers) % 97;
            if (str.Length != 16 || land != "be" || mod != 1){
                throw new System.ArgumentException("Dit is geen geldige IBAN!");
            } else {
                SchrijfLog(iban + " is een geldige IBAN.");
            }
        }
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
        static void RunMenu(){
            SchrijfLog("Welke functie wil u graag testen? Dit zijn de opties:");
            SchrijfLog("1. print de wiskundige functies op het scherm.");
            SchrijfLog("2. Een willekeurig nummer ophalen.");
            SchrijfLog("3. Een willekeurig nummer ophalen binnen een bepaald bereik.");
            SchrijfLog("4. De lottotrekking bekijken.");
            SchrijfLog("5. De euromillions trekking bekijken.");
            SchrijfLog("6. Een account genereren");
            SchrijfLog("7. Een iban controleren");
            SchrijfLog("8. Faculteit berekenen");
            SchrijfLog("9. Rij van fibonaci printen");
            SchrijfLog("10. Programma stoppen");
            SchrijfLog("Geef een nummer in tussen 1 en 10.");
        }
        static void Main(string[] args)
        {
            RunMenu();
            int input = Convert.ToInt32(Console.ReadLine());
            do{
                switch (input)
                {
                    case 1:
                        Console.BackgroundColor = ConsoleColor.Blue;
                        SchrijfLog(RunMathFunctions());
                        Console.BackgroundColor = ConsoleColor.Black;
                        break;
                    case 2:
                        Console.BackgroundColor = ConsoleColor.Blue;
                        SchrijfLog(RandomNr());
                        Console.BackgroundColor = ConsoleColor.Black;
                        break;
                    case 3:
                        Console.BackgroundColor = ConsoleColor.Blue;
                        SchrijfLog("Wat is de range?");
                        int range = Convert.ToInt32(Console.ReadLine());
                        SchrijfLog(RandomNr(range));
                        Console.BackgroundColor = ConsoleColor.Black;
                        break;
                    case 4:
                        Console.BackgroundColor = ConsoleColor.Blue;
                        LottoTrekking();
                        Console.BackgroundColor = ConsoleColor.Black;
                        break;
                    case 5:
                        Console.BackgroundColor = ConsoleColor.Blue;
                        EuroMillions();
                        Console.BackgroundColor = ConsoleColor.Black;
                        break;
                    case 6:
                        Console.BackgroundColor = ConsoleColor.Blue;
                        try
                        {
                            SchrijfLog(AccountGenerator(args[0], args[1], args[2]));
                        }
                        catch (System.IndexOutOfRangeException){
                            SchrijfLog("Voor de account generator moeten 3 argumenten meegegeven worden!");
                        }
                        catch (System.Exception)
                        {
                            SchrijfLog("er is een probleem");
                        }
                        Console.BackgroundColor = ConsoleColor.Black;
                        break;
                    case 7:
                        Console.BackgroundColor = ConsoleColor.Blue;
                        try
                        {
                            CheckIban("BE07 7390 1412 0066");
                        }
                        catch (Exception e)
                        {
                            SchrijfLog(e.Message);
                        }
                        Console.BackgroundColor = ConsoleColor.Black;
                        break;
                    case 8:
                        Console.BackgroundColor = ConsoleColor.Blue;
                        SchrijfLog("Van welk getal wil de faculteit berekenen?");
                        int lengte = Convert.ToInt32(Console.ReadLine());
                        SchrijfLog(Faculteit(lengte));
                        Console.BackgroundColor = ConsoleColor.Black;
                        break;
                    case 9:
                        Console.BackgroundColor = ConsoleColor.Blue;
                        SchrijfLog("Hoeveel getallen wil je in de rij van Fibonacci?");
                        int fib = Convert.ToInt32(Console.ReadLine());
                        SchrijfLog(Fibonacci(fib));
                        Console.BackgroundColor = ConsoleColor.Black;
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        SchrijfLog("het nummer ligt niet tussen 1 en 8!");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                }
                RunMenu();
                input = Convert.ToInt32(Console.ReadLine());
            }while(input != 10);
            SchrijfLog("Programma gestopt");
        }
    }
}
