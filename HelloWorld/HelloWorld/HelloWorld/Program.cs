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

            var o1 = new Person("Jiri", "Sykora", 54);
            var o2 = new Person("Jan", "Novák", 25);
            var o3 = new Person("Josef", "Koblasa", 55);
            var o4 = new Person("Jana", "Novákova", 26);

            lide.Add(o1);
            lide.Add(o2);
            lide.Add(o3);
            lide.Add(o4);

            
            foreach(var p in lide)
            {
                Console.WriteLine(p);
            }

            // ulozit do souboru
            // FirstName;LastName;Age
            string file = "lide.txt";
            foreach (var p in lide)
            {
                var str = $"{p.FirstName};{p.LastName};{p.Age}{Environment.NewLine}";
                File.AppendAllText(file, str);
            }

            Console.WriteLine($"ulozeno do souboru {file}");
        }
    }
}
