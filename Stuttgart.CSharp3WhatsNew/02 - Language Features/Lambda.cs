using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LanguageFeaturesDemo {
    class Lambda {
        public static void Execute() {
            // Lambda Expressions sind ähnlich wie anonyme Methoden und erlauben
            // die Inline-Definition von einzeiligen Funktionen.
            // Es sind nur Funktionen erlaubt, die einen Wert zurückgeben und aus einem einzigen
            // Statement besteht.

            // Zum Beispiel sei ein Text gegeben
            var text = "Arma virumque cano Troiae qui primus ab oris ...";

            // die Worte dieses Texts sollen in ein String-Array kopiert werden
            var words = text.SplitIntoWords();

            // jedes der Worte in words soll transformiert werden und 
            // das Ergebnis soll in die Liste lowerWords eingefügt werden
            var lowerWords = new List<string>();

            foreach (var word in words) {
                var transf = Transform(word);

                lowerWords.Add(transf);
            }
            
            // Das Ergebnis kann nun ausgegeben werden

            foreach (var item in lowerWords) {
                Console.WriteLine(item);
            }
            
            // Lamda Expressions erlauben hier einen Einzeiler.
            // Die Select Funktion des String-Arrays wählt jedes Element
            // des Arrays aus, übergibt es an die definierte Lambda Expression
            // und fügt das Ergebnis in die Liste lowerWordsLambda ein.
            var lowerWordsLambda = words.Select(word => word.ToLower());

            foreach (var item in lowerWordsLambda) {
                Console.WriteLine(item);
            }

        }

        static string Transform(string value) {
            return value.ToLower();
        }

    }

    static class StringExtensions {

        public static string[] SplitIntoWords(this string value) {
            char[] seperators = { ' ' };

            return value.Split(seperators);
        }

    }
}
