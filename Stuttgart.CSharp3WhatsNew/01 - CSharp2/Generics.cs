using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp2Demo {
  /// <summary>
  /// Demo Code für C# Generics
  /// </summary>
  class Generics {

    public static void Execute() {
      // Person Liste erstellen
      // Dabei ist List<Person> eine generische Liste,
      // die nur Objekte vom Typ Person als Inhalte zulässt.
      List<Person> persons;

      persons = new List<Person>();
      
      // Person Objekte ersteleln
      Person p1 = new Person();
      p1.Name = "Egon Walter"; p1.Age = 31;

      Person p2 = new Person();
      p2.Name = "Eva Fröhlich"; p2.Age = 23;

      Person p3 = new Person();
      p3.Name = "Hugo Weber"; p3.Age = 42;

      // Liste befüllen
      persons.Add(p1);
      persons.Add(p2);
      persons.Add(p3);

      Console.WriteLine("{0} Objekte vorhanden", persons.Count);
      
      
      // Objekt aus Liste auswählen
      // Hier ist kein Casting notwending, um den gewünschten Typ Person
      // zu erhalten
      Person px = persons[0];

      // Namen ausgeben
      Console.WriteLine(px.Name);
      

      // Generische Listen sind exklusive Listen,
      // nur Objekte vom Typ Person können eingefügt werden.

      //object o = new object();

      //persons.Add(o);
      
      // Als Vergleich dazu eine nicht generische Liste ArrayList,
      // die Objekte von jedem Typ als Inhalte zulässt.
      
      //System.Collections.ArrayList list = new System.Collections.ArrayList();
      //list.Add(p1);

      // Verständlicherweise muss hier beim Zugriff auf die Liste
      // ein Casting durchgeführt werden.
      // Das ist problematisch, wenn unabhängige Komponenten
      // auf diese Liste zugreifen, da nicht sichergestellt wird, dass das Objekt
      // am angeforderten Index wirklich vom gewünschten Typ ist.
      //Person py = list[0];
    }

  }
}
