using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CampusLaunch.Linq.BasicQueries {

  /// <summary>
  /// Demo Code für die neuen Sprach Features von C# 3.0.
  /// </summary>
  public class LanuageFeatures {

    /// <summary>
    /// Führt den Demo Code aus.
    /// </summary>
    public void Run() {
      // früher:
      //string text = "Arma virumque cano Troiae qui primus ab oris ...";

      // neu:
      //var text = "Arma virumque cano Troiae qui primus ab oris ...";
      var text = "Arma virumque cano Troiae qui primus ab oris ...";

      var jetzt = DateTime.Now;

      var persons = new List<String>();


      // früher:
      // string[] words = StringExtensions.SplitIntoWords(text);

      // neu:
      var words = text.SplitIntoWords();


      // früher:
      // string[] lowerWords = words.Select(ApplyTransform);

      // neu:
      var lowerWords = words.Select(o => o.ToLower());


      // Ergebnis ausgeben
      foreach (var word in lowerWords) {
        Console.WriteLine(word);
      }
    }

    private string ApplyTransform(string value) {
      return value.ToLower();
    }
  }
}
