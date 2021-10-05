using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Jiri", "Sykora");
            p1.Age = 54;

            Person p2 = new Person("Jan", "Novák", 25);

            Console.WriteLine($"Osoba 1: {p1}");
            Console.WriteLine($"Osoba 2: {p2}");
        }
    }
}
