using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LanguageFeaturesDemo {
    class ExtensionMethods {

        public static void Execute() {
            // Bisher hat man Hilfsfunktionen zu einem DatenTyp, wie z.B. GetWeekOfYear,
            // die die Kalenderwoche des übergebenen Datums bestimmt,
            // in eine statische Klasse ausgelagert.
            var now = DateTime.Now;

            // Die Hilfsfunktion wird mit DateTimeHelper.GetWeekOfYear(now) aufgerufen
            Console.WriteLine("Wir haben KW: {0}", DateTimeHelper.GetWeekOfYear(now));

            // Wird aber beispielsweise in Teams entwickelt, ist es für andere Team Mitglieder
            // nicht intuitiv auszumachen, dass die Klasse DateTimeHelper existiert und für den Typ
            // DateTime die Methode GetWeekOfYear zur Verfügung stellt.

            // Extension Methods ermöglichen hier einen sehr eleganten Weg, den DatenTyp
            // DateTime mit Methoden zu erweitern. Die IntelliSense zeigt 
            // Extension Methods als Methoden des DatenTyps an.
            Console.WriteLine("Wir haben KW: {0}", now.GetWeekOfYear());

        }
    }

    /// <summary>
    /// Hilfsklasse für DateTime Operationen
    /// </summary>
    static class DateTimeHelper {

        /// <summary>
        /// Gibt die Kalenderwoche zurück.
        /// </summary>
        public static int GetWeekOfYear(this DateTime date) {
            // das this Schlüsselwort informiert den Compiler, dass 
            // GetWeekOfYear den DatenTyp DateTime erweitern soll.
            var cal = new System.Globalization.GregorianCalendar();

            return cal.GetWeekOfYear(date,
                System.Globalization.CalendarWeekRule.FirstFourDayWeek,
                DayOfWeek.Monday);
        }

    }


}
