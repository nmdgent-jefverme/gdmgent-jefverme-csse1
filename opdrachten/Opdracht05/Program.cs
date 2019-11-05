using System;

namespace Opdracht05
{
    class Program
    {
        static Random rnd = new Random();
        static int som(int a, int b){
            return a + b;
        }
        static int verschil(int a, int b){
            return a - b;
        }
        static double quotient(double a, double b){
            return a/b;
        }
        static int product(int a, int b){
            return a * b;
        }
        static double modulo(double a, double b){
            return a % b;
        }
        static int verhogen(int a){
            return a + 1;
        }
        static int verlagen(int a){
            return a - 1;
        }
        static string runMathFunctions(){
            string output = "5 + 6 = " + som(5,6) + '\n';
            output += "8 - 5 = " + verschil(8,5) + '\n';
            output += "8 / 4 = " + quotient(8,4) + '\n';
            output += "5 * 3 = " + product(5,3) + '\n';
            output += "7 verhogen = " + verhogen(7) + '\n';
            output += "8 verhogen = " + verhogen(8) + '\n';
            return output;
        }
        static int randomNr(int a = 0){
            if(a == 0){
                return rnd.Next();
            } else {
                return rnd.Next(a);
            }
        }
        static void Main(string[] args)
        {
            // Console.WriteLine(runMathFunctions());
            Console.WriteLine("random number = " + randomNr());
            Console.WriteLine("random number with range 100 = " + randomNr(100));
        }
    }
}
