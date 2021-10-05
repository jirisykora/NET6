using System;
using System.Collections.Generic;
using System.IO;

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

            //list - dynamicka kolekce
            List<Person> lide = new List<Person>();



            // ulozit do souboru
            // FirstName;LastName;Age
            string file = "lide.txt";

            // nacist ze souboru do Listu
            // a vypsat nactene lidi do konzolw

            var str = File.ReadAllLines(file);

            foreach (var line in str)
            {
                var words = line.Split(';');
                var p = new Person(words[0], words[1], int.Parse(words[2]));
                lide.Add(p);
            }

            foreach (var p in lide)
            {
                Console.WriteLine(p);
            }

            
        }
    }
}
