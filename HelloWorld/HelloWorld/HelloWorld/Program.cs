using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            AddAndPrint(10, 45);
        }

        static void AddAndPrint(int a, int b)
        {
            int sum = a + b;
            Console.WriteLine(sum);
        }
    }
}
