using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2456;
            int b = 45678;

            Console.WriteLine($"a = {a}, b= {b}");
            int res = GetGreaterNumber(a, b);
            if(res == a)
            {
                Console.WriteLine($"Cislo {a} je vetsi nez cislo {b}");
            }
            else
            {
                Console.WriteLine($"Cislo {b} je vetsi nez cislo {a}");
            }
            
        }

        static int GetGreaterNumber(int a, int b)
        {
            if(a > b)
            {
                return a;
            }
            else
            {
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
            Console.WriteLine($"Have a nice day {name}");
        }
    }
}
