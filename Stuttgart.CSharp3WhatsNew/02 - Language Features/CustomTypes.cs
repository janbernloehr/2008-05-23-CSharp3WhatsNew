using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LanguageFeaturesDemo {
    class CustomTypes {

        public static void Execute() {

            // Objectinitializers in C# 3.0 ermöglichen es, 
            // auch Properties direkt zu intialisieren,
            // dazu ist kein spezieller Konstruktor notwendig.
            var person = new Person
            {
                Name = "Egon Walter",
                Age = 41
            };

            // Ebenso lassen sich generische Listen intialisieren
            var persons = new List<Person>() {
                            new Person() { 
                                Name = "Jan Molnar", 
                                Age = 20},
                            new Person() { 
                                Name = "Eva Fröhlich", 
                                Age = 23}
                            };

            // So intialisierte Listen lassen sich dann
            // dennoch wie gewohnt erweitern ...
            persons.Add(person);

            // ... oder iterieren
            foreach (var item in persons) {
                Console.WriteLine(item.ToString());
            }
        }

    }

    /// <summary>
    /// Person Klasse
    /// </summary>
    public class Person {
        // Property Definitionen können mit C# 3.0
        // sehr kompakt gestaltet werden.

        // Eigenschaften
        public int Age { get; set; }

        public string Name { get; set; }

        // Methoden
        public override string ToString() {
            return string.Format("{0}: {1}", Name, Age);
        }
    }
}
