using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LanguageFeaturesDemo {
    class TypeInference {

        public static void Execute() {

            // Bei einer üblichen Variablen Definition wie,
            // string text = "Arma virumque cano Troiae qui primus ab oris ...";
            // wird der Typ sowohl durch string bestimmt, als auch durch den Wert = "..."

            // Type Inference bei lokalen Variablen ermöglicht es, die Typendefinition
            // auszulassen. Der Compiler (nicht die Runtime!) weißt der Variable dann
            // den Typ zu, der vom Wert definiert wird.

            // Intellisense und Type-Safety bleiben dabei erhalten 
            var text = "Arma virumque cano Troiae qui primus ab oris ...";

            // Type Inference bei generischen Listen
            var personNames = new List<string>();

            personNames.Add("Werner");
            personNames.Add("Egon");
            personNames.Add("Jan");


            // Type Inference bei generischen Methoden
            // Es ist nicht notwendig ToArray<string>(personNames) aufzurufen,
            // der C# Compiler inferiert das generische Argument aus dem Parameter.
            var arr = ToArray(personNames);

            foreach (var item in arr) {
                Console.WriteLine(item);
            }
        }

        private static T[] ToArray<T>(List<T> items) {
            return items.ToArray();
        }
    }
}
