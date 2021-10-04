﻿using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Zadej teplotu ve F: ");
            var inpstr = Console.ReadLine();
            double temp = double.Parse(inpstr);
            Console.WriteLine($"Teplota je {FahrenheitToCelsius(temp)} °C");
        }

        static double FahrenheitToCelsius(double temp)
        {
            double cel = (temp - 32) / 1.8;

            return cel;
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
