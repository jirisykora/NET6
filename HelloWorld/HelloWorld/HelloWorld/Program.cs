using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // úkol:
            // uživatel zadá rok narození a program
            // mu vypíše do jaké patří generace

            // Baby Boomerss — born 1946 - 1964
            // Generation X — born 1965 - 1980
            // Millenials — born 1981 - 1996
            // Generation Z — born 1997 - 2012
            // Generation Alpha — born 2013 -
            Console.WriteLine("Zadej rok narození: ");
            string outstr = GenerationPrint(Console.ReadLine());
            Console.WriteLine($"Patrite do {outstr}");
            //var inpstr = Console.ReadLine();

            


        }


        static string GenerationPrint(string year)
        {
            int yob = int.Parse(year);
            if (yob >= 1946 && yob <= 1964)
            {
                return "Baby Boomers";
            }
            else if(yob >= 1965 && yob <= 1980)
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
            else if (yob >= 2013)
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
            if(a > b)
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
