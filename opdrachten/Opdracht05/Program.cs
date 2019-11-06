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
                    fullName += fName.ToLower();
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
            SchrijfLog(str.Length);
            if (str.Length != 16){
                throw new System.ArgumentException("De lengte van een iban moet precies 16 karakters zijn.");
            }
            string numbers = str.Substring(4);
            double modulo = Modulo(Convert.ToDouble(numbers), 97.0);
            SchrijfLog(modulo);
        }
        static void Main(string[] args)
        {
            // Console.WriteLine(runMathFunctions());
            // Console.WriteLine("random number = " + RandomNr());
            // Console.WriteLine("random number with range 100 = " + RandomNr(100));

            // LottoTrekking();
            // EuroMillions();

            /* try
            {
                SchrijfLog(AccountGenerator(args[0], args[1], args[2]));
            }
            catch (System.IndexOutOfRangeException){
                SchrijfLog("Voor de account generator moeten 3 argumenten meegegeven worden!");
            }
            catch (System.Exception)
            {
                SchrijfLog("er is een probleem");
            }*/

            try
            {
                CheckIban("BE07 7390 1412 0066");
            }
            catch (Exception e)
            {
                SchrijfLog(e.Message);
            }
        }
    }
}
