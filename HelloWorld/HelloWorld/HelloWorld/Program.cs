using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            const int c_a = 155;
            const int c_b = 255;
            
            int a = 255;
            int b = 1;
            bool res = false;
            
            if (a == c_a || a == c_b)
                res = false;
            else if (a > b)
                res = true;
            else
                res = false;
            
            Console.WriteLine($"a > b: {res}");
            

            
            
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
            Console.WriteLine($"Have a nice day {name}");
        }
    }
}
