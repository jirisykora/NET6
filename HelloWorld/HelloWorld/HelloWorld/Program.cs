using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 20;
            int b = 30;

            Console.WriteLine($"a={a}, b={b}");
            
            int c = a;
            a = b;
            b = c;

            Console.WriteLine($"a={a}, b={b}");

            Console.WriteLine("Hello World!");
            AddAndPrint(10, 45);
            Hello("Jiri");
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
