using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp2Demo {
    /// <summary>
    /// Demo Code für Anonyme Methoden
    /// 
    /// Anonyme Methoden erlauben es anstatt nur einem Funktionspointer,
    /// eine ganze Funktion inline zu definieren.
    /// </summary>
    class AnonMethods {

        public static void Execute() {
            // Liste von Personen
            List<Person> persons;

            persons = new List<Person>();

            // Personen Objekte erstellen
            Person p1 = new Person();
            p1.Name = "Egon Walter"; p1.Age = 31;

            Person p2 = new Person();
            p2.Name = "Eva Fröhlich"; p2.Age = 23;

            Person p3 = new Person();
            p3.Name = "Hugo Weber"; p3.Age = 42;

            // Objekte zur Liste hinzufügen
            persons.Add(p1);
            persons.Add(p2);
            persons.Add(p3);

            // Ohne Anonyme Methoden

            // Pointer auf Vergleichsfunktion
            // Die Vergleichsfunktion übernimmt den Vergleich eines jeden
            // Elements in einer Liste.
            Comparison<Person> compareMethod = ComparePersons;

            // Liste Sortieren, dabei wird die Vergleichsfunktion verwendet.
            persons.Sort(compareMethod);

            // Liste ausgeben
            foreach (Person p in persons) {
                Console.WriteLine(p.ToString());
            }

            // Liste sortieren, dabei wird eine Inline-Function verwendet,
            // auch diese wird für jedes Element aufgerufen.
            persons.Sort(delegate(Person x, Person y) {
                return x.Age.CompareTo(y.Age);
            });

            // Alternative zum starren foreach-Konstrukt
            persons.ForEach(delegate(Person p) {
                Console.WriteLine(p.ToString());
            });

            // Anonyme Methoden sind eine sehr elegante und kompakte
            // Möglichkeit, um unnötige extra Funktionen zu vermeiden
        }

        /// <summary>
        /// Sortiert nach Person.Age absteigend.
        /// </summary>
        private static int ComparePersons(Person x, Person y) {
            return x.Age.CompareTo(y.Age);
        }

    }
}
