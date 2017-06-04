using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp2Demo {
    /// <summary>
    /// Demo Code für C# Typensicherheit
    /// </summary>
    class TypeSafe {

        public static void Execute() {
            // C# ist eine typensichere Programmiersprache.
            // Will man mit einer Variablen auf Methoden und Eigenschaften
            // eines Objekts zugreifen, muss die Variable so typisiert sein,
            // dass die Eigenschaften zur Verfügung stehen.
            // Dazu können auch abstrakte Klassen und Interfaces verwendet werden.

            // Definition: [typename] [variablename] = [value];
            string text = "Hallo Stuttgart";

            Console.WriteLine(text);

            // ToUpper ist eine Funktion auf String.
            string upper = text.ToUpper();

            Console.WriteLine(upper);
        }
    }
}
