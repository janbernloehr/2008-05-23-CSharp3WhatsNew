using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp2Demo {
  /// <summary>
  /// Demo Code für eigene Datentypen
  /// </summary>
  class CustomTypes {

    public static void Execute() {
      // Person erstellen
      Person p = new Person();

      // Eigenschaften setzten
      p.Name = "Jan Molnar";
      p.Age = 20;

      // Methode aufrufen
      Console.WriteLine(p.ToString());
    }


  }

  /// <summary>
  /// Demo Klasse Person 
  /// 
  /// Die Definition einer einfachen Klasse mit zwei Properties
  /// erfordert bereits viel Code.
  /// Dabei haben die Get-ter und Set-ter keine wirkliche Funktion,
  /// sie lesen und setzten jeweils nur ein privates Feld.
  /// </summary>
  public class Person {

    // Felder
    private int age;
    private string name;

    // Eigenschaften
    public int Age {
      get {
        return age;
      }
      set {
        age = value;
      }
    }

    public string Name {
      get {
        return name;
      }
      set {
        name = value;
      }
    }

    // Methoden
    public override string ToString() {
      return string.Format("{0}: {1}", name, age);
    }
  }
}
