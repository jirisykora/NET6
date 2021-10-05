﻿using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //// ošetření vyjímky:
            //try
            //{
            //    // nejake prikazy
            //}
            //catch (Exception ex) // muze byt vice bloku a specifikovat typ vyjimky
            //{
            //    // osetreni vyjimky v promenne ex
            //}
            //catch (DivideByZeroException)
            //{
            //    // deleni nulou
            //}




            Person o1 = new Person("Jiri", "Sykora");
            o1.Age = 54;

            Person o2 = new Person("Jan", "Novák", 25);

            Point bod1 = new Point(45, 56);
            Point bod2 = new Point();

            int area = bod1.GetArea();
            Console.WriteLine($"Bod 1 obsah: {area}");

            Console.WriteLine($"Bod 1: {bod1}");
            Console.WriteLine($"Bod 2: {bod2}");
            Console.WriteLine($"Osoba 1: {o1}");
            Console.WriteLine($"Osoba 2: {o2}");
        }
    }
}
