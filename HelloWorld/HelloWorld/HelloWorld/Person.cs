using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Person
    {
        // KONSTRUKTOR - vykonává se při vytvoření instance, např. defaultní hodnoty v properties
        // mohu mít několik konstruktorů - včetně parametrů
        public Person()
        {
            FirstName = "-----";
            LastName = "-----";
        }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }
        // PROPERTIES - definice vlastností (Property) - nastaveno čtení i zápis pomocí get/set
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        // metoda - statická = metoda na třídě(nevztahuje se k instanci)
        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }

        // přepis děděné metody - override
        public override string ToString()
        {
            return GetFullName();
        }
    }
}
