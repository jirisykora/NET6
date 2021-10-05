using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Skoleni
    {
        public static void Sum()
        {
            Console.WriteLine($"Zadej číslo: ");
            int number = int.Parse(Console.ReadLine());

            int sum = 0;
            for (int i = 1; i <= number; i++)
            {
                sum = sum + i;
            }

            Console.WriteLine($"Vysledek: {sum}");
        }


        static string GetDayName(int day)
        {
            switch (day)
            {
                case 1:
                    return "Pondlělí";
                case 2:
                    return "Úterý";
                case 3:
                    return "Středa";
                case 4:
                    return "Čtvrtek";
                case 5:
                    return "Pátek";
                case 6:
                    return "Sobota";
                case 7:
                    return "Neděle";
                default:
                    return "neznámý den";
            }
        }

        static string GenerationPrint(string year)
        {
            int yob = int.Parse(year);
            if (yob >= 1946 && yob <= 1964)
            {
                return "Baby Boomers";
            }
            else if (yob >= 1965 && yob <= 1980)
            {
                return "Generation X";
            }
            else if (yob >= 1981 && yob <= 1996)
            {
                return "Millenials";
            }
            else if (yob >= 1997 && yob <= 2012)
            {
                return "Generation Z";
            }
            else if (yob >= 2013 && yob <= 2021)
            {
                return "Generation Alpha";
            }
            else
            {
                return "UNKNOWN GENERATION";
            }
        }

        static int Max(int a, int b)
        {
            if (a > b)
            {
                Console.WriteLine($"Cislo {a} je vetsi nez cislo {b}");
                return a;
            }
            else
            {
                Console.WriteLine($"Cislo {b} je vetsi nez cislo {a}");
                return b;
            }
        }


        static int AddAndPrint(int a, int b)
        {
            int sum = a + b;
            Console.WriteLine($"{a} + {b} = {sum}");
            return sum;
        }

        static void Hello(string name)
        {
            if (name.ToLower() == "bob" || name.ToLower() == "alice")
            {
                Console.WriteLine($"Vitej zpet {name}");
            }
            else
            {
                Console.WriteLine($"Have a nice day {name}");
            }
        }
    }
}
