using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
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
