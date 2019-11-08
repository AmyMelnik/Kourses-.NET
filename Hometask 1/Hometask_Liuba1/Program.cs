using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Hometask_Liuba1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first value:");
            string fv = Console.ReadLine();
            while (!int.TryParse(fv, out var r))
            {
                Console.WriteLine("Value is not valid! try again");
                fv = Console.ReadLine();
            }

            int fi = int.Parse(fv);

            Console.Write("Enter second value:");
            string sv = Console.ReadLine();
            while (!int.TryParse(sv,out var r))
            {
                Console.WriteLine("Value is not valid! try again");
                sv = Console.ReadLine();
            }

            int si = int.Parse(sv);

            Console.Write("Choose your fighter (-,+,* or /):");
            string sign = Console.ReadLine();
            switch (sign)
            {
                case "+":
                    Console.WriteLine($"Sum: {fi+si}");
                    break;
                case "-":
                    Console.WriteLine($"Dif: {fi-si}");
                    break;
                case "*":
                    Console.WriteLine($"Mul: {fi*si}");
                    break;
                case "/":
                    Console.WriteLine($"Sub: {fi/si}");
                    break;
                default:
                    Console.WriteLine("Sorry you are invalid? idk what's wrong with you... ");
                    Thread.Sleep(500);
                    Console.WriteLine("Anyway see you next time)");
                    break;
            }

            Console.ReadLine();
        }
    }
}
